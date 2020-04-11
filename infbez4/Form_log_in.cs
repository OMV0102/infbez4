using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;

namespace infbez4
{
    public partial class Form_log_in : Form
    {
        public Form_log_in()
        {
            InitializeComponent();
        }

        private Guid user_id = Guid.Empty;
        private string user_login = string.Empty;
        private string password_table = string.Empty;
        private string user_role = string.Empty;

        // При загрузке приложения
        private void Form_log_in_Load(object sender, EventArgs e)
        {
            checkBox_showPassword.Checked = true; // пароль скрыт по умолчанию
            this.label_status.Visible = false;
            global.canLogin = true;
            global.loginCount = 0;
            global.loginMaxCount = 3;
        }

        // кнопка ВХОД
        private void btn_entry_Click(object sender, EventArgs e)
        {
            this.btn_entry.Enabled = false;
            this.Cursor = Cursors.AppStarting;

            try 
            { 
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand n = new NpgsqlCommand("SELECT id, TRIM(login), TRIM(password), TRIM(role), canlogin FROM pmib6602.users WHERE TRIM(login) = TRIM(@login);", conn);

                n.Parameters.AddWithValue("login", txt_login.Text);

                var sqlReader = n.ExecuteReader();

                if(sqlReader.Read() == false) // если введенный логин не найден
                {
                    this.btn_entry.Enabled = true;
                    this.Cursor = Cursors.Arrow;
                    conn.Close();
                    this.label_status.Visible = true;
                    return;
                }
                Guid user_id = sqlReader.GetGuid(0);
                user_login = sqlReader.GetString(1).ToLower();
                password_table = sqlReader.GetString(2).ToLower();
                user_role = sqlReader.GetString(3).ToLower();
                global.canLogin = sqlReader.GetBoolean(4);
                conn.Close();
                string password_form = functions.getHash(txt_password.Text);

                if(global.canLogin == false) // если у пользователя стоит флаг вводить капчу
                {
                    MessageBox.Show("Превышено максимальное число попыток ввода данных! Введите капчу, чтобы войти...", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    Form_captha form = new Form_captha();
                    form.ShowDialog(this);
                }
                bool passwordComplete = false;
                if(global.canLogin == true)
                {
                    this.nextLoginWitnCaptcha(global.canLogin); // Устанавливаем в БД вход без капчи

                    global.loginCount++;
                    if(password_table == password_form)
                    {
                        Form_browser form = new Form_browser(user_id, user_login, user_role);
                        form.Show(this);
                        this.Hide();
                        passwordComplete = true;
                    }
                    else
                    {
                        passwordComplete = false;
                        this.label_status.Visible = true;
                    }
                }

                // если loginMaxCount и больше раз ввели неправильно то в БД заносим 
                if(global.loginCount >= global.loginMaxCount && passwordComplete == false)
                {
                    global.canLogin = false;
                    this.nextLoginWitnCaptcha(global.canLogin); // Устанавливаем в БД следующий вход с капчей
                }
                
                this.btn_entry.Enabled = true;
                this.Cursor = Cursors.Arrow;
            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message);
            }
        }

        // Пароль показать
        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox_showPassword.Checked == false)
            {
                this.txt_password.UseSystemPasswordChar = false;
                this.checkBox_showPassword.Text = "Пароль виден";
            }
            else
            {
                this.txt_password.UseSystemPasswordChar = true;
                this.checkBox_showPassword.Text = "Пароль скрыт";
            }
        }

        // функции запрета входа без капчи
        private void nextLoginWitnCaptcha(bool canlogin)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand n = new NpgsqlCommand("UPDATE pmib6602.users SET canlogin = @canlogin WHERE TRIM(login) = TRIM(@login);", conn);

                n.Parameters.AddWithValue("canlogin", canlogin);
                n.Parameters.AddWithValue("login", user_login);

                int stringcount = n.ExecuteNonQuery();
            }
            catch(Exception error)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand n = new NpgsqlCommand("INSERT INTO pmib6602.users (id, login, password, role) VALUES (pmib6602.get_uuid(),  @login, @password, @role);", conn);

                n.Parameters.AddWithValue("login", "admin");
                n.Parameters.AddWithValue("password", functions.getHash("admin"));
                n.Parameters.AddWithValue("role", "admin");

                var sqlReader = n.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Если меняем логин
        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            this.label_status.Visible = false;
        }

        // Если меняем пароль
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.label_status.Visible = false;
        }
    }
}

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

        // При загрузке приложения
        private void Form_log_in_Load(object sender, EventArgs e)
        {
            checkBox_showPassword.Checked = true; // пароль скрыт по умолчанию
            this.label_status.Visible = false;
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

                NpgsqlCommand n = new NpgsqlCommand("SELECT id, TRIM(login), TRIM(password), TRIM(role) FROM pmib6602.users WHERE TRIM(login) = TRIM(@login);", conn);

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
                string user_login = sqlReader.GetString(1).ToLower();
                string password_table = sqlReader.GetString(2).ToLower();
                string user_role = sqlReader.GetString(3).ToLower();
                string password_form = functions.getHash(txt_password.Text);
                if(password_table == password_form)
                {
                    Form_browser form = new Form_browser(user_id, user_login, user_role);
                    form.Show(this);
                    this.Hide();
                }
                else
                {
                    this.label_status.Visible = true;
                }
                this.btn_entry.Enabled = true;
                this.Cursor = Cursors.Arrow;
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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

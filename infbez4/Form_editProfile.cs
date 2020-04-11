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
    public partial class Form_editProfile : Form
    {
        public Form_editProfile(Guid id)
        {
            InitializeComponent();

            user_id = id;
        }

        public Guid user_id;
        public string user_login;
        public string user_role;

        // При загрузке формы
        private void Form_editProfile_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("SELECT TRIM(login), TRIM(role) FROM pmib6602.users WHERE id = @id::uuid;", conn);

                query.Parameters.AddWithValue("id", user_id);

                var sqlReader = query.ExecuteReader();

                if(sqlReader.Read() == true) // если введенный логин не найден
                {
                    user_login = sqlReader.GetString(0).ToLower();
                    user_role = sqlReader.GetString(1).ToLower();
                }
                conn.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            this.txt_id.Text = user_id.ToString();
            this.txt_login.Text = user_login;
            this.txt_role.Text = user_role;
            this.btn_loginChange.Visible = false;
            this.checkBox1.Checked = false;

        }

        // Если изменили логин то покажется кнопка для смены
        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            if(txt_login.Text.Length > 0 && user_login != txt_login.Text)
            {
                this.btn_loginChange.Visible = true;
            }
            else
            {
                this.btn_loginChange.Visible = false;
            }
        }

        // кнопка СМЕНИТЬ логин (видна только если)
        private void btn_loginChange_Click(object sender, EventArgs e)
        {
            if(this.txt_login.Text.Length > global.loginMaxLength)
            {
                MessageBox.Show("Новый логин слишком длинный!\nМакс. кол-во символов = " + global.loginMaxLength.ToString(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("UPDATE pmib6602.users SET login = TRIM(@login_new) WHERE id = @id::uuid;", conn);

                query.Parameters.AddWithValue("login_new", this.txt_login.Text);
                query.Parameters.AddWithValue("id", user_id);

                int rowupdateNum = query.ExecuteNonQuery();
                conn.Close();

                if(rowupdateNum == 1)
                {
                    user_login = this.txt_login.Text;
                    this.btn_loginChange.Visible = false;
                    MessageBox.Show("Ваш логин успешно изменён!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    txt_login.Text = user_login;
                    MessageBox.Show("Произошла ошибка при смене логина!\nВозможно он уже кем-то занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show("Произошла ошибка при смене логина!\nВозможно он уже кем-то занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // кнопка вкл выкл смены пароля
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked == false)
            {
                this.checkBox1.Text = "Включить смену пароля";
                this.txt_passwordNew.Enabled = false;
                this.btn_passwordChange.Enabled = false;
            }
            else
            {
                this.checkBox1.Text = "Выключить смену пароля";
                this.txt_passwordNew.Enabled = true;
                this.btn_passwordChange.Enabled = true;
            }
        }

        // кнопка Сохранить пароль
        private void btn_passwordChange_Click(object sender, EventArgs e)
        {
            if(this.txt_passwordNew.Text.Length < 4)
            {
                if(this.txt_passwordNew.Text.Length > global.loginMaxLength)
                MessageBox.Show("Новый пароль слишком короткий!\nМинимальная длина = 4", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else if(this.txt_passwordNew.Text.Length > global.loginMaxLength)
            {
                MessageBox.Show("Новый пароль слишком длинный!\nМакс. кол-во символов = " + global.loginMaxLength.ToString(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("UPDATE pmib6602.users SET password = TRIM(@password_new) WHERE id = @id::uuid;", conn);

                query.Parameters.AddWithValue("password_new", functions.getHash(this.txt_passwordNew.Text));
                query.Parameters.AddWithValue("id", user_id);

                int rowupdateNum = query.ExecuteNonQuery();
                conn.Close();

                if(rowupdateNum == 1)
                {
                    this.txt_passwordNew.Text = "";
                    this.checkBox1.Checked = false;
                    MessageBox.Show("Ваш пароль успешно изменён!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    this.txt_passwordNew.Text = "";
                    MessageBox.Show("Произошла ошибка при смене пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Произошла ошибка при смене пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

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
            
            checkBox_showPassword.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                conn.Open();

                NpgsqlCommand n = new NpgsqlCommand("SELECT TRIM(login), TRIM(password), TRIM(role) FROM pmib6602.users WHERE TRIM(login) = TRIM(@login);", conn);

                n.Parameters.AddWithValue("login", txt_login.Text);

                var sqlReader = n.ExecuteReader();

                if(sqlReader.Read() == false)
                {
                    conn.Close();
                    return;
                }
                string user_login = sqlReader.GetString(0).ToLower();
                string password_table = sqlReader.GetString(1).ToLower();
                string user_role = sqlReader.GetString(2).ToLower();
                string password_form = functions.ByteArrayToStringHEX(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txt_password.Text))).ToLower();
                if(password_table == password_form)
                {
                    Form_browser form = new Form_browser(user_login, user_role);
                    form.Show(this);
                    this.Hide();
                }
                else
                {
                    
                }
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
    }
}

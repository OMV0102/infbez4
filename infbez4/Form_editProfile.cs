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
        public string user_password;
        public string user_role;
        public string user_searchDefault;

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

        }
    }
}

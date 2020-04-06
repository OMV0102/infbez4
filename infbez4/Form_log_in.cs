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
            global.conn = new NpgsqlConnection(global.connectionString);
            global.conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NpgsqlCommand n = new NpgsqlCommand("select pmib6602.get_uuid();", global.conn);
            try
            {


                var t = n.ExecuteScalar();

                txt_login.Text = t.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

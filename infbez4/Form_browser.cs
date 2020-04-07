using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infbez4
{
    public partial class Form_browser : Form
    {
        public Form_browser(string login, string role)
        {
            InitializeComponent();
            this.user_login = login;
            this.user_role = role;
        }

        public string user_login;
        public string user_role;

        private void Form_browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

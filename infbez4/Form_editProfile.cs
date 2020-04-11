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

        // При загрузке формы
        private void Form_editProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

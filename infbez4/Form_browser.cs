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

        // при загрузке формы
        private void Form_browser_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://yandex.ru");
        }

        // кнопка НАЗАД
        private void btn_prev_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        // кнопка Вперед
        private void btn_next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // если нажали Enter после ввода URL
        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_url.Text.Length > 0 )
            {
                if(e.KeyChar == 13)
                {
                    webBrowser1.Navigate(txt_url.Text, false);
                }
            }
        }

        // кнопка перейти к поисковику по умолчанию
        private void btn_GoHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}

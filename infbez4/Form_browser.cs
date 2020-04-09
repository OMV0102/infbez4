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
        public Form_browser(Guid id, string login, string role)
        {
            InitializeComponent();
            user_id = id;
            this.user_login = login;
            this.user_role = role;
        }

        private Guid user_id;
        private string user_login;
        private string user_role;
        private bool web_navigatingORcomplete = false;

        // при ЗАКРЫТИИ формы
        private void Form_browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // выход из приложения
        }

        // при загрузке формы
        private void Form_browser_Load(object sender, EventArgs e)
        {
            this.label_user_login.Text = this.user_login;
            webBrowser1.Navigate(txt_url.Text);
        }

        // кнопка НАЗАД
        private void btn_prev_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            txt_url.Text = webBrowser1.Url.ToString();
        }

        // кнопка Вперед
        private void btn_next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            txt_url.Text = webBrowser1.Url.ToString();
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
            txt_url.Text = webBrowser1.Url.ToString();
        }

        // кнопка ОБНОВИТЬ или СТОП загрузка
        private void btn_refreshOrStop_Click(object sender, EventArgs e)
        {
            if(this.web_navigatingORcomplete == true)
            webBrowser1.Refresh();
        }
    }
}

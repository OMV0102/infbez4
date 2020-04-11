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
    public partial class Form_browser : Form
    {
        public Form_browser(Guid id, string login, string role)
        {
            InitializeComponent();
            user_id = id;
            user_login = login;
            user_role = role;

            // Этих события не отображаются в конструкторе,
            // поэтому вручную должны связать их с их обработчиками событий в коде.
            webBrowser1.CanGoBackChanged += new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.DocumentTitleChanged += new EventHandler(webBrowser1_DocumentTitleChanged);
            webBrowser1.StatusTextChanged += new EventHandler(webBrowser1_StatusTextChanged);

        }

        private Guid user_id;
        private string user_login;
        private string user_role;
        private bool web_navigatingORcomplete = false;
        private string urlnew = "";
        private string user_search;

        // при ЗАКРЫТИИ формы
        private void Form_browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // выход из приложения
        }

        // при загрузке формы
        private void Form_browser_Load(object sender, EventArgs e)
        {
            this.label_user_login.Text = user_login; // вывели логин вверху справа
            this.contextMenu_user.Cursor = Cursors.Hand; // курсор у меню = рука

            // получения адреса поисковика по умолчанию у пользователя
            user_search = global.searchDefault; // по умолчанию глобальный

            if(user_role == global.role_name_limited)  // если роль обычная
            {
                // ничего не загружаем
                this.toolStripSeparator2.Visible = false;
                this.MenuItem_changeSearch.Visible = false;
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                try
                {
                    conn.Open();

                    NpgsqlCommand query = new NpgsqlCommand("SELECT link FROM pmib6602.search_default WHERE id = @id::uuid;", conn);

                    query.Parameters.AddWithValue("id", user_id);

                    var sqlReader = query.ExecuteReader();

                    if(sqlReader.Read() == true) // если введенный логин не найден
                    {
                        user_search = sqlReader.GetString(0);
                    }

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                conn.Close();
            }

            btn_GoHome.PerformClick(); // переход к домашней странице
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
                    webBrowser1.Navigate(txt_url.Text);
                }
            }
        }

        // кнопка перейти к поисковику по умолчанию
        private void btn_GoHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(user_search);
        }

        // кнопка ОБНОВИТЬ или СТОП загрузка
        private void btn_refreshOrStop_Click(object sender, EventArgs e)
        {
            if(this.web_navigatingORcomplete == true)
            {
                webBrowser1.Stop();
                this.web_navigatingORcomplete = false;
                this.btn_refreshOrStop.BackgroundImage = Properties.Resources.arrow;
                this.Cursor = Cursors.Arrow;
            }
            else
            {
                this.web_navigatingORcomplete = true;
                this.btn_refreshOrStop.BackgroundImage = Properties.Resources.cross;
                this.Cursor = Cursors.AppStarting;
                webBrowser1.Refresh();
            }
        }

        // Происходит по завершении загрузки документа элементом управления WebBrowser.
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.web_navigatingORcomplete = false;
            this.btn_refreshOrStop.BackgroundImage = Properties.Resources.arrow;
            this.Cursor = Cursors.Arrow;
            saveLinkInHystory(this.txt_url.Text);
        }

        // Происходит перед переходом элемента управления WebBrowser в новый документ.
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.web_navigatingORcomplete = true;
            this.btn_refreshOrStop.BackgroundImage = Properties.Resources.cross;
            this.Cursor = Cursors.AppStarting;
        }

        // если происходит попытка открыть ссылку в новом окне
        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true; // отмена события
            webBrowser1.Navigate(this.urlnew); // открытие этого же ссылки без нового окна
        }

        // Происходит, когда элемент управления WebBrowser переходит
        // в новый документ и начинает его загрузку.
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_url.Text = webBrowser1.Url.ToString();
            
        }

        // Выключает кнопку назад если перешли в начало навигационной истории.
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_prev.Enabled = webBrowser1.CanGoBack;
        }

        // Выключает кнопку вперед если перешли в конец навигационной истории.
        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_next.Enabled = webBrowser1.CanGoForward;
        }

        // Обновляет заголовок формы на текущий заголовок страницы в браузере
        // Updates the title bar with the current document title.
        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }

        // Если наводим мышь на ссылку то значение статуса ==  адрес ссылки
        // запоминаем адресс новой ссылки чтоб потом при открытии ее в новом окне, открыть просто
        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            this.urlnew = webBrowser1.StatusText;
        }

        // если кликаем по имени юзера для выпадения контекстного меню
        private void label_user_login_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                // если лкм то открыть
                this.contextMenu_user.Show(label_user_login, e.Location, ToolStripDropDownDirection.BelowLeft);
            }
            else
            {
                // если пкм и другие то закрыть и не показывать
                this.contextMenu_user.Close();
            }
        }

        // кнопка РЕДАКТИРОВАНИЕ ПРОФИЛЯ
        private void MenuItem_editProfile_Click(object sender, EventArgs e)
        {
            Form_editProfile form = new Form_editProfile(user_id);
            form.ShowDialog(this);

            user_login = form.user_login;
            label_user_login.Text = user_login;
        }

        // кнопка ПРОСМОТР ИСТОРИИ веб-сёрфинга
        private void MenuItem_showHistory_Click(object sender, EventArgs e)
        {
            Form_historyShow form = new Form_historyShow(user_id);
            form.ShowDialog(this);

            if(form.isNavigate == true)
            {
                webBrowser1.Navigate(form.url);
            }
        }

        // функция сохранения сайта в историю
        private void saveLinkInHystory(string link)
        {
            NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
            try
            {
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("INSERT INTO pmib6602.user_history (id, link) VALUES (@id, @link);", conn);

                query.Parameters.AddWithValue("id", user_id);
                query.Parameters.AddWithValue("link", link);

                query.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }
            conn.Close();
        }

        // кнопка СМЕНИТЬ ПОИСКОВИК
        private void MenuItem_changeSearch_Click(object sender, EventArgs e)
        {
            Form_editSearch form = new Form_editSearch(user_id, user_search);
            form.ShowDialog(this);

            user_search = form.user_search;
        }
    }
}

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
    public partial class Form_historyShow : Form
    {
        public Form_historyShow(Guid id)
        {
            InitializeComponent();
            user_id = id;
            isNavigate = false;
        }

        public Guid user_id;
        public bool isNavigate;
        public string url;

        // при загрузке формы
        private void Form_historyShow_Load(object sender, EventArgs e)
        {
            contextMenu_listBox.Cursor = Cursors.Hand;

            NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
            try
            {
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("SELECT link FROM pmib6602.user_history WHERE id = @id::uuid;", conn);

                query.Parameters.AddWithValue("id", user_id);

                var sqlReader = query.ExecuteReader();

                if(sqlReader.Read() == false) // если введенный логин не найден
                {
                    MessageBox.Show("История пуста!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                    return;
                }
                else
                {
                    do
                    {
                        string linkRead = sqlReader.GetString(0);
                        listBox_hystory.Items.Add(linkRead);
                    }
                    while(sqlReader.Read() == true);
                }

            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }
            conn.Close();
        }

        // кнопка очистить все
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.btn_clear.Enabled = false;

            NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
            try
            {
                conn.Open();

                NpgsqlCommand query = new NpgsqlCommand("DELETE FROM pmib6602.user_history WHERE id = @id::uuid;", conn);

                query.Parameters.AddWithValue("id", user_id);

                query.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }
            conn.Close();
            this.listBox_hystory.Items.Clear(); // очистили на форме
            this.isNavigate = false;
            this.Cursor = Cursors.Arrow;
            this.btn_clear.Enabled = true;
            MessageBox.Show("История успешно очищена!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        // кнопка МЕНЮ ПЕРЕЙТИ НА САЙТ
        private void MenuItem_Navigate_Click(object sender, EventArgs e)
        {
            if(listBox_hystory.SelectedIndex >= 0 || listBox_hystory.SelectedIndex < listBox_hystory.Items.Count)
            {
                this.url = listBox_hystory.SelectedItem.ToString();
                this.isNavigate = true;
                this.Close();
            }
            else
            {
                this.isNavigate = false;
            }
        }

        // момент нажатия ПКМ когда курсор над элементом
        private void listBox_hystory_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int y = e.Y / listBox_hystory.ItemHeight;

                if(y < listBox_hystory.Items.Count)
                    listBox_hystory.SelectedIndex = listBox_hystory.TopIndex + y;
            }
        }

        // при двойном щелчке на сайте в списке
        private void listBox_hystory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.MenuItem_Navigate.PerformClick();
        }
    }
}

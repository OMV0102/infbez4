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
using System.Net.NetworkInformation;


namespace infbez4
{
    public partial class Form_editSearch : Form
    {
        public Form_editSearch(Guid id, String link)
        {
            InitializeComponent();
            user_id = id;
            user_search = link;
        }

        private Guid user_id;
        public string user_search;

        // кнопка Изменить
        private void btn_change_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            this.btn_change.Enabled = false;
            this.txt_link.Enabled = false;

            IPStatus status = IPStatus.Unknown;
            try
            {
                status = new Ping().Send(this.txt_link.Text, 3000).Status;
                if(status == IPStatus.Success)
                {
                    // Сайт доступен
                    try
                    {
                        NpgsqlConnection conn = new NpgsqlConnection(global.connectionString);
                        conn.Open();

                        NpgsqlCommand query = new NpgsqlCommand("UPDATE pmib6602.search_default SET link = TRIM(@link_new) WHERE id = @id::uuid;", conn);

                        query.Parameters.AddWithValue("link_new", this.txt_link.Text);
                        query.Parameters.AddWithValue("id", user_id);

                        int rowupdateNum = query.ExecuteNonQuery();
                        conn.Close();

                        if(rowupdateNum == 1)
                        {
                            user_search = this.txt_link.Text;
                            MessageBox.Show("Поисковая система по умолчанию изменена успешно!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при смене поисковой системы в базе данных!\n Пожалуйста, повторите попытку позже...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("Произошла ошибка при смене поисковой системы в базе данных!\n Пожалуйста, повторите попытку позже...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Сайт по данному адресу не доступен!\nПопробуйте ввести другой адрес...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            
            this.Cursor = Cursors.Arrow;
            this.btn_change.Enabled = true;
            this.txt_link.Enabled = true;
        }

        // кнопка Установить по умолчанию
        private void btn_setDefault_Click(object sender, EventArgs e)
        {
            this.txt_link.Text = global.searchDefault;
            this.btn_change.PerformClick();
        }
    }
}

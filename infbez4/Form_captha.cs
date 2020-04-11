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
    public partial class Form_captha : Form
    {
        public Form_captha()
        {
            InitializeComponent();
        }

        private Int32 WordsNumbers = 6;
        private string WordsFontName = "Arial";
        private Int32 WordsSize = 53;
        private string text_generate = "";
        private bool isBtnOKClick = false;

        // создание самой капчи
        private Bitmap CreateCaptcha(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета для текста
            Brush[] colors =
            {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.White,
                Brushes.Tomato,
                Brushes.Sienna,
                Brushes.Pink
            };

            //Добавим различные цвета линий
            Pen[] colorpens =
            {
                Pens.Black,
                Pens.Red,
                Pens.RoyalBlue,
                Pens.Green,
                Pens.Yellow,
                Pens.White,
                Pens.Tomato,
                Pens.Sienna,
                Pens.Pink
            };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle =
            {
                FontStyle.Bold, // полужирный
                FontStyle.Italic, // курсив
                FontStyle.Regular, // обычный
                FontStyle.Strikeout, // зачеркнутый
                FontStyle.Underline // подчеркнутый
            };

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics picture = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            picture.Clear(Color.Gray);

            //Делаем случайный угол поворота текста
            picture.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text_generate = "";
            string ALF = "1234567890QWERTYUOPASDFGHJKLZXCVBNM";
            for(int i = 0; i < WordsNumbers; ++i)
                text_generate += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            picture.DrawString(text_generate,
            new Font(WordsFontName, WordsSize, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            picture.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            picture.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));

            //Белые точки
            for(int i = 0; i < Width; ++i)
                for(int j = 0; j < Height; ++j)
                    if(rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        // при загрузке формы с капчей
        private void Form_captha_Load(object sender, EventArgs e)
        {
            this.txt_words.MaxLength = WordsNumbers;
            btn_refresh.PerformClick();
        }

        // кнопка ОБНОВИТЬ
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_words.Text = "";
            pictureBox1.Image = this.CreateCaptcha(pictureBox1.Width, pictureBox1.Height);
        }

        // кнопка ОК
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.isBtnOKClick = true;
            if(txt_words.Text.ToLower() == this.text_generate.ToLower())
            {
                txt_words.BackColor = Color.White;
                global.canLogin = true;
                this.Close();
            }
            else
            {
                global.canLogin = false;
                txt_words.BackColor = Color.Red;
                this.btn_refresh.PerformClick();
            }
            
        }

        // ПЕРЕД закрытием формы
        private void Form_captha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.isBtnOKClick == false)
            {
                DialogResult res = MessageBox.Show("Выйти из приложения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(res == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.isBtnOKClick = true;
                    Application.Exit();
                }
            }
            
        }

        // Если тыкаем кнопками на текст то менчем на белый фон нейтральный
        private void txt_words_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txt_words.BackColor = Color.White;
        }
    }
}

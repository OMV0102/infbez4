﻿using System;
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

        // при закрытии капчи закрыть приложение
        private void Form_captha_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

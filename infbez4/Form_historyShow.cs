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
    }
}

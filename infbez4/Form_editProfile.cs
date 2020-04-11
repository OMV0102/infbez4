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
    public partial class Form_editProfile : Form
    {
        public Form_editProfile(Guid id)
        {
            InitializeComponent();

            user_id = id;
        }

        private Guid user_id;


    }
}

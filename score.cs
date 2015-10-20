using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class score : Form ,View
    {
        public score()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            label2.Text = Convert.ToString(((TwoZeroFourEightModel)m).getScore());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

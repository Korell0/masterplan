using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPlanProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _3D_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "e átló: ",
                "f átló: "
            };

            new Sikideg(cimkek).Show();
            this.Hide();
        }

        private void _2D_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "e átló: ",
                "f átló: "
            };
            new Sikideg(cimkek).Show();
            this.Hide();
        }
    }
}

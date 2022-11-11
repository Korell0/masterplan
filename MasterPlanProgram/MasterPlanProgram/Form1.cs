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
            new Sikideg(0, new List<string>() { "Felület: ", "Térfogat: " }).Show();
            this.Hide();
        }

        private void _2D_Click(object sender, EventArgs e)
        {
            new Sikideg(1, new List<string>() { "Kerület: ", "Terület: " }).Show();
            this.Hide();
        }
    }
}

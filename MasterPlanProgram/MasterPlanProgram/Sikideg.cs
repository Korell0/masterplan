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
    public partial class Sikideg : Form
    {
        static Alakzat Elozo;
        static Alakzat Actual;
        
        public Sikideg(List<string> cimkek)
        {
            InitializeComponent();
        }

        private void GenerateInput(List<string> cimkek)
        {
            RemoveVisibleInput();
            Actual = new Alakzat(cimkek);

            for (int i = 0; i < cimkek.Count; i++)
            {
                this.Controls.Add(Actual.Cimkek[i]);
                this.Controls.Add(Actual.Bemenet[i]);
            }
            this.Controls.Add(Actual.Szamol);
        }

        private void RemoveVisibleInput()
        {
            if (Actual != null)
            {
                for (int i = 0; i < Actual.Cimkek.Count; i++)
                {
                    this.Controls.Remove(Actual.Cimkek[i]);
                    this.Controls.Remove(Actual.Bemenet[i]);
                }
                this.Controls.Remove(Actual.Szamol);
            }
        }

        private void gombBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "e átló: ",
                "f átló: "
            };
            GenerateInput(cimkek);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

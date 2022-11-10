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
        static Alakzat Actual;
        static Button Gomb;
        
        public Sikideg(int box)
        {
            InitializeComponent();
            new List<GroupBox>() { groupbox1, groupbox2 }[box].Visible = true;
            groupbox2.Location = groupbox1.Location;
        }

        private void GenerateInput(List<string> cimkek, string hely)
        {
            RemoveVisibleInput();
            Actual = new Alakzat(cimkek, hely);

            for (int i = 0; i < cimkek.Count; i++)
            {
                this.Controls.Add(Actual.Cimkek[i]);
                this.Controls.Add(Actual.Bemenet[i]);
                int valami = i+1;
                Actual.Bemenet[i].Click += delegate (object sender, EventArgs e) { Kijelol(sender, e, Actual.KepHely, valami.ToString()); };
            }
            this.Controls.Add(Actual.Szamol);
            pictureBox1.Image = Image.FromFile($"{hely}0.png");

        }

        private void Kijelol(object sender, EventArgs e, string hely, string nev)
        {
            pictureBox1.Image = Image.FromFile($"{hely}{nev}.png");
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
            string hely = "Alakzatok/Gömb/";
            List<string> cimkek = new List<string>()
            {
                "r sugár: "
            };
            GenerateInput(cimkek, hely);
        }

        private void gulaBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Gúla/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "M magasság:"
            };
            GenerateInput(cimkek, hely);
        }

        private void hengerBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Henger/";
            List<string> cimkek = new List<string>()
            {
                "r sugár: ",
                "M magasság: "
            };
            GenerateInput(cimkek, hely);
            Button gomb = new Button();
            gomb.Location = new Point(375, 225);
            this.Controls.Add(gomb);
            gomb.Text = "Számol";
            Gomb = gomb;



        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

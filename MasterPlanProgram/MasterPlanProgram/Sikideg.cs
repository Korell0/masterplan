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
        
        public Sikideg(int box, List<string> adatok)
        {
            InitializeComponent();
            new List<GroupBox>() { groupbox1, groupbox2 }[box].Visible = true;
            groupbox2.Location = groupbox1.Location;
            label1.Text = adatok[0];
            label2.Text = adatok[1];
        }

        private void GenerateInput(List<string> cimkek, string hely)
        {
            resetBtn.Visible = true;
            textBox1.Visible = true;
            textBox1.Visible = true;
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
            Actual.Szamol.Click += SzamolGomb;
        }

        private void gulaBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Gúla/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "M magasság:"
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolGula;
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
            Actual.Szamol.Click += SzamolHenger;
        }

        private void SzamolHenger(object sender, EventArgs e)
        {
            textBox1.Text = $"{2*Convert.ToDouble(Actual.Bemenet[0].Text)*Math.PI* Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
            textBox2.Text = $"{Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text),2)*Math.PI*Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
        }

        private void SzamolGula(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Actual.Bemenet[0].Text);
            double M = Convert.ToDouble(Actual.Bemenet[1].Text);
            double aM = Math.Sqrt(Math.Pow(a/2, 2) + Math.Pow(M , 2));

            textBox1.Text = $"{((a * aM) / 2) * 4 + Math.Pow(a, 2): 0.00}";
            textBox2.Text = $"{(Math.Pow(a, 2)*M)/3: 0.00}";
        }

        private void SzamolGomb(object sender, EventArgs e)
        {
            textBox1.Text = $"{4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2) * Math.PI : 0.00}";
            textBox2.Text = $"{(4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 3) * Math.PI) / 3 : 0.00}";
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in Actual.Bemenet)
            {
                item.Text = "";
            }
        }
    }
}

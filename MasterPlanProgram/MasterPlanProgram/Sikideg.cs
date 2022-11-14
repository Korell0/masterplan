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
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
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

        private void deltoidBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Deltoid/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "e átló: ",
                "f átló: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolDeltoid;
        }

        private void haromszogBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Háromszög/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "c oldal: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolHaromszog;
        }
        private void paralelogrammaBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Paralelogramma/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "m magasság: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolParalelogramma;
        }
        private void korBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Kör/";
            List<string> cimkek = new List<string>()
            {
                "r sugár: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolKor;
        }
        private void negyzetBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Négyzet/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolNegyzet;
        }
        private void rombuszBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Rombusz/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "e átlő: ",
                "f átló: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolRombusz;
        }
        private void teglalapBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Téglalap/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolTeglalap;
        }
        private void trapezBtn_Click(object sender, EventArgs e)
        {
            string hely = "Alakzatok/Trapéz/";
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "c oldal: "
            };
            GenerateInput(cimkek, hely);
            Actual.Szamol.Click += SzamolTrapez;
        }

        private void SzamolTrapez(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Actual.Bemenet[0].Text);
            double b = Convert.ToDouble(Actual.Bemenet[1].Text);
            double c = Convert.ToDouble(Actual.Bemenet[2].Text);
            double m = Math.Sqrt(Math.Pow(b, 2) - Math.Pow(((a - c) / 2), 2));
            textBox1.Text = $"{a + c + b * 2 : 0.00}";
            textBox2.Text = $"{((a + c) * m) / 2: 0.00}";
        }

        private void SzamolTeglalap(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)): 0.00}";
                textBox2.Text = $"{Convert.ToDouble(Actual.Bemenet[0].Text) * Convert.ToDouble(Actual.Bemenet[1].Text): 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolRombusz(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{4 * Convert.ToDouble(Actual.Bemenet[0].Text): 0.00}";
                textBox2.Text = $"{(Convert.ToDouble(Actual.Bemenet[1].Text) * Convert.ToDouble(Actual.Bemenet[2].Text)) / 2: 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolNegyzet(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{4 * Convert.ToDouble(Actual.Bemenet[0].Text): 0.00}";
                textBox2.Text = $"{ Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2): 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolKor(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{Convert.ToDouble(Actual.Bemenet[0].Text) * 2 * Math.PI : 0.00}";
                textBox2.Text = $"{Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2) * Math.PI : 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolParalelogramma(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)) : 0.00}";
                textBox2.Text = $"{Convert.ToDouble(Actual.Bemenet[1].Text)* Convert.ToDouble(Actual.Bemenet[2].Text) : 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolHaromszog(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                double b = Convert.ToDouble(Actual.Bemenet[1].Text);
                double c = Convert.ToDouble(Actual.Bemenet[2].Text);
                double s = (a + b + c) / 2;
                textBox1.Text = $"{a + b + c: 0.00}";
                textBox2.Text = $"{Math.Sqrt(s*(s-a)*(s-b)*(s-c)): 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SzamolDeltoid(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)): 0.00}";
                textBox2.Text = $"{(Convert.ToDouble(Actual.Bemenet[2].Text) * Convert.ToDouble(Actual.Bemenet[3].Text)) / 2: 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolHenger(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{2*Convert.ToDouble(Actual.Bemenet[0].Text)*Math.PI* Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
                textBox2.Text = $"{Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text),2)*Math.PI*Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolGula(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                double M = Convert.ToDouble(Actual.Bemenet[1].Text);
                double aM = Math.Sqrt(Math.Pow(a/2, 2) + Math.Pow(M , 2));

                textBox1.Text = $"{((a * aM) / 2) * 4 + Math.Pow(a, 2): 0.00}";
                textBox2.Text = $"{(Math.Pow(a, 2)*M)/3: 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolGomb(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"{4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2) * Math.PI : 0.00}";
                textBox2.Text = $"{(4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 3) * Math.PI) / 3 : 0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

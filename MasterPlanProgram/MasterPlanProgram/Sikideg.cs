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
        static Form1 Menu;
        static bool Bezarhat = true;
        
        public Sikideg(int box, List<string> adatok, Form1 menu)
        {
            InitializeComponent();
            Bezarhat = true;
            new List<GroupBox>() { groupbox1, groupbox2 }[box].Visible = true;
            groupbox2.Location = groupbox1.Location;
            label1.Text = adatok[0];
            label2.Text = adatok[1];
            Menu = menu;

        }

        private void GenerateInput(List<string> cimkek, List<Image> kepek)
        {
            resetBtn.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            RemoveVisibleInput();
            Actual = new Alakzat(cimkek, kepek);

            for (int i = 0; i < cimkek.Count; i++)
            {
                this.Controls.Add(Actual.Cimkek[i]);
                this.Controls.Add(Actual.Bemenet[i]);
                int index = i+1;
                Actual.Bemenet[i].Click += delegate (object sender, EventArgs e) { Kijelol(sender, e, Actual.Kepek[index]); };
            }
            this.Controls.Add(Actual.Szamol);
            pictureBox1.Image = Actual.Kepek[0];

        }

        private void Kijelol(object sender, EventArgs e, Image kep)
        {
            pictureBox1.Image = kep;
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
                "r sugár: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.gomb_0, Properties.Resources.gomb_1 });
            Actual.Szamol.Click += SzamolGomb;
        }

        private void gulaBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "M magasság:"
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.gula_0, Properties.Resources.gula_1, Properties.Resources.gula_2 });
            Actual.Szamol.Click += SzamolGula;
        }

        private void hengerBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "r sugár: ",
                "M magasság: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.henger_0, Properties.Resources.henger_1, Properties.Resources.henger_2 });
            Actual.Szamol.Click += SzamolHenger;
        }

        private void deltoidBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "e átló: ",
                "f átló: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.deltoid_0, Properties.Resources.deltoid_1, Properties.Resources.deltoid_2, Properties.Resources.deltoid_3, Properties.Resources.deltoid_4 });
            Actual.Szamol.Click += SzamolDeltoid;
        }

        private void haromszogBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "c oldal: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.haromszog_0, Properties.Resources.haromszog_1, Properties.Resources.haromszog_2, Properties.Resources.haromszog_3 });
            Actual.Szamol.Click += SzamolHaromszog;
        }
        private void paralelogrammaBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "m magasság: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.paralelogramma_0, Properties.Resources.paralelogramma_1, Properties.Resources.paralelogramma_2, Properties.Resources.paralelogramma_3 });
            Actual.Szamol.Click += SzamolParalelogramma;
        }
        private void korBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "r sugár: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.kor_0, Properties.Resources.kor_1});
            Actual.Szamol.Click += SzamolKor;
        }
        private void negyzetBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.negyzet_0, Properties.Resources.negyzet_1 });
            Actual.Szamol.Click += SzamolNegyzet;
        }
        private void rombuszBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "e átló: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.rombusz_0, Properties.Resources.rombusz_1, Properties.Resources.rombusz_2, Properties.Resources.rombusz_3 });
            Actual.Szamol.Click += SzamolRombusz;
        }
        private void teglalapBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.teglalap_0, Properties.Resources.teglalap_1, Properties.Resources.teglalap_2 });
            Actual.Szamol.Click += SzamolTeglalap;
        }
        private void trapezBtn_Click(object sender, EventArgs e)
        {
            List<string> cimkek = new List<string>()
            {
                "a oldal: ",
                "b oldal: ",
                "c oldal: "
            };
            GenerateInput(cimkek, new List<Image>() { Properties.Resources.trapez_0, Properties.Resources.trapez_1, Properties.Resources.trapez_2, Properties.Resources.trapez_3 });
            Actual.Szamol.Click += SzamolTrapez;
        }

        private void SzamolTrapez(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[2].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                    double b = Convert.ToDouble(Actual.Bemenet[1].Text);
                    double c = Convert.ToDouble(Actual.Bemenet[2].Text);
                    double m = Math.Sqrt(Math.Pow(b, 2) - Math.Pow(((a - c) / 2), 2));
                    textBox1.Text = $"{a + c + b * 2 : 0.00}";
                    textBox2.Text = $"{((a + c) * m) / 2: 0.00}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SzamolTeglalap(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)): 0.00}";
                    textBox2.Text = $"{Convert.ToDouble(Actual.Bemenet[0].Text) * Convert.ToDouble(Actual.Bemenet[1].Text): 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                    double _e = Convert.ToDouble(Actual.Bemenet[1].Text);
                    double f = 2 * (Math.Sqrt(Math.Pow(a, 2) - Math.Pow(_e / 2, 2)));
                    textBox1.Text = $"{4 * a: 0.00}";
                    textBox2.Text = $"{(_e * f) / 2: 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox1.Text = $"{4 * Convert.ToDouble(Actual.Bemenet[0].Text): 0.00}";
                    textBox2.Text = $"{ Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2): 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox1.Text = $"{Convert.ToDouble(Actual.Bemenet[0].Text) * 2 * Math.PI: 0.00}";
                    textBox2.Text = $"{Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2) * Math.PI: 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[2].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[2].Text) > Convert.ToDouble(Actual.Bemenet[0].Text))
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)): 0.00}";
                    textBox2.Text = $"{Convert.ToDouble(Actual.Bemenet[1].Text) * Convert.ToDouble(Actual.Bemenet[2].Text): 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[2].Text) <= 0 || HaromszogEgyenlotlen(a, b, c))
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    double s = (a + b + c) / 2;
                    textBox1.Text = $"{a + b + c: 0.00}";
                    textBox2.Text = $"{Math.Sqrt(s*(s-a)*(s-b)*(s-c)): 0.00}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool HaromszogEgyenlotlen(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                return true;
            }
            return false;
        }

        private void SzamolDeltoid(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                double b = Convert.ToDouble(Actual.Bemenet[1].Text);
                double _e = Convert.ToDouble(Actual.Bemenet[2].Text);
                double f = Convert.ToDouble(Actual.Bemenet[3].Text);
                if (a <= 0 || b <= 0 || _e <= 0 || f <= 0 || _e > a + b || f > a + b)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox1.Text = $"{2 * (Convert.ToDouble(Actual.Bemenet[0].Text) + Convert.ToDouble(Actual.Bemenet[1].Text)): 0.00}";
                    textBox2.Text = $"{(Convert.ToDouble(Actual.Bemenet[2].Text) * Convert.ToDouble(Actual.Bemenet[3].Text)) / 2: 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    textBox1.Text = $"{2*Convert.ToDouble(Actual.Bemenet[0].Text)*Math.PI* Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
                    textBox2.Text = $"{Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text),2)*Math.PI*Convert.ToDouble(Actual.Bemenet[1].Text) : 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0 || Convert.ToDouble(Actual.Bemenet[1].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double a = Convert.ToDouble(Actual.Bemenet[0].Text);
                    double M = Convert.ToDouble(Actual.Bemenet[1].Text);
                    double aM = Math.Sqrt(Math.Pow(a/2, 2) + Math.Pow(M , 2));

                    textBox1.Text = $"{((a * aM) / 2) * 4 + Math.Pow(a, 2): 0.00}";
                    textBox2.Text = $"{(Math.Pow(a, 2)*M)/3: 0.00}";
                }
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
                if (Convert.ToDouble(Actual.Bemenet[0].Text) <= 0)
                {
                    MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox2.Text = $"{(4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 3) * Math.PI) / 3 : 0.00}";
                    textBox1.Text = $"{4 * Math.Pow(Convert.ToDouble(Actual.Bemenet[0].Text), 2) * Math.PI : 0.00}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás bemeneti adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Bezarhat)
            {
                Application.Exit();
            }
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

        private void visszaBtn_Click(object sender, EventArgs e)
        {
            Bezarhat = false;
            Menu.Show();
            this.Close();
        }
    }
}

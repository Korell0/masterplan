using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MasterPlanProgram
{
    class Alakzat
    {
        public List<Label> Cimkek = new List<Label>();
        public List<TextBox> Bemenet = new List<TextBox>();
        public Button Szamol = new Button();
        public List<Image> Kepek;

        public Alakzat(List<string> cimkek, List<Image> kepek)
        {
            for (int i = 0; i < cimkek.Count; i++)
            {
                Point nullHelyzet = new Point(100, 100);
                int gap = 60; //px

                Cimkek.Add(new Label());
                Cimkek[i].Location = new Point(nullHelyzet.X, nullHelyzet.Y + i*gap);
                Cimkek[i].Text = cimkek[i];
                Cimkek[i].AutoSize = true;

                Bemenet.Add(new TextBox());
                Bemenet[i].Location = new Point(nullHelyzet.X, nullHelyzet.Y + 15 + i*gap);
                Bemenet[i].Name = $"textbox_{i}";

            }
            Szamol.Text = "Számol";
            Szamol.Location = new Point(375, 225);
            Szamol.Size = new Size(60, 30);

            Kepek = kepek;

        }


    }
}

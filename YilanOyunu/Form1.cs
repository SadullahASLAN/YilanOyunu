using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Label[] Yilan = new Label[3];
        Point[] konumlar = new Point[3];

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (yukari)
            {
                yilan1.Location = new Point(yilan1.Location.X, yilan1.Location.Y - 20);
                if (yilan1.Location.Y < 0)
                {
                    yilan1.Location = new Point(yilan1.Location.X, this.Height - 20);
                }
            }
            else if (asagi)
            {
                yilan1.Location = new Point(yilan1.Location.X, yilan1.Location.Y + 20);
                if (yilan1.Location.Y > this.Height - 20)
                {
                    yilan1.Location = new Point(yilan1.Location.X, 0);
                }
            }
            else if (sag)
            {
                yilan1.Location = new Point(yilan1.Location.X + 20, yilan1.Location.Y);
                if (yilan1.Location.X > this.Width - 20)
                {
                    yilan1.Location = new Point(0, yilan1.Location.Y);
                }
            }
            else if (sol)
            {
                yilan1.Location = new Point(yilan1.Location.X - 20, yilan1.Location.Y);
                if (yilan1.Location.X < 0)
                {
                    yilan1.Location = new Point(this.Width - 20, yilan1.Location.Y);
                }
            }

            for (int i = 0; i < Yilan.Length; i++)
            {
                if (i < Yilan.Length - 1)
                    Yilan[i + 1].Location = konumlar[i];
                konumlar[i] = Yilan[i].Location;
            }

            if (Yilan[0].Location == lbl.Location)
            {
                ElmaOlustur();

                Label lbl = new Label();
                lbl.Width = lbl.Height = 19;
                lbl.BackColor = Color.White;
                lbl.Location = konumlar[konumlar.Length - 1];
                Array.Resize(ref Yilan, Yilan.Length + 1);
                Yilan[Yilan.Length - 1] = lbl;
                Array.Resize(ref konumlar, konumlar.Length + 1);
                konumlar[konumlar.Length - 1] = lbl.Location;
                this.Controls.Add(lbl);
                skor++;
                lblSkor.Text = skor.ToString();
            }

            for (int i = 1; i < konumlar.Length; i++)
            {
                if (Yilan[0].Location == konumlar[i] && skor != 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Yandın.", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        int skor = 0;

        bool yukari, asagi, sag, sol;

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Yilan[0] = yilan1;
            Yilan[1] = yilan2;
            Yilan[2] = yilan3;

            konumlar[0] = yilan1.Location;
            konumlar[1] = yilan2.Location;
            konumlar[2] = yilan3.Location;

            ElmaOlustur();
        }

        Label lbl;

        void ElmaOlustur()
        {
            if (lbl != null)
            {
                lbl.Dispose();
            }
            lbl = new Label();
            lbl.Width = lbl.Height = 19;
            lbl.BackColor = Color.Red;
            lbl.Location = new Point(rnd.Next(35) * 20, rnd.Next(35) * 20);
            atla:
            foreach (var item in konumlar)
            {
                if (item == lbl.Location)
                {
                    lbl.Location = new Point(rnd.Next(35) * 20, rnd.Next(35) * 20);
                    goto atla;
                }
            }
            this.Controls.Add(lbl);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                sag = true;
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!sag)
                    {
                        asagi = false;
                        yukari = false;
                        sag = false;
                        sol = true;
                    }
                    break;
                case Keys.Up:
                    if (!asagi)
                    {
                        asagi = false;
                        yukari = true;
                        sag = false;
                        sol = false;
                    }
                    break;
                case Keys.Right:
                    if (!sol)
                    {
                        asagi = false;
                        yukari = false;
                        sag = true;
                        sol = false;
                    }
                    break;
                case Keys.Down:
                    if (!yukari)
                    {
                        asagi = true;
                        yukari = false;
                        sag = false;
                        sol = false;
                    }
                    break;
            }
        }
    }
}

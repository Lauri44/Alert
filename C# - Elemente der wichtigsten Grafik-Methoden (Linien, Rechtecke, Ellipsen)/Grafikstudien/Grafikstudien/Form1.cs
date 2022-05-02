
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafikstudien
{
    public partial class Form1 : Form
    {
        Graphics grf;                               //Grafik - Objekt deklarieren

        Pen P1 = new Pen(Color.Black, 1);           //Schreiber - Objekt deklarieren / Objekt bilden.
        Pen P2 = new Pen(Color.Red, 6);             //Schreiber - Objekt deklarieren mit Linienstärke 6.
        Pen P3 = new Pen(Color.LightSkyBlue, 3);    //Schreiber - Objekt deklarieren mit Linienstärke 3.

        Brush B1 = new SolidBrush(Color.Green);     //"Bürste", für Flächenfüllungen, grün
        Brush B2 = new SolidBrush(Color.Blue);      //"Bürste", für Flächenfüllungen, blau

        Font F1 = new Font("Times New Roman", 12);  //Schriftsatz für Texte



        public Form1()
        {
            InitializeComponent();
        }


        private void btnMalen_Click(object sender, EventArgs e)
        {
            grf = picAnzeigen.CreateGraphics();
            grf.Clear(Color.Yellow);

            grf.DrawLine(P1, 30, 20, 360, 200);
            grf.FillRectangle(B1, 20, 150, 50, 100);
            grf.DrawEllipse(P2, 200, 40, 130, 70);

            grf.DrawString("Hallo", F1, B2, picAnzeigen.Width / 2, picAnzeigen.Height / 2);
        }


        private void cmdEnde_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void picAnzeigen_MouseMove(object sender, MouseEventArgs e)
        {
            int xPos = e.X;
            int yPos = e.Y;
            lblXWert.Text = "X = " + xPos;
            lblYWert.Text = "Y = " + yPos;
        }
    }
}

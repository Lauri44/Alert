using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Datumsdifferenz
{
    public partial class Form1 : Form
    {
        //          PROGRAMM: DATUMSDIFFERENZ ZWEIER DATUMSWERTE
        // 2 Datumswerte: Heutiges Datum (DateTime.Today()) und Weihnachten dieses 
        // Jahres (dieses Datum wird aus Tag, Monat und gegenwärtigem Jahr zusammengesetzt)
        // Das Programm berechnet, wie lange es noch bis Weihnachten dauert!
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDifferenz_Click(object sender, EventArgs e)
        {
            DateTime heute;
            DateTime weihnachten;
            string weihnachtenString;

            // TimeSpan - objekt, mit dem eine Zeitdifferenz bestimmt werden kann
            TimeSpan differenz; 
 
            int tagesZahl;


            heute = DateTime.Today;     // mit "DateTime.Now" hätte man sogar Datum mit Uhrzeit!
            weihnachtenString = "24.12." + heute.Year;
            weihnachten = Convert.ToDateTime(weihnachtenString);

            txtDatum1.Text = heute.ToString();
            txtDatum2.Text = weihnachten.ToString();

            // die Datumswerte enthalten immer die Pseudo-Uhrzeit "00:00:00" - diese
            // können mit der Stringfunktion "Substring" abgeschnitten werden:
            // dabei wird - beginnend bei Zeichen Nr. 0 ein Teilstring der Länge 10 
            // gebildet - und in den Textfeldern angezeigt!
            txtDatum1.Text = heute.ToString().Substring(0, 10);
            txtDatum2.Text = weihnachten.ToString().Substring(0, 10);

            // Differenz in Tagen - Stunden - Minuten:
            differenz = weihnachten - heute;

            // Differenz in Tagen. (Hier sinnvoll!)
            tagesZahl = differenz.Days;
            lblDifferenz.Text = "Es sind noch " + tagesZahl.ToString() + " Tage bis Weihnachten!";
        }


        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Textdateien_mit_FileStream
{
    public partial class Form1 : Form
    {
        // Form - globale Variablen und Objekte:
        FileStream strom;   // Objektvariable; Instanzierung erfolgt später...!

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSchreiben_Click(object sender, EventArgs e)
        {
            // Objekt (=Instanz) "strom" der FileStream - Klasse erstellen.
            // Übergaben: 1.) Name der Textdatei, 
            // 2.) Modus (hier: Append - zum ERSTELLEN der Textdatei, wenn noch 
            // nicht vorhanden, und zum ANFÜGEN (Append)von Textzeilen an eine 
            // schon bestehende Textdatei, (ÜBERSCHREIBEN? -- mit: "FileMode.Create"!)
            // 3.) Schreibzugriff herstellen.
            strom = new FileStream("Test.txt", FileMode.Append, FileAccess.Write);
            
            // Objekt (=Instanz) "schreiben" der StreamWriter - Klasse erstellen.
            // mit Verweis auf den übergeordneten FileStream "strom".
            StreamWriter schreiben = new StreamWriter(strom);

            // Zeile aus txtSchreiben übernehmen und in die Textdatei schreiben.
            schreiben.WriteLine(txtSchreiben.Text);

            // Nach beendigtem Schreibvorgang wieder schließen des StreamWriters.
            schreiben.Close();
        }


        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLesen_Click(object sender, EventArgs e)
        {
            // Wie oben; jedoch hier: FileMode.Open zum Öffnen einer bestehenden 
            // Textdatei und FileAccess.Read zum Lesen der Daten aus der Textdatei.
            strom = new FileStream("Test.txt", FileMode.Open, FileAccess.Read);

            // Objekt (=Instanz) "lesen" der StreamReader - Klasse erstellen.
            // mit Verweis auf den übergeordneten FileStream "strom".
            StreamReader lesen = new StreamReader(strom);

            string zeile;

            // Solange weitere Daten vorhanden sind --> Einlesen und anzeigen.
            lstAusgabe.Items.Clear();
            while (lesen.Peek() != -1)
            {
                // Zeilen aus der Textdatei einlesen und in lstAusgabe anzeigen.
                zeile = lesen.ReadLine();
                lstAusgabe.Items.Add(zeile);
            }

            // Nach beendigtem Lesevorgang wieder schließen des StreamReaders.
            lesen.Close();
        }
    }
}

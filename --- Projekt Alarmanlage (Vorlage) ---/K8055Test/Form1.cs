using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace K8055Test
{

    public partial class Form1 : Form
    {
        #region Unterprogramme der Karte K8055 - ACHTUNG: NICHT �NDERN !
        public sealed class api
        {
            [DllImport("k8055d.dll")]
            public static extern int OpenDevice(int devNumber);

            [DllImport("k8055d.dll")]
            public static extern void CloseDevice();

            [DllImport("k8055d.dll")]
            public static extern int ReadAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void ReadAllAnalog(ref int Data1, ref int Data2);

            [DllImport("k8055d.dll")]
            public static extern void OutputAnalogChannel(int Channel, int Data);

            [DllImport("k8055d.dll")]
            public static extern void OutputAllAnalog(int Data1, int Data2);

            [DllImport("k8055d.dll")]
            public static extern void ClearAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void SetAllAnalog();

            [DllImport("k8055d.dll")]
            public static extern void ClearAllAnalog();

            [DllImport("k8055d.dll")]
            public static extern void SetAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void WriteAllDigital(int Data);

            [DllImport("k8055d.dll")]
            public static extern void ClearDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void ClearAllDigital();

            [DllImport("k8055d.dll")]
            public static extern void SetDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void SetAllDigital();

            [DllImport("k8055d.dll")]
            public static extern bool ReadDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern int ReadAllDigital();

            [DllImport("k8055d.dll")]
            public static extern int ReadCounter(int CounterNr);

            [DllImport("k8055d.dll")]
            public static extern void ResetCounter(int CounterNr);

            [DllImport("k8055d.dll")]
            public static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

            [DllImport("k8055d.dll")]
            public static extern void Version();

            [DllImport("k8055d.dll")]
            public static extern int SearchDevices();

            [DllImport("k8055d.dll")]
            public static extern int SetCurrentDevice(int lngCardAddress);
        }
        #endregion


        //Globale Variablen der Form1:
       




        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            api.ClearAllDigital();   //Alle Digitalausg�nge zur�cksetzen (Wichtig! - bleiben sonst EIN)
            api.ClearAllAnalog();    //Alle Analogausg�nge zur�cksetzen (Wichtig! - bleiben sonst EIN)
            api.CloseDevice();       //K8055 au�er Betrieb nehmen
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Verbindung mit USB-Karte K8055 herstellen:
            int i = 0;
            int CardAddress = -1;
            do
            {
                CardAddress = api.OpenDevice(i);
                if (CardAddress != -1)
                {
                    lblVerbindung.BackColor = Color.Lime;
                    lblVerbindung.Text = "K 8055 auf Adr. " + CardAddress.ToString() + " verbunden";
                }
                else
                {
                    lblVerbindung.BackColor = Color.Red;
                    lblVerbindung.Text = "Keine Verbindung K 8055!";
                }
                i += 1;
            }
            while (i <= 3 && CardAddress == -1);
        }


        private void btnEnde_Click(object sender, EventArgs e)
        {
            
            this.Close();   //Beenden
        }

    }
}
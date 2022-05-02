namespace K8055Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblVerbindung = new System.Windows.Forms.Label();
            this.btnSignalRücksetzen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDigitalAusgangAus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDigitalAusgangEin = new System.Windows.Forms.Button();
            this.lblDigitalEingang1 = new System.Windows.Forms.Label();
            this.btnEnde = new System.Windows.Forms.Button();
            this.tmrDigitalLesen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(283, 19);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(3, 318);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Label6";
            // 
            // lblVerbindung
            // 
            this.lblVerbindung.BackColor = System.Drawing.SystemColors.Control;
            this.lblVerbindung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVerbindung.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVerbindung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbindung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVerbindung.Location = new System.Drawing.Point(12, 19);
            this.lblVerbindung.Name = "lblVerbindung";
            this.lblVerbindung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVerbindung.Size = new System.Drawing.Size(232, 25);
            this.lblVerbindung.TabIndex = 41;
            this.lblVerbindung.Text = "- - -";
            // 
            // btnSignalRücksetzen
            // 
            this.btnSignalRücksetzen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSignalRücksetzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalRücksetzen.Location = new System.Drawing.Point(27, 250);
            this.btnSignalRücksetzen.Name = "btnSignalRücksetzen";
            this.btnSignalRücksetzen.Size = new System.Drawing.Size(184, 40);
            this.btnSignalRücksetzen.TabIndex = 35;
            this.btnSignalRücksetzen.Text = "Signal Rücksetzen";
            this.btnSignalRücksetzen.UseVisualStyleBackColor = false;
            this.btnSignalRücksetzen.Click += new System.EventHandler(this.btnSignalRücksetzen_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "DIGITALAUSGÄNGE:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "DIGITALEINGÄNGE:";
            // 
            // btnDigitalAusgangAus
            // 
            this.btnDigitalAusgangAus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDigitalAusgangAus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalAusgangAus.Location = new System.Drawing.Point(315, 202);
            this.btnDigitalAusgangAus.Name = "btnDigitalAusgangAus";
            this.btnDigitalAusgangAus.Size = new System.Drawing.Size(231, 40);
            this.btnDigitalAusgangAus.TabIndex = 32;
            this.btnDigitalAusgangAus.Text = "Digitalausgang D1 \"AUS\"";
            this.btnDigitalAusgangAus.UseVisualStyleBackColor = false;
            this.btnDigitalAusgangAus.Click += new System.EventHandler(this.btnDigitalAusgangAus_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 48);
            this.label10.TabIndex = 31;
            this.label10.Text = "Hier wird angezeigt, wenn der  Digitaleingang I1 ein (Tast-) Signal bekommen hat:" +
                "";
            // 
            // btnDigitalAusgangEin
            // 
            this.btnDigitalAusgangEin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDigitalAusgangEin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalAusgangEin.Location = new System.Drawing.Point(315, 154);
            this.btnDigitalAusgangEin.Name = "btnDigitalAusgangEin";
            this.btnDigitalAusgangEin.Size = new System.Drawing.Size(231, 40);
            this.btnDigitalAusgangEin.TabIndex = 30;
            this.btnDigitalAusgangEin.Text = "Digitalausgang D1 \"EIN\"";
            this.btnDigitalAusgangEin.UseVisualStyleBackColor = false;
            this.btnDigitalAusgangEin.Click += new System.EventHandler(this.btnDigitalAusgangEin_Click);
            // 
            // lblDigitalEingang1
            // 
            this.lblDigitalEingang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDigitalEingang1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDigitalEingang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalEingang1.Location = new System.Drawing.Point(27, 206);
            this.lblDigitalEingang1.Name = "lblDigitalEingang1";
            this.lblDigitalEingang1.Size = new System.Drawing.Size(184, 32);
            this.lblDigitalEingang1.TabIndex = 29;
            // 
            // btnEnde
            // 
            this.btnEnde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnde.Location = new System.Drawing.Point(411, 283);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(144, 40);
            this.btnEnde.TabIndex = 28;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = false;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // tmrDigitalLesen
            // 
            this.tmrDigitalLesen.Tick += new System.EventHandler(this.tmrDigitalLesen_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 338);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lblVerbindung);
            this.Controls.Add(this.btnSignalRücksetzen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDigitalAusgangAus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDigitalAusgangEin);
            this.Controls.Add(this.lblDigitalEingang1);
            this.Controls.Add(this.btnEnde);
            this.Name = "Form1";
            this.Text = "K8055 Test (C#)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Label lblVerbindung;
        internal System.Windows.Forms.Button btnSignalRücksetzen;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnDigitalAusgangAus;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btnDigitalAusgangEin;
        internal System.Windows.Forms.Label lblDigitalEingang1;
        internal System.Windows.Forms.Button btnEnde;
        internal System.Windows.Forms.Timer tmrDigitalLesen;
    }
}


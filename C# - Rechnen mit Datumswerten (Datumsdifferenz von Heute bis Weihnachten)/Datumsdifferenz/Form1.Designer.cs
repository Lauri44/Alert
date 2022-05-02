namespace Datumsdifferenz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label11 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lblDifferenz = new System.Windows.Forms.Label();
            this.btnDifferenz = new System.Windows.Forms.Button();
            this.txtDatum1 = new System.Windows.Forms.TextBox();
            this.txtDatum2 = new System.Windows.Forms.TextBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(12, 43);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(316, 24);
            this.Label11.TabIndex = 44;
            this.Label11.Text = "Differenz zweier Datumswerte bilden:";
            // 
            // Label15
            // 
            this.Label15.Location = new System.Drawing.Point(91, 139);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(160, 16);
            this.Label15.TabIndex = 43;
            this.Label15.Text = "2. Datumswert: Weihnachten";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(91, 315);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(160, 16);
            this.Label14.TabIndex = 42;
            this.Label14.Text = "Differenz: Datum2 - Datum1:";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(91, 83);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(112, 16);
            this.Label12.TabIndex = 41;
            this.Label12.Text = "1. Datumswert: Heute";
            // 
            // lblDifferenz
            // 
            this.lblDifferenz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDifferenz.Location = new System.Drawing.Point(91, 331);
            this.lblDifferenz.Name = "lblDifferenz";
            this.lblDifferenz.Size = new System.Drawing.Size(128, 48);
            this.lblDifferenz.TabIndex = 40;
            // 
            // btnDifferenz
            // 
            this.btnDifferenz.Location = new System.Drawing.Point(91, 235);
            this.btnDifferenz.Name = "btnDifferenz";
            this.btnDifferenz.Size = new System.Drawing.Size(128, 49);
            this.btnDifferenz.TabIndex = 39;
            this.btnDifferenz.Text = "Differenz Datum2 - Datum 1 bilden:";
            this.btnDifferenz.Click += new System.EventHandler(this.btnDifferenz_Click);
            // 
            // txtDatum1
            // 
            this.txtDatum1.Location = new System.Drawing.Point(91, 99);
            this.txtDatum1.Name = "txtDatum1";
            this.txtDatum1.Size = new System.Drawing.Size(120, 20);
            this.txtDatum1.TabIndex = 38;
            this.txtDatum1.Text = "22.10.2007";
            // 
            // txtDatum2
            // 
            this.txtDatum2.Location = new System.Drawing.Point(91, 155);
            this.txtDatum2.Name = "txtDatum2";
            this.txtDatum2.Size = new System.Drawing.Size(120, 20);
            this.txtDatum2.TabIndex = 37;
            this.txtDatum2.Text = "25.10.2007";
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(225, 401);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(88, 32);
            this.btnBeenden.TabIndex = 36;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.lblDifferenz);
            this.Controls.Add(this.btnDifferenz);
            this.Controls.Add(this.txtDatum1);
            this.Controls.Add(this.txtDatum2);
            this.Controls.Add(this.btnBeenden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label lblDifferenz;
        internal System.Windows.Forms.Button btnDifferenz;
        internal System.Windows.Forms.TextBox txtDatum1;
        internal System.Windows.Forms.TextBox txtDatum2;
        internal System.Windows.Forms.Button btnBeenden;
    }
}


namespace Grafikstudien
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
            this.btnMalen = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblYWert = new System.Windows.Forms.Label();
            this.lblXWert = new System.Windows.Forms.Label();
            this.picAnzeigen = new System.Windows.Forms.PictureBox();
            this.cmdEnde = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnzeigen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMalen
            // 
            this.btnMalen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalen.Location = new System.Drawing.Point(21, 380);
            this.btnMalen.Name = "btnMalen";
            this.btnMalen.Size = new System.Drawing.Size(320, 40);
            this.btnMalen.TabIndex = 16;
            this.btnMalen.Text = "Einige grafische Elemente zeichnen...";
            this.btnMalen.Click += new System.EventHandler(this.btnMalen_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 92);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 24);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Corsor - Position:";
            // 
            // lblYWert
            // 
            this.lblYWert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYWert.Location = new System.Drawing.Point(21, 156);
            this.lblYWert.Name = "lblYWert";
            this.lblYWert.Size = new System.Drawing.Size(152, 32);
            this.lblYWert.TabIndex = 14;
            this.lblYWert.Text = "Y-Wert";
            // 
            // lblXWert
            // 
            this.lblXWert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblXWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXWert.Location = new System.Drawing.Point(21, 116);
            this.lblXWert.Name = "lblXWert";
            this.lblXWert.Size = new System.Drawing.Size(152, 32);
            this.lblXWert.TabIndex = 13;
            this.lblXWert.Text = "X-Wert";
            // 
            // picAnzeigen
            // 
            this.picAnzeigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnzeigen.Location = new System.Drawing.Point(213, 44);
            this.picAnzeigen.Name = "picAnzeigen";
            this.picAnzeigen.Size = new System.Drawing.Size(400, 300);
            this.picAnzeigen.TabIndex = 12;
            this.picAnzeigen.TabStop = false;
            this.picAnzeigen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAnzeigen_MouseMove);
            // 
            // cmdEnde
            // 
            this.cmdEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnde.Location = new System.Drawing.Point(509, 396);
            this.cmdEnde.Name = "cmdEnde";
            this.cmdEnde.Size = new System.Drawing.Size(128, 40);
            this.cmdEnde.TabIndex = 11;
            this.cmdEnde.Text = "Beenden";
            this.cmdEnde.Click += new System.EventHandler(this.cmdEnde_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(221, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "PictureBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 445);
            this.Controls.Add(this.btnMalen);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblYWert);
            this.Controls.Add(this.lblXWert);
            this.Controls.Add(this.picAnzeigen);
            this.Controls.Add(this.cmdEnde);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAnzeigen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnMalen;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblYWert;
        internal System.Windows.Forms.Label lblXWert;
        internal System.Windows.Forms.PictureBox picAnzeigen;
        internal System.Windows.Forms.Button cmdEnde;
        internal System.Windows.Forms.Label Label1;
    }
}


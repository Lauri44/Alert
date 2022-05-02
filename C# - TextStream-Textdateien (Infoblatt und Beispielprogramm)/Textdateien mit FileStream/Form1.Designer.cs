namespace Textdateien_mit_FileStream
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
            this.btnSchreiben = new System.Windows.Forms.Button();
            this.txtSchreiben = new System.Windows.Forms.TextBox();
            this.btnLesen = new System.Windows.Forms.Button();
            this.lstAusgabe = new System.Windows.Forms.ListBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSchreiben
            // 
            this.btnSchreiben.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchreiben.Location = new System.Drawing.Point(31, 99);
            this.btnSchreiben.Name = "btnSchreiben";
            this.btnSchreiben.Size = new System.Drawing.Size(163, 45);
            this.btnSchreiben.TabIndex = 0;
            this.btnSchreiben.Text = "Zeile schreiben";
            this.btnSchreiben.UseVisualStyleBackColor = true;
            this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
            // 
            // txtSchreiben
            // 
            this.txtSchreiben.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchreiben.Location = new System.Drawing.Point(31, 60);
            this.txtSchreiben.Name = "txtSchreiben";
            this.txtSchreiben.Size = new System.Drawing.Size(163, 26);
            this.txtSchreiben.TabIndex = 2;
            // 
            // btnLesen
            // 
            this.btnLesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLesen.Location = new System.Drawing.Point(31, 270);
            this.btnLesen.Name = "btnLesen";
            this.btnLesen.Size = new System.Drawing.Size(163, 47);
            this.btnLesen.TabIndex = 3;
            this.btnLesen.Text = "Alle Zeilen lesen";
            this.btnLesen.UseVisualStyleBackColor = true;
            this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
            // 
            // lstAusgabe
            // 
            this.lstAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAusgabe.FormattingEnabled = true;
            this.lstAusgabe.ItemHeight = 20;
            this.lstAusgabe.Location = new System.Drawing.Point(236, 33);
            this.lstAusgabe.Name = "lstAusgabe";
            this.lstAusgabe.Size = new System.Drawing.Size(246, 284);
            this.lstAusgabe.TabIndex = 4;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(333, 346);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(163, 47);
            this.btnBeenden.TabIndex = 5;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hier Text eingeben:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lstAusgabe);
            this.Controls.Add(this.btnLesen);
            this.Controls.Add(this.txtSchreiben);
            this.Controls.Add(this.btnSchreiben);
            this.Name = "Form1";
            this.Text = "Schreiben und Lesen von Textdateien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchreiben;
        private System.Windows.Forms.TextBox txtSchreiben;
        private System.Windows.Forms.Button btnLesen;
        private System.Windows.Forms.ListBox lstAusgabe;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label label1;
    }
}


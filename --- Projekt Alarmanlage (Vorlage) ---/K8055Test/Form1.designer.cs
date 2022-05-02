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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVerbindung = new System.Windows.Forms.Label();
            this.btnEnde = new System.Windows.Forms.Button();
            this.tmrDigitalLesen = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSignal1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // btnEnde
            // 
            this.btnEnde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnde.Location = new System.Drawing.Point(541, 592);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(144, 40);
            this.btnEnde.TabIndex = 28;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = false;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // tmrDigitalLesen
            // 
            this.tmrDigitalLesen.Enabled = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblSignal1
            // 
            this.lblSignal1.AutoSize = true;
            this.lblSignal1.Location = new System.Drawing.Point(174, 319);
            this.lblSignal1.Name = "lblSignal1";
            this.lblSignal1.Size = new System.Drawing.Size(35, 13);
            this.lblSignal1.TabIndex = 43;
            this.lblSignal1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 644);
            this.Controls.Add(this.lblSignal1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVerbindung);
            this.Controls.Add(this.btnEnde);
            this.Name = "Form1";
            this.Text = "K8055 Test (C#)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblVerbindung;
        internal System.Windows.Forms.Button btnEnde;
        internal System.Windows.Forms.Timer tmrDigitalLesen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSignal1;
    }
}


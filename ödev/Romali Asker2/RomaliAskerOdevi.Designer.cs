namespace Romali_Asker2
{
    partial class frmRomaliAskerOdevi
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
            this.txtAskerSayisi = new System.Windows.Forms.TextBox();
            this.txtAdimSayisi = new System.Windows.Forms.TextBox();
            this.btnKalanAskerSayisi = new System.Windows.Forms.Button();
            this.lblAskerSayisi = new System.Windows.Forms.Label();
            this.lblAdimSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAskerSayisi
            // 
            this.txtAskerSayisi.Location = new System.Drawing.Point(161, 35);
            this.txtAskerSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAskerSayisi.Name = "txtAskerSayisi";
            this.txtAskerSayisi.Size = new System.Drawing.Size(167, 22);
            this.txtAskerSayisi.TabIndex = 0;
            this.txtAskerSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAskerSayisi_KeyPress);
            this.txtAskerSayisi.Leave += new System.EventHandler(this.txtAskerSayisi_Leave);
            // 
            // txtAdimSayisi
            // 
            this.txtAdimSayisi.Location = new System.Drawing.Point(161, 79);
            this.txtAdimSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdimSayisi.Name = "txtAdimSayisi";
            this.txtAdimSayisi.Size = new System.Drawing.Size(167, 22);
            this.txtAdimSayisi.TabIndex = 1;
            this.txtAdimSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdimSayisi_KeyPress);
            this.txtAdimSayisi.Leave += new System.EventHandler(this.txtAdimSayisi_Leave);
            // 
            // btnKalanAskerSayisi
            // 
            this.btnKalanAskerSayisi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKalanAskerSayisi.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalanAskerSayisi.Location = new System.Drawing.Point(38, 131);
            this.btnKalanAskerSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKalanAskerSayisi.Name = "btnKalanAskerSayisi";
            this.btnKalanAskerSayisi.Size = new System.Drawing.Size(290, 111);
            this.btnKalanAskerSayisi.TabIndex = 2;
            this.btnKalanAskerSayisi.Text = "Kalan Askerleri Göster";
            this.btnKalanAskerSayisi.UseVisualStyleBackColor = false;
            this.btnKalanAskerSayisi.Click += new System.EventHandler(this.btnKalanAskerSayisi_Click);
            // 
            // lblAskerSayisi
            // 
            this.lblAskerSayisi.AutoSize = true;
            this.lblAskerSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAskerSayisi.Location = new System.Drawing.Point(35, 34);
            this.lblAskerSayisi.Name = "lblAskerSayisi";
            this.lblAskerSayisi.Size = new System.Drawing.Size(106, 21);
            this.lblAskerSayisi.TabIndex = 3;
            this.lblAskerSayisi.Text = "Asker Sayısı:";
            // 
            // lblAdimSayisi
            // 
            this.lblAdimSayisi.AutoSize = true;
            this.lblAdimSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdimSayisi.Location = new System.Drawing.Point(35, 78);
            this.lblAdimSayisi.Name = "lblAdimSayisi";
            this.lblAdimSayisi.Size = new System.Drawing.Size(101, 21);
            this.lblAdimSayisi.TabIndex = 4;
            this.lblAdimSayisi.Text = "Adım Sayısı:";
            // 
            // frmRomaliAskerOdevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(368, 272);
            this.Controls.Add(this.lblAdimSayisi);
            this.Controls.Add(this.lblAskerSayisi);
            this.Controls.Add(this.btnKalanAskerSayisi);
            this.Controls.Add(this.txtAdimSayisi);
            this.Controls.Add(this.txtAskerSayisi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRomaliAskerOdevi";
            this.Text = "Romalı Asker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAskerSayisi;
        private System.Windows.Forms.TextBox txtAdimSayisi;
        private System.Windows.Forms.Button btnKalanAskerSayisi;
        private System.Windows.Forms.Label lblAskerSayisi;
        private System.Windows.Forms.Label lblAdimSayisi;
    }
}


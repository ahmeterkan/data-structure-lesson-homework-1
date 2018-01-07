namespace Banka_Otomasyonu
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
            this.btnSirasizListele = new System.Windows.Forms.Button();
            this.btnSiraliListe = new System.Windows.Forms.Button();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.lblToplamSure = new System.Windows.Forms.Label();
            this.txtToplamSure = new System.Windows.Forms.TextBox();
            this.lblOrtalamaSure = new System.Windows.Forms.Label();
            this.txtOrtalamaSure = new System.Windows.Forms.TextBox();
            this.txtSiraliOrtalamaSure = new System.Windows.Forms.TextBox();
            this.lblSiraliOrtalamaSure = new System.Windows.Forms.Label();
            this.txtSiraliToplamSure = new System.Windows.Forms.TextBox();
            this.lblSiraliListeToplamSure = new System.Windows.Forms.Label();
            this.txtSiraliListele = new System.Windows.Forms.TextBox();
            this.lblSirasizListe = new System.Windows.Forms.Label();
            this.lblSiraliListe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSirasizListele
            // 
            this.btnSirasizListele.Location = new System.Drawing.Point(59, 59);
            this.btnSirasizListele.Name = "btnSirasizListele";
            this.btnSirasizListele.Size = new System.Drawing.Size(161, 23);
            this.btnSirasizListele.TabIndex = 0;
            this.btnSirasizListele.Text = "Sırasız Listeyi Listeyi";
            this.btnSirasizListele.UseVisualStyleBackColor = true;
            this.btnSirasizListele.Click += new System.EventHandler(this.btnSirasizListele_Click);
            // 
            // btnSiraliListe
            // 
            this.btnSiraliListe.Location = new System.Drawing.Point(59, 248);
            this.btnSiraliListe.Name = "btnSiraliListe";
            this.btnSiraliListe.Size = new System.Drawing.Size(161, 23);
            this.btnSiraliListe.TabIndex = 1;
            this.btnSiraliListe.Text = "Sirali Listeyi Listele";
            this.btnSiraliListe.UseVisualStyleBackColor = true;
            this.btnSiraliListe.Click += new System.EventHandler(this.btnSiraliListe_Click);
            // 
            // txtListele
            // 
            this.txtListele.Location = new System.Drawing.Point(299, 59);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListele.Size = new System.Drawing.Size(220, 381);
            this.txtListele.TabIndex = 2;
            // 
            // lblToplamSure
            // 
            this.lblToplamSure.AutoSize = true;
            this.lblToplamSure.Location = new System.Drawing.Point(56, 100);
            this.lblToplamSure.Name = "lblToplamSure";
            this.lblToplamSure.Size = new System.Drawing.Size(172, 13);
            this.lblToplamSure.TabIndex = 3;
            this.lblToplamSure.Text = "Sırasız Listede Toplam Geçen Süre";
            // 
            // txtToplamSure
            // 
            this.txtToplamSure.Enabled = false;
            this.txtToplamSure.Location = new System.Drawing.Point(88, 128);
            this.txtToplamSure.Name = "txtToplamSure";
            this.txtToplamSure.Size = new System.Drawing.Size(100, 20);
            this.txtToplamSure.TabIndex = 4;
            // 
            // lblOrtalamaSure
            // 
            this.lblOrtalamaSure.AutoSize = true;
            this.lblOrtalamaSure.Location = new System.Drawing.Point(56, 165);
            this.lblOrtalamaSure.Name = "lblOrtalamaSure";
            this.lblOrtalamaSure.Size = new System.Drawing.Size(179, 13);
            this.lblOrtalamaSure.TabIndex = 5;
            this.lblOrtalamaSure.Text = "Sırasız Listede Ortalama Geçen Süre";
            // 
            // txtOrtalamaSure
            // 
            this.txtOrtalamaSure.Enabled = false;
            this.txtOrtalamaSure.Location = new System.Drawing.Point(88, 198);
            this.txtOrtalamaSure.Name = "txtOrtalamaSure";
            this.txtOrtalamaSure.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalamaSure.TabIndex = 6;
            // 
            // txtSiraliOrtalamaSure
            // 
            this.txtSiraliOrtalamaSure.Enabled = false;
            this.txtSiraliOrtalamaSure.Location = new System.Drawing.Point(88, 402);
            this.txtSiraliOrtalamaSure.Name = "txtSiraliOrtalamaSure";
            this.txtSiraliOrtalamaSure.Size = new System.Drawing.Size(100, 20);
            this.txtSiraliOrtalamaSure.TabIndex = 10;
            // 
            // lblSiraliOrtalamaSure
            // 
            this.lblSiraliOrtalamaSure.AutoSize = true;
            this.lblSiraliOrtalamaSure.Location = new System.Drawing.Point(56, 369);
            this.lblSiraliOrtalamaSure.Name = "lblSiraliOrtalamaSure";
            this.lblSiraliOrtalamaSure.Size = new System.Drawing.Size(179, 13);
            this.lblSiraliOrtalamaSure.TabIndex = 9;
            this.lblSiraliOrtalamaSure.Text = "Sırasız Listede Ortalama Geçen Süre";
            // 
            // txtSiraliToplamSure
            // 
            this.txtSiraliToplamSure.Enabled = false;
            this.txtSiraliToplamSure.Location = new System.Drawing.Point(88, 332);
            this.txtSiraliToplamSure.Name = "txtSiraliToplamSure";
            this.txtSiraliToplamSure.Size = new System.Drawing.Size(100, 20);
            this.txtSiraliToplamSure.TabIndex = 8;
            // 
            // lblSiraliListeToplamSure
            // 
            this.lblSiraliListeToplamSure.AutoSize = true;
            this.lblSiraliListeToplamSure.Location = new System.Drawing.Point(56, 304);
            this.lblSiraliListeToplamSure.Name = "lblSiraliListeToplamSure";
            this.lblSiraliListeToplamSure.Size = new System.Drawing.Size(164, 13);
            this.lblSiraliListeToplamSure.TabIndex = 7;
            this.lblSiraliListeToplamSure.Text = "Sıralı Listede Toplam Geçen Süre";
            // 
            // txtSiraliListele
            // 
            this.txtSiraliListele.Location = new System.Drawing.Point(541, 59);
            this.txtSiraliListele.Multiline = true;
            this.txtSiraliListele.Name = "txtSiraliListele";
            this.txtSiraliListele.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSiraliListele.Size = new System.Drawing.Size(220, 381);
            this.txtSiraliListele.TabIndex = 11;
            // 
            // lblSirasizListe
            // 
            this.lblSirasizListe.AutoSize = true;
            this.lblSirasizListe.Location = new System.Drawing.Point(379, 40);
            this.lblSirasizListe.Name = "lblSirasizListe";
            this.lblSirasizListe.Size = new System.Drawing.Size(62, 13);
            this.lblSirasizListe.TabIndex = 12;
            this.lblSirasizListe.Text = "Sırasız Liste";
            // 
            // lblSiraliListe
            // 
            this.lblSiraliListe.AutoSize = true;
            this.lblSiraliListe.Location = new System.Drawing.Point(620, 40);
            this.lblSiraliListe.Name = "lblSiraliListe";
            this.lblSiraliListe.Size = new System.Drawing.Size(54, 13);
            this.lblSiraliListe.TabIndex = 13;
            this.lblSiraliListe.Text = "Sıralı Liste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 452);
            this.Controls.Add(this.lblSiraliListe);
            this.Controls.Add(this.lblSirasizListe);
            this.Controls.Add(this.txtSiraliListele);
            this.Controls.Add(this.txtSiraliOrtalamaSure);
            this.Controls.Add(this.lblSiraliOrtalamaSure);
            this.Controls.Add(this.txtSiraliToplamSure);
            this.Controls.Add(this.lblSiraliListeToplamSure);
            this.Controls.Add(this.txtOrtalamaSure);
            this.Controls.Add(this.lblOrtalamaSure);
            this.Controls.Add(this.txtToplamSure);
            this.Controls.Add(this.lblToplamSure);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.btnSiraliListe);
            this.Controls.Add(this.btnSirasizListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSirasizListele;
        private System.Windows.Forms.Button btnSiraliListe;
        private System.Windows.Forms.TextBox txtListele;
        private System.Windows.Forms.Label lblToplamSure;
        private System.Windows.Forms.TextBox txtToplamSure;
        private System.Windows.Forms.Label lblOrtalamaSure;
        private System.Windows.Forms.TextBox txtOrtalamaSure;
        private System.Windows.Forms.TextBox txtSiraliOrtalamaSure;
        private System.Windows.Forms.Label lblSiraliOrtalamaSure;
        private System.Windows.Forms.TextBox txtSiraliToplamSure;
        private System.Windows.Forms.Label lblSiraliListeToplamSure;
        private System.Windows.Forms.TextBox txtSiraliListele;
        private System.Windows.Forms.Label lblSirasizListe;
        private System.Windows.Forms.Label lblSiraliListe;
    }
}


namespace Ziemiecki_42601_Projekt5
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
            this.label1 = new System.Windows.Forms.Label();
            this.iz_cmbPodstawaLiczby = new System.Windows.Forms.ComboBox();
            this.iz_txtLiczba = new System.Windows.Forms.TextBox();
            this.iz_btnResetuj = new System.Windows.Forms.Button();
            this.iz_txtWynik = new System.Windows.Forms.TextBox();
            this.iz_btnKonwertuj = new System.Windows.Forms.Button();
            this.iz_btnWyjscie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iz_cmbPodstawaWyjsciowa = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konwerter liczb o różnej podstawie systemu liczbowego";
            // 
            // iz_cmbPodstawaLiczby
            // 
            this.iz_cmbPodstawaLiczby.FormattingEnabled = true;
            this.iz_cmbPodstawaLiczby.Items.AddRange(new object[] {
            "Dwójkowy",
            "Trójkowy",
            "Piątkowy",
            "Ósemkowy",
            "Dziesiętny",
            "Szesnastkowy",
            "Trzydziestkowy"});
            this.iz_cmbPodstawaLiczby.Location = new System.Drawing.Point(78, 107);
            this.iz_cmbPodstawaLiczby.Name = "iz_cmbPodstawaLiczby";
            this.iz_cmbPodstawaLiczby.Size = new System.Drawing.Size(121, 21);
            this.iz_cmbPodstawaLiczby.TabIndex = 1;
            // 
            // iz_txtLiczba
            // 
            this.iz_txtLiczba.Location = new System.Drawing.Point(78, 187);
            this.iz_txtLiczba.Name = "iz_txtLiczba";
            this.iz_txtLiczba.Size = new System.Drawing.Size(121, 20);
            this.iz_txtLiczba.TabIndex = 2;
            this.iz_txtLiczba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iz_btnResetuj
            // 
            this.iz_btnResetuj.Location = new System.Drawing.Point(78, 254);
            this.iz_btnResetuj.Name = "iz_btnResetuj";
            this.iz_btnResetuj.Size = new System.Drawing.Size(84, 41);
            this.iz_btnResetuj.TabIndex = 3;
            this.iz_btnResetuj.Text = "Resetuj";
            this.iz_btnResetuj.UseVisualStyleBackColor = true;
            this.iz_btnResetuj.Click += new System.EventHandler(this.iz_btnResetuj_Click);
            // 
            // iz_txtWynik
            // 
            this.iz_txtWynik.Enabled = false;
            this.iz_txtWynik.Location = new System.Drawing.Point(474, 187);
            this.iz_txtWynik.Name = "iz_txtWynik";
            this.iz_txtWynik.Size = new System.Drawing.Size(121, 20);
            this.iz_txtWynik.TabIndex = 5;
            this.iz_txtWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iz_btnKonwertuj
            // 
            this.iz_btnKonwertuj.Location = new System.Drawing.Point(301, 162);
            this.iz_btnKonwertuj.Name = "iz_btnKonwertuj";
            this.iz_btnKonwertuj.Size = new System.Drawing.Size(75, 69);
            this.iz_btnKonwertuj.TabIndex = 6;
            this.iz_btnKonwertuj.Text = "Konwertuj";
            this.iz_btnKonwertuj.UseVisualStyleBackColor = true;
            this.iz_btnKonwertuj.Click += new System.EventHandler(this.iz_btnKonwertuj_Click);
            // 
            // iz_btnWyjscie
            // 
            this.iz_btnWyjscie.Location = new System.Drawing.Point(511, 254);
            this.iz_btnWyjscie.Name = "iz_btnWyjscie";
            this.iz_btnWyjscie.Size = new System.Drawing.Size(84, 41);
            this.iz_btnWyjscie.TabIndex = 7;
            this.iz_btnWyjscie.Text = "Zakończ program";
            this.iz_btnWyjscie.UseVisualStyleBackColor = true;
            this.iz_btnWyjscie.Click += new System.EventHandler(this.iz_btnWyjscie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Podstawa systemu liczbowego\r\nliczby konwertowanej\r\n(początkowej)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(410, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Podstawa systemu liczbowego\r\nna który liczba zostaje skonwertowana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(65, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liczba konwertowana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(517, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wynik";
            // 
            // iz_cmbPodstawaWyjsciowa
            // 
            this.iz_cmbPodstawaWyjsciowa.FormattingEnabled = true;
            this.iz_cmbPodstawaWyjsciowa.Items.AddRange(new object[] {
            "Dwójkowy",
            "Trójkowy",
            "Piątkowy",
            "Ósemkowy",
            "Dziesiętny",
            "Szesnastkowy",
            "Trzydziestkowy"});
            this.iz_cmbPodstawaWyjsciowa.Location = new System.Drawing.Point(474, 107);
            this.iz_cmbPodstawaWyjsciowa.Name = "iz_cmbPodstawaWyjsciowa";
            this.iz_cmbPodstawaWyjsciowa.Size = new System.Drawing.Size(121, 21);
            this.iz_cmbPodstawaWyjsciowa.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 341);
            this.Controls.Add(this.iz_cmbPodstawaWyjsciowa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iz_btnWyjscie);
            this.Controls.Add(this.iz_btnKonwertuj);
            this.Controls.Add(this.iz_txtWynik);
            this.Controls.Add(this.iz_btnResetuj);
            this.Controls.Add(this.iz_txtLiczba);
            this.Controls.Add(this.iz_cmbPodstawaLiczby);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Konwerter systemowy liczb";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox iz_cmbPodstawaLiczby;
        private System.Windows.Forms.TextBox iz_txtLiczba;
        private System.Windows.Forms.Button iz_btnResetuj;
        private System.Windows.Forms.TextBox iz_txtWynik;
        private System.Windows.Forms.Button iz_btnKonwertuj;
        private System.Windows.Forms.Button iz_btnWyjscie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox iz_cmbPodstawaWyjsciowa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


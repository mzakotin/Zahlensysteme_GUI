namespace Zahlensysteme_GUI
{
    partial class Fm_Zahlensysteme
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
            this.TB_Binaer = new System.Windows.Forms.TextBox();
            this.L_Binaer = new System.Windows.Forms.Label();
            this.L_Oktal = new System.Windows.Forms.Label();
            this.TB_Oktal = new System.Windows.Forms.TextBox();
            this.L_Dezimal = new System.Windows.Forms.Label();
            this.TB_Dezimal = new System.Windows.Forms.TextBox();
            this.L_Hexadezimal = new System.Windows.Forms.Label();
            this.TB_Hexadezimal = new System.Windows.Forms.TextBox();
            this.GB_Zahlensysteme = new System.Windows.Forms.GroupBox();
            this.RB_Hexadezimal = new System.Windows.Forms.RadioButton();
            this.RB_Dezimal = new System.Windows.Forms.RadioButton();
            this.RB_Oktal = new System.Windows.Forms.RadioButton();
            this.RB_Binaer = new System.Windows.Forms.RadioButton();
            this.Bt_umrechnen = new System.Windows.Forms.Button();
            this.Bt_beenden = new System.Windows.Forms.Button();
            this.GB_Zahlensysteme.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Binaer
            // 
            this.TB_Binaer.Location = new System.Drawing.Point(232, 31);
            this.TB_Binaer.Name = "TB_Binaer";
            this.TB_Binaer.Size = new System.Drawing.Size(100, 20);
            this.TB_Binaer.TabIndex = 0;
            // 
            // L_Binaer
            // 
            this.L_Binaer.AutoSize = true;
            this.L_Binaer.Location = new System.Drawing.Point(229, 15);
            this.L_Binaer.Name = "L_Binaer";
            this.L_Binaer.Size = new System.Drawing.Size(50, 13);
            this.L_Binaer.TabIndex = 1;
            this.L_Binaer.Text = "Binärzahl";
            // 
            // L_Oktal
            // 
            this.L_Oktal.AutoSize = true;
            this.L_Oktal.Location = new System.Drawing.Point(354, 15);
            this.L_Oktal.Name = "L_Oktal";
            this.L_Oktal.Size = new System.Drawing.Size(51, 13);
            this.L_Oktal.TabIndex = 3;
            this.L_Oktal.Text = "Oktalzahl";
            // 
            // TB_Oktal
            // 
            this.TB_Oktal.Location = new System.Drawing.Point(357, 31);
            this.TB_Oktal.Name = "TB_Oktal";
            this.TB_Oktal.Size = new System.Drawing.Size(100, 20);
            this.TB_Oktal.TabIndex = 2;
            // 
            // L_Dezimal
            // 
            this.L_Dezimal.AutoSize = true;
            this.L_Dezimal.Location = new System.Drawing.Point(486, 15);
            this.L_Dezimal.Name = "L_Dezimal";
            this.L_Dezimal.Size = new System.Drawing.Size(63, 13);
            this.L_Dezimal.TabIndex = 5;
            this.L_Dezimal.Text = "Dezimalzahl";
            // 
            // TB_Dezimal
            // 
            this.TB_Dezimal.Location = new System.Drawing.Point(489, 31);
            this.TB_Dezimal.Name = "TB_Dezimal";
            this.TB_Dezimal.Size = new System.Drawing.Size(100, 20);
            this.TB_Dezimal.TabIndex = 4;
            // 
            // L_Hexadezimal
            // 
            this.L_Hexadezimal.AutoSize = true;
            this.L_Hexadezimal.Location = new System.Drawing.Point(635, 15);
            this.L_Hexadezimal.Name = "L_Hexadezimal";
            this.L_Hexadezimal.Size = new System.Drawing.Size(86, 13);
            this.L_Hexadezimal.TabIndex = 7;
            this.L_Hexadezimal.Text = "Hexadezimalzahl";
            // 
            // TB_Hexadezimal
            // 
            this.TB_Hexadezimal.Location = new System.Drawing.Point(638, 32);
            this.TB_Hexadezimal.Name = "TB_Hexadezimal";
            this.TB_Hexadezimal.Size = new System.Drawing.Size(100, 20);
            this.TB_Hexadezimal.TabIndex = 6;
            // 
            // GB_Zahlensysteme
            // 
            this.GB_Zahlensysteme.Controls.Add(this.RB_Hexadezimal);
            this.GB_Zahlensysteme.Controls.Add(this.RB_Dezimal);
            this.GB_Zahlensysteme.Controls.Add(this.RB_Oktal);
            this.GB_Zahlensysteme.Controls.Add(this.RB_Binaer);
            this.GB_Zahlensysteme.Location = new System.Drawing.Point(12, 12);
            this.GB_Zahlensysteme.Name = "GB_Zahlensysteme";
            this.GB_Zahlensysteme.Size = new System.Drawing.Size(200, 115);
            this.GB_Zahlensysteme.TabIndex = 8;
            this.GB_Zahlensysteme.TabStop = false;
            this.GB_Zahlensysteme.Text = "Zahlensysteme";
            // 
            // RB_Hexadezimal
            // 
            this.RB_Hexadezimal.AutoSize = true;
            this.RB_Hexadezimal.Location = new System.Drawing.Point(10, 91);
            this.RB_Hexadezimal.Name = "RB_Hexadezimal";
            this.RB_Hexadezimal.Size = new System.Drawing.Size(117, 17);
            this.RB_Hexadezimal.TabIndex = 3;
            this.RB_Hexadezimal.TabStop = true;
            this.RB_Hexadezimal.Text = "Hexadezimalsystem";
            this.RB_Hexadezimal.UseVisualStyleBackColor = true;
            this.RB_Hexadezimal.CheckedChanged += new System.EventHandler(this.RB_Hexadezimal_CheckedChanged);
            // 
            // RB_Dezimal
            // 
            this.RB_Dezimal.AutoSize = true;
            this.RB_Dezimal.Location = new System.Drawing.Point(10, 68);
            this.RB_Dezimal.Name = "RB_Dezimal";
            this.RB_Dezimal.Size = new System.Drawing.Size(94, 17);
            this.RB_Dezimal.TabIndex = 2;
            this.RB_Dezimal.TabStop = true;
            this.RB_Dezimal.Text = "Dezimalsystem";
            this.RB_Dezimal.UseVisualStyleBackColor = true;
            this.RB_Dezimal.CheckedChanged += new System.EventHandler(this.RB_Dezimal_CheckedChanged);
            // 
            // RB_Oktal
            // 
            this.RB_Oktal.AutoSize = true;
            this.RB_Oktal.Location = new System.Drawing.Point(10, 45);
            this.RB_Oktal.Name = "RB_Oktal";
            this.RB_Oktal.Size = new System.Drawing.Size(82, 17);
            this.RB_Oktal.TabIndex = 1;
            this.RB_Oktal.TabStop = true;
            this.RB_Oktal.Text = "Oktalsystem";
            this.RB_Oktal.UseVisualStyleBackColor = true;
            this.RB_Oktal.CheckedChanged += new System.EventHandler(this.RB_Oktal_CheckedChanged);
            // 
            // RB_Binaer
            // 
            this.RB_Binaer.AutoSize = true;
            this.RB_Binaer.Location = new System.Drawing.Point(10, 20);
            this.RB_Binaer.Name = "RB_Binaer";
            this.RB_Binaer.Size = new System.Drawing.Size(81, 17);
            this.RB_Binaer.TabIndex = 0;
            this.RB_Binaer.TabStop = true;
            this.RB_Binaer.Text = "Binärsystem";
            this.RB_Binaer.UseVisualStyleBackColor = true;
            this.RB_Binaer.CheckedChanged += new System.EventHandler(this.RB_Binaer_CheckedChanged);
            // 
            // Bt_umrechnen
            // 
            this.Bt_umrechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_umrechnen.Location = new System.Drawing.Point(232, 71);
            this.Bt_umrechnen.Name = "Bt_umrechnen";
            this.Bt_umrechnen.Size = new System.Drawing.Size(506, 49);
            this.Bt_umrechnen.TabIndex = 9;
            this.Bt_umrechnen.Text = "Eingegebene Zahl umrechnen";
            this.Bt_umrechnen.UseVisualStyleBackColor = true;
            this.Bt_umrechnen.Click += new System.EventHandler(this.Bt_umrechnen_Click);
            // 
            // Bt_beenden
            // 
            this.Bt_beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_beenden.Location = new System.Drawing.Point(12, 348);
            this.Bt_beenden.Name = "Bt_beenden";
            this.Bt_beenden.Size = new System.Drawing.Size(776, 90);
            this.Bt_beenden.TabIndex = 10;
            this.Bt_beenden.Text = "Programm beenden";
            this.Bt_beenden.UseVisualStyleBackColor = true;
            this.Bt_beenden.Click += new System.EventHandler(this.Bt_beenden_Click);
            // 
            // Fm_Zahlensysteme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_beenden);
            this.Controls.Add(this.Bt_umrechnen);
            this.Controls.Add(this.GB_Zahlensysteme);
            this.Controls.Add(this.L_Hexadezimal);
            this.Controls.Add(this.TB_Hexadezimal);
            this.Controls.Add(this.L_Dezimal);
            this.Controls.Add(this.TB_Dezimal);
            this.Controls.Add(this.L_Oktal);
            this.Controls.Add(this.TB_Oktal);
            this.Controls.Add(this.L_Binaer);
            this.Controls.Add(this.TB_Binaer);
            this.Name = "Fm_Zahlensysteme";
            this.Text = "Umrechnen von Zahlensystemen";
            this.Load += new System.EventHandler(this.Fm_Zahlensysteme_Load);
            this.GB_Zahlensysteme.ResumeLayout(false);
            this.GB_Zahlensysteme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Binaer;
        private System.Windows.Forms.Label L_Binaer;
        private System.Windows.Forms.Label L_Oktal;
        private System.Windows.Forms.TextBox TB_Oktal;
        private System.Windows.Forms.Label L_Dezimal;
        private System.Windows.Forms.TextBox TB_Dezimal;
        private System.Windows.Forms.Label L_Hexadezimal;
        private System.Windows.Forms.TextBox TB_Hexadezimal;
        private System.Windows.Forms.GroupBox GB_Zahlensysteme;
        private System.Windows.Forms.RadioButton RB_Hexadezimal;
        private System.Windows.Forms.RadioButton RB_Dezimal;
        private System.Windows.Forms.RadioButton RB_Oktal;
        private System.Windows.Forms.RadioButton RB_Binaer;
        private System.Windows.Forms.Button Bt_umrechnen;
        private System.Windows.Forms.Button Bt_beenden;
    }
}


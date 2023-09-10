namespace Taschenrechner
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
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAnzeige.Location = new System.Drawing.Point(60, 116);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 6;
            this.labelAnzeige.Text = "0";
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBeschreibung.Location = new System.Drawing.Point(12, 116);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(51, 13);
            this.labelBeschreibung.TabIndex = 5;
            this.labelBeschreibung.Text = "Ergebnis:";
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBeenden.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBeenden.Location = new System.Drawing.Point(203, 132);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(100, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBerechnen.Location = new System.Drawing.Point(12, 132);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(100, 23);
            this.buttonBerechnen.TabIndex = 3;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.ButtonBerechnen_Click);
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(12, 15);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.Text = "0";
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(12, 41);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.Text = "0";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Multiplikation",
            "Division",
            "Addition",
            "Subtraktion"});
            this.comboBox.Location = new System.Drawing.Point(203, 17);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(100, 21);
            this.comboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonBerechnen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBeenden;
            this.ClientSize = new System.Drawing.Size(330, 161);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.ComboBox comboBox;
    }
}


namespace BMI
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
            this.berechnenbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groessebox = new System.Windows.Forms.TextBox();
            this.gewichtbox = new System.Windows.Forms.TextBox();
            this.antwortlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berechnenbutton
            // 
            this.berechnenbutton.Location = new System.Drawing.Point(94, 156);
            this.berechnenbutton.Name = "berechnenbutton";
            this.berechnenbutton.Size = new System.Drawing.Size(75, 23);
            this.berechnenbutton.TabIndex = 0;
            this.berechnenbutton.Text = "Berechnen";
            this.berechnenbutton.UseVisualStyleBackColor = true;
            this.berechnenbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Willkommen bei der Berechnung ihres BMIs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Größe in m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gewicht in kg:";
            // 
            // groessebox
            // 
            this.groessebox.Location = new System.Drawing.Point(132, 57);
            this.groessebox.Name = "groessebox";
            this.groessebox.Size = new System.Drawing.Size(100, 20);
            this.groessebox.TabIndex = 4;
            this.groessebox.Text = "1,84";
            this.groessebox.TextChanged += new System.EventHandler(this.groessebox_TextChanged);
            // 
            // gewichtbox
            // 
            this.gewichtbox.Location = new System.Drawing.Point(132, 97);
            this.gewichtbox.Name = "gewichtbox";
            this.gewichtbox.Size = new System.Drawing.Size(100, 20);
            this.gewichtbox.TabIndex = 5;
            this.gewichtbox.Text = "92";
            // 
            // antwortlabel
            // 
            this.antwortlabel.AutoSize = true;
            this.antwortlabel.Location = new System.Drawing.Point(36, 211);
            this.antwortlabel.Name = "antwortlabel";
            this.antwortlabel.Size = new System.Drawing.Size(0, 13);
            this.antwortlabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.antwortlabel);
            this.Controls.Add(this.gewichtbox);
            this.Controls.Add(this.groessebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.berechnenbutton);
            this.Name = "Form1";
            this.Text = "BMI Berechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berechnenbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groessebox;
        private System.Windows.Forms.TextBox gewichtbox;
        private System.Windows.Forms.Label antwortlabel;
    }
}


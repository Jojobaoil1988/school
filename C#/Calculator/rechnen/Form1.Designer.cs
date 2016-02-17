namespace rechnen
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
            this.add_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.multi_btn = new System.Windows.Forms.Button();
            this.zahl1_txt = new System.Windows.Forms.TextBox();
            this.zahl2_txt = new System.Windows.Forms.TextBox();
            this.ergebnis_txt = new System.Windows.Forms.TextBox();
            this.zahl1_lbl = new System.Windows.Forms.Label();
            this.zahl2_lbl = new System.Windows.Forms.Label();
            this.ergebnis_lbl = new System.Windows.Forms.Label();
            this.wurzel_btn = new System.Windows.Forms.Button();
            this.potenz_btn = new System.Windows.Forms.Button();
            this.rueck_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(18, 171);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(104, 25);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "addieren";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(147, 171);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(104, 25);
            this.sub_btn.TabIndex = 1;
            this.sub_btn.Text = "subtrahieren";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.Location = new System.Drawing.Point(18, 215);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(104, 25);
            this.div_btn.TabIndex = 2;
            this.div_btn.Text = "dividieren";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // multi_btn
            // 
            this.multi_btn.Location = new System.Drawing.Point(147, 215);
            this.multi_btn.Name = "multi_btn";
            this.multi_btn.Size = new System.Drawing.Size(104, 25);
            this.multi_btn.TabIndex = 3;
            this.multi_btn.Text = "multiplizieren";
            this.multi_btn.UseVisualStyleBackColor = true;
            this.multi_btn.Click += new System.EventHandler(this.multi_btn_Click);
            // 
            // zahl1_txt
            // 
            this.zahl1_txt.Location = new System.Drawing.Point(61, 36);
            this.zahl1_txt.Name = "zahl1_txt";
            this.zahl1_txt.Size = new System.Drawing.Size(100, 20);
            this.zahl1_txt.TabIndex = 4;
            // 
            // zahl2_txt
            // 
            this.zahl2_txt.Location = new System.Drawing.Point(61, 84);
            this.zahl2_txt.Name = "zahl2_txt";
            this.zahl2_txt.Size = new System.Drawing.Size(100, 20);
            this.zahl2_txt.TabIndex = 5;
            // 
            // ergebnis_txt
            // 
            this.ergebnis_txt.Location = new System.Drawing.Point(204, 60);
            this.ergebnis_txt.Name = "ergebnis_txt";
            this.ergebnis_txt.Size = new System.Drawing.Size(100, 20);
            this.ergebnis_txt.TabIndex = 6;
            // 
            // zahl1_lbl
            // 
            this.zahl1_lbl.AutoSize = true;
            this.zahl1_lbl.Location = new System.Drawing.Point(15, 39);
            this.zahl1_lbl.Name = "zahl1_lbl";
            this.zahl1_lbl.Size = new System.Drawing.Size(40, 13);
            this.zahl1_lbl.TabIndex = 7;
            this.zahl1_lbl.Text = "Zahl 1:";
            // 
            // zahl2_lbl
            // 
            this.zahl2_lbl.AutoSize = true;
            this.zahl2_lbl.Location = new System.Drawing.Point(15, 87);
            this.zahl2_lbl.Name = "zahl2_lbl";
            this.zahl2_lbl.Size = new System.Drawing.Size(40, 13);
            this.zahl2_lbl.TabIndex = 8;
            this.zahl2_lbl.Text = "Zahl 2:";
            // 
            // ergebnis_lbl
            // 
            this.ergebnis_lbl.AutoSize = true;
            this.ergebnis_lbl.Location = new System.Drawing.Point(161, 63);
            this.ergebnis_lbl.Name = "ergebnis_lbl";
            this.ergebnis_lbl.Size = new System.Drawing.Size(0, 13);
            this.ergebnis_lbl.TabIndex = 9;
            // 
            // wurzel_btn
            // 
            this.wurzel_btn.Location = new System.Drawing.Point(275, 171);
            this.wurzel_btn.Name = "wurzel_btn";
            this.wurzel_btn.Size = new System.Drawing.Size(104, 25);
            this.wurzel_btn.TabIndex = 10;
            this.wurzel_btn.Text = "Wurzel ziehen";
            this.wurzel_btn.UseVisualStyleBackColor = true;
            this.wurzel_btn.Click += new System.EventHandler(this.wurzel_btn_Click);
            // 
            // potenz_btn
            // 
            this.potenz_btn.Location = new System.Drawing.Point(275, 215);
            this.potenz_btn.Name = "potenz_btn";
            this.potenz_btn.Size = new System.Drawing.Size(104, 25);
            this.potenz_btn.TabIndex = 11;
            this.potenz_btn.Text = "potenzieren";
            this.potenz_btn.UseVisualStyleBackColor = true;
            this.potenz_btn.Click += new System.EventHandler(this.potenz_btn_Click);
            // 
            // rueck_btn
            // 
            this.rueck_btn.Location = new System.Drawing.Point(147, 266);
            this.rueck_btn.Name = "rueck_btn";
            this.rueck_btn.Size = new System.Drawing.Size(104, 25);
            this.rueck_btn.TabIndex = 12;
            this.rueck_btn.Text = "Zurücksetzen";
            this.rueck_btn.UseVisualStyleBackColor = true;
            this.rueck_btn.Click += new System.EventHandler(this.rueck_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 317);
            this.Controls.Add(this.rueck_btn);
            this.Controls.Add(this.potenz_btn);
            this.Controls.Add(this.wurzel_btn);
            this.Controls.Add(this.ergebnis_lbl);
            this.Controls.Add(this.zahl2_lbl);
            this.Controls.Add(this.zahl1_lbl);
            this.Controls.Add(this.ergebnis_txt);
            this.Controls.Add(this.zahl2_txt);
            this.Controls.Add(this.zahl1_txt);
            this.Controls.Add(this.multi_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button multi_btn;
        private System.Windows.Forms.TextBox zahl1_txt;
        private System.Windows.Forms.TextBox zahl2_txt;
        private System.Windows.Forms.TextBox ergebnis_txt;
        private System.Windows.Forms.Label zahl1_lbl;
        private System.Windows.Forms.Label zahl2_lbl;
        private System.Windows.Forms.Label ergebnis_lbl;
        private System.Windows.Forms.Button wurzel_btn;
        private System.Windows.Forms.Button potenz_btn;
        private System.Windows.Forms.Button rueck_btn;
    }
}


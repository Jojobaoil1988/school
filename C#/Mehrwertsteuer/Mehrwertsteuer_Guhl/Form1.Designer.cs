namespace Mehrwertsteuer_Guhl
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
            this.zeiten_group = new System.Windows.Forms.GroupBox();
            this.abreise_edit = new System.Windows.Forms.TextBox();
            this.ankunft_edit = new System.Windows.Forms.TextBox();
            this.abreise_label = new System.Windows.Forms.Label();
            this.ankunft_label = new System.Windows.Forms.Label();
            this.verhalten_group = new System.Windows.Forms.GroupBox();
            this.verlassen_radio = new System.Windows.Forms.RadioButton();
            this.einschlafen_radio = new System.Windows.Forms.RadioButton();
            this.preise_group = new System.Windows.Forms.GroupBox();
            this.zusatz_edit = new System.Windows.Forms.TextBox();
            this.uebernachtung_label = new System.Windows.Forms.Label();
            this.uebernachtung_edit = new System.Windows.Forms.TextBox();
            this.zusatz_label = new System.Windows.Forms.Label();
            this.berechnen_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ausgabe_label1 = new System.Windows.Forms.Label();
            this.ausgabe_label2 = new System.Windows.Forms.Label();
            this.ausgabe_label3 = new System.Windows.Forms.Label();
            this.zeiten_group.SuspendLayout();
            this.verhalten_group.SuspendLayout();
            this.preise_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeiten_group
            // 
            this.zeiten_group.Controls.Add(this.abreise_edit);
            this.zeiten_group.Controls.Add(this.ankunft_edit);
            this.zeiten_group.Controls.Add(this.abreise_label);
            this.zeiten_group.Controls.Add(this.ankunft_label);
            this.zeiten_group.Location = new System.Drawing.Point(32, 28);
            this.zeiten_group.Name = "zeiten_group";
            this.zeiten_group.Size = new System.Drawing.Size(177, 101);
            this.zeiten_group.TabIndex = 0;
            this.zeiten_group.TabStop = false;
            this.zeiten_group.Text = "Zeiten";
            // 
            // abreise_edit
            // 
            this.abreise_edit.Location = new System.Drawing.Point(94, 57);
            this.abreise_edit.Name = "abreise_edit";
            this.abreise_edit.Size = new System.Drawing.Size(47, 20);
            this.abreise_edit.TabIndex = 3;
            // 
            // ankunft_edit
            // 
            this.ankunft_edit.Location = new System.Drawing.Point(94, 25);
            this.ankunft_edit.Name = "ankunft_edit";
            this.ankunft_edit.Size = new System.Drawing.Size(47, 20);
            this.ankunft_edit.TabIndex = 2;
            // 
            // abreise_label
            // 
            this.abreise_label.AutoSize = true;
            this.abreise_label.Location = new System.Drawing.Point(41, 60);
            this.abreise_label.Name = "abreise_label";
            this.abreise_label.Size = new System.Drawing.Size(45, 13);
            this.abreise_label.TabIndex = 1;
            this.abreise_label.Text = "Abreise:";
            // 
            // ankunft_label
            // 
            this.ankunft_label.AutoSize = true;
            this.ankunft_label.Location = new System.Drawing.Point(41, 28);
            this.ankunft_label.Name = "ankunft_label";
            this.ankunft_label.Size = new System.Drawing.Size(47, 13);
            this.ankunft_label.TabIndex = 0;
            this.ankunft_label.Text = "Ankunft:";
            // 
            // verhalten_group
            // 
            this.verhalten_group.Controls.Add(this.verlassen_radio);
            this.verhalten_group.Controls.Add(this.einschlafen_radio);
            this.verhalten_group.Location = new System.Drawing.Point(32, 150);
            this.verhalten_group.Name = "verhalten_group";
            this.verhalten_group.Size = new System.Drawing.Size(305, 46);
            this.verhalten_group.TabIndex = 1;
            this.verhalten_group.TabStop = false;
            this.verhalten_group.Text = "Verhalten \"Danach\"";
            // 
            // verlassen_radio
            // 
            this.verlassen_radio.AutoSize = true;
            this.verlassen_radio.Location = new System.Drawing.Point(154, 19);
            this.verlassen_radio.Name = "verlassen_radio";
            this.verlassen_radio.Size = new System.Drawing.Size(121, 17);
            this.verlassen_radio.TabIndex = 1;
            this.verlassen_radio.TabStop = true;
            this.verlassen_radio.Text = "Bett sofort verlassen";
            this.verlassen_radio.UseVisualStyleBackColor = true;
            // 
            // einschlafen_radio
            // 
            this.einschlafen_radio.AutoSize = true;
            this.einschlafen_radio.Location = new System.Drawing.Point(24, 19);
            this.einschlafen_radio.Name = "einschlafen_radio";
            this.einschlafen_radio.Size = new System.Drawing.Size(92, 17);
            this.einschlafen_radio.TabIndex = 0;
            this.einschlafen_radio.TabStop = true;
            this.einschlafen_radio.Text = "Eingeschlafen";
            this.einschlafen_radio.UseVisualStyleBackColor = true;
            // 
            // preise_group
            // 
            this.preise_group.Controls.Add(this.zusatz_edit);
            this.preise_group.Controls.Add(this.uebernachtung_label);
            this.preise_group.Controls.Add(this.uebernachtung_edit);
            this.preise_group.Controls.Add(this.zusatz_label);
            this.preise_group.Location = new System.Drawing.Point(32, 220);
            this.preise_group.Name = "preise_group";
            this.preise_group.Size = new System.Drawing.Size(305, 88);
            this.preise_group.TabIndex = 2;
            this.preise_group.TabStop = false;
            this.preise_group.Text = "Preise";
            // 
            // zusatz_edit
            // 
            this.zusatz_edit.Location = new System.Drawing.Point(120, 56);
            this.zusatz_edit.Name = "zusatz_edit";
            this.zusatz_edit.Size = new System.Drawing.Size(75, 20);
            this.zusatz_edit.TabIndex = 7;
            // 
            // uebernachtung_label
            // 
            this.uebernachtung_label.AutoSize = true;
            this.uebernachtung_label.Location = new System.Drawing.Point(38, 27);
            this.uebernachtung_label.Name = "uebernachtung_label";
            this.uebernachtung_label.Size = new System.Drawing.Size(78, 13);
            this.uebernachtung_label.TabIndex = 4;
            this.uebernachtung_label.Text = "Übernachtung:";
            // 
            // uebernachtung_edit
            // 
            this.uebernachtung_edit.Location = new System.Drawing.Point(120, 24);
            this.uebernachtung_edit.Name = "uebernachtung_edit";
            this.uebernachtung_edit.Size = new System.Drawing.Size(75, 20);
            this.uebernachtung_edit.TabIndex = 6;
            // 
            // zusatz_label
            // 
            this.zusatz_label.AutoSize = true;
            this.zusatz_label.Location = new System.Drawing.Point(38, 59);
            this.zusatz_label.Name = "zusatz_label";
            this.zusatz_label.Size = new System.Drawing.Size(78, 13);
            this.zusatz_label.TabIndex = 5;
            this.zusatz_label.Text = "Zusatzleistung:";
            // 
            // berechnen_button
            // 
            this.berechnen_button.Location = new System.Drawing.Point(353, 285);
            this.berechnen_button.Name = "berechnen_button";
            this.berechnen_button.Size = new System.Drawing.Size(104, 23);
            this.berechnen_button.TabIndex = 3;
            this.berechnen_button.Text = "MwSt berechnen";
            this.berechnen_button.UseVisualStyleBackColor = true;
            this.berechnen_button.Click += new System.EventHandler(this.berechnen_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ausgabe:";
            // 
            // ausgabe_label1
            // 
            this.ausgabe_label1.AutoSize = true;
            this.ausgabe_label1.Location = new System.Drawing.Point(29, 352);
            this.ausgabe_label1.Name = "ausgabe_label1";
            this.ausgabe_label1.Size = new System.Drawing.Size(0, 13);
            this.ausgabe_label1.TabIndex = 5;
            // 
            // ausgabe_label2
            // 
            this.ausgabe_label2.AutoSize = true;
            this.ausgabe_label2.Location = new System.Drawing.Point(29, 365);
            this.ausgabe_label2.Name = "ausgabe_label2";
            this.ausgabe_label2.Size = new System.Drawing.Size(0, 13);
            this.ausgabe_label2.TabIndex = 6;
            // 
            // ausgabe_label3
            // 
            this.ausgabe_label3.AutoSize = true;
            this.ausgabe_label3.Location = new System.Drawing.Point(29, 378);
            this.ausgabe_label3.Name = "ausgabe_label3";
            this.ausgabe_label3.Size = new System.Drawing.Size(0, 13);
            this.ausgabe_label3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 405);
            this.Controls.Add(this.ausgabe_label3);
            this.Controls.Add(this.ausgabe_label2);
            this.Controls.Add(this.ausgabe_label1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.berechnen_button);
            this.Controls.Add(this.preise_group);
            this.Controls.Add(this.verhalten_group);
            this.Controls.Add(this.zeiten_group);
            this.Name = "Form1";
            this.Text = "Berechnung Mehrwertsteuer";
            this.zeiten_group.ResumeLayout(false);
            this.zeiten_group.PerformLayout();
            this.verhalten_group.ResumeLayout(false);
            this.verhalten_group.PerformLayout();
            this.preise_group.ResumeLayout(false);
            this.preise_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox zeiten_group;
        private System.Windows.Forms.TextBox abreise_edit;
        private System.Windows.Forms.TextBox ankunft_edit;
        private System.Windows.Forms.Label abreise_label;
        private System.Windows.Forms.Label ankunft_label;
        private System.Windows.Forms.GroupBox verhalten_group;
        private System.Windows.Forms.RadioButton verlassen_radio;
        private System.Windows.Forms.RadioButton einschlafen_radio;
        private System.Windows.Forms.GroupBox preise_group;
        private System.Windows.Forms.TextBox zusatz_edit;
        private System.Windows.Forms.Label uebernachtung_label;
        private System.Windows.Forms.TextBox uebernachtung_edit;
        private System.Windows.Forms.Label zusatz_label;
        private System.Windows.Forms.Button berechnen_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ausgabe_label1;
        private System.Windows.Forms.Label ausgabe_label2;
        private System.Windows.Forms.Label ausgabe_label3;
    }
}


namespace WindowsFormsApplication1
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
            this.access_group = new System.Windows.Forms.GroupBox();
            this.deny_radio = new System.Windows.Forms.RadioButton();
            this.permit_radio = new System.Windows.Forms.RadioButton();
            this.protocol_group = new System.Windows.Forms.GroupBox();
            this.ip_radio = new System.Windows.Forms.RadioButton();
            this.udp_radio = new System.Windows.Forms.RadioButton();
            this.tcp_radio = new System.Windows.Forms.RadioButton();
            this.quellip_edit = new System.Windows.Forms.TextBox();
            this.quellport_edit = new System.Windows.Forms.TextBox();
            this.interface_edit = new System.Windows.Forms.TextBox();
            this.zielip_edit = new System.Windows.Forms.TextBox();
            this.zielport_edit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direction_group = new System.Windows.Forms.GroupBox();
            this.inout_radio = new System.Windows.Forms.RadioButton();
            this.out_radio = new System.Windows.Forms.RadioButton();
            this.in_radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.acl_listbox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.access_group.SuspendLayout();
            this.protocol_group.SuspendLayout();
            this.direction_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // access_group
            // 
            this.access_group.Controls.Add(this.deny_radio);
            this.access_group.Controls.Add(this.permit_radio);
            this.access_group.Location = new System.Drawing.Point(80, 46);
            this.access_group.Name = "access_group";
            this.access_group.Size = new System.Drawing.Size(245, 62);
            this.access_group.TabIndex = 0;
            this.access_group.TabStop = false;
            this.access_group.Text = "Erlauben/Verbieten";
            // 
            // deny_radio
            // 
            this.deny_radio.AutoSize = true;
            this.deny_radio.Location = new System.Drawing.Point(151, 28);
            this.deny_radio.Name = "deny_radio";
            this.deny_radio.Size = new System.Drawing.Size(50, 17);
            this.deny_radio.TabIndex = 1;
            this.deny_radio.TabStop = true;
            this.deny_radio.Text = "Deny";
            this.deny_radio.UseVisualStyleBackColor = true;
            // 
            // permit_radio
            // 
            this.permit_radio.AutoSize = true;
            this.permit_radio.Location = new System.Drawing.Point(15, 28);
            this.permit_radio.Name = "permit_radio";
            this.permit_radio.Size = new System.Drawing.Size(54, 17);
            this.permit_radio.TabIndex = 0;
            this.permit_radio.TabStop = true;
            this.permit_radio.Text = "Permit";
            this.permit_radio.UseVisualStyleBackColor = true;
            // 
            // protocol_group
            // 
            this.protocol_group.Controls.Add(this.ip_radio);
            this.protocol_group.Controls.Add(this.udp_radio);
            this.protocol_group.Controls.Add(this.tcp_radio);
            this.protocol_group.Location = new System.Drawing.Point(80, 131);
            this.protocol_group.Name = "protocol_group";
            this.protocol_group.Size = new System.Drawing.Size(381, 60);
            this.protocol_group.TabIndex = 1;
            this.protocol_group.TabStop = false;
            this.protocol_group.Text = "Protokoll";
            // 
            // ip_radio
            // 
            this.ip_radio.AutoSize = true;
            this.ip_radio.Location = new System.Drawing.Point(299, 28);
            this.ip_radio.Name = "ip_radio";
            this.ip_radio.Size = new System.Drawing.Size(35, 17);
            this.ip_radio.TabIndex = 4;
            this.ip_radio.TabStop = true;
            this.ip_radio.Text = "IP";
            this.ip_radio.UseVisualStyleBackColor = true;
            // 
            // udp_radio
            // 
            this.udp_radio.AutoSize = true;
            this.udp_radio.Location = new System.Drawing.Point(151, 28);
            this.udp_radio.Name = "udp_radio";
            this.udp_radio.Size = new System.Drawing.Size(48, 17);
            this.udp_radio.TabIndex = 3;
            this.udp_radio.TabStop = true;
            this.udp_radio.Text = "UDP";
            this.udp_radio.UseVisualStyleBackColor = true;
            // 
            // tcp_radio
            // 
            this.tcp_radio.AutoSize = true;
            this.tcp_radio.Location = new System.Drawing.Point(15, 28);
            this.tcp_radio.Name = "tcp_radio";
            this.tcp_radio.Size = new System.Drawing.Size(46, 17);
            this.tcp_radio.TabIndex = 2;
            this.tcp_radio.TabStop = true;
            this.tcp_radio.Text = "TCP";
            this.tcp_radio.UseVisualStyleBackColor = true;
            // 
            // quellip_edit
            // 
            this.quellip_edit.Location = new System.Drawing.Point(126, 220);
            this.quellip_edit.Name = "quellip_edit";
            this.quellip_edit.Size = new System.Drawing.Size(100, 20);
            this.quellip_edit.TabIndex = 5;
            // 
            // quellport_edit
            // 
            this.quellport_edit.Location = new System.Drawing.Point(126, 246);
            this.quellport_edit.Name = "quellport_edit";
            this.quellport_edit.Size = new System.Drawing.Size(100, 20);
            this.quellport_edit.TabIndex = 7;
            // 
            // interface_edit
            // 
            this.interface_edit.Location = new System.Drawing.Point(126, 272);
            this.interface_edit.Name = "interface_edit";
            this.interface_edit.Size = new System.Drawing.Size(100, 20);
            this.interface_edit.TabIndex = 9;
            // 
            // zielip_edit
            // 
            this.zielip_edit.Location = new System.Drawing.Point(345, 220);
            this.zielip_edit.Name = "zielip_edit";
            this.zielip_edit.Size = new System.Drawing.Size(100, 20);
            this.zielip_edit.TabIndex = 6;
            // 
            // zielport_edit
            // 
            this.zielport_edit.Location = new System.Drawing.Point(345, 246);
            this.zielport_edit.Name = "zielport_edit";
            this.zielport_edit.Size = new System.Drawing.Size(100, 20);
            this.zielport_edit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quell-IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quell-Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Interface:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ziel-IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ziel-Port:";
            // 
            // direction_group
            // 
            this.direction_group.Controls.Add(this.inout_radio);
            this.direction_group.Controls.Add(this.out_radio);
            this.direction_group.Controls.Add(this.in_radio);
            this.direction_group.Location = new System.Drawing.Point(80, 309);
            this.direction_group.Name = "direction_group";
            this.direction_group.Size = new System.Drawing.Size(320, 60);
            this.direction_group.TabIndex = 5;
            this.direction_group.TabStop = false;
            this.direction_group.Text = "Richtung";
            // 
            // inout_radio
            // 
            this.inout_radio.AutoSize = true;
            this.inout_radio.Location = new System.Drawing.Point(228, 28);
            this.inout_radio.Name = "inout_radio";
            this.inout_radio.Size = new System.Drawing.Size(64, 17);
            this.inout_radio.TabIndex = 12;
            this.inout_radio.TabStop = true;
            this.inout_radio.Text = "IN/OUT";
            this.inout_radio.UseVisualStyleBackColor = true;
            // 
            // out_radio
            // 
            this.out_radio.AutoSize = true;
            this.out_radio.Location = new System.Drawing.Point(124, 28);
            this.out_radio.Name = "out_radio";
            this.out_radio.Size = new System.Drawing.Size(48, 17);
            this.out_radio.TabIndex = 11;
            this.out_radio.TabStop = true;
            this.out_radio.Text = "OUT";
            this.out_radio.UseVisualStyleBackColor = true;
            // 
            // in_radio
            // 
            this.in_radio.AutoSize = true;
            this.in_radio.Location = new System.Drawing.Point(15, 28);
            this.in_radio.Name = "in_radio";
            this.in_radio.Size = new System.Drawing.Size(36, 17);
            this.in_radio.TabIndex = 10;
            this.in_radio.TabStop = true;
            this.in_radio.Text = "IN";
            this.in_radio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Möglichkeiten: S0/0, Fa0/1 oder Fa0/2)";
            // 
            // acl_listbox
            // 
            this.acl_listbox.FormattingEnabled = true;
            this.acl_listbox.Location = new System.Drawing.Point(50, 380);
            this.acl_listbox.Name = "acl_listbox";
            this.acl_listbox.Size = new System.Drawing.Size(473, 147);
            this.acl_listbox.TabIndex = 17;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(558, 321);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(127, 33);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Hinzufügen";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 534);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.acl_listbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direction_group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zielport_edit);
            this.Controls.Add(this.zielip_edit);
            this.Controls.Add(this.interface_edit);
            this.Controls.Add(this.quellport_edit);
            this.Controls.Add(this.quellip_edit);
            this.Controls.Add(this.protocol_group);
            this.Controls.Add(this.access_group);
            this.Name = "Form1";
            this.Text = "ACL konfigurieren";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.access_group.ResumeLayout(false);
            this.access_group.PerformLayout();
            this.protocol_group.ResumeLayout(false);
            this.protocol_group.PerformLayout();
            this.direction_group.ResumeLayout(false);
            this.direction_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox access_group;
        private System.Windows.Forms.RadioButton deny_radio;
        private System.Windows.Forms.RadioButton permit_radio;
        private System.Windows.Forms.GroupBox protocol_group;
        private System.Windows.Forms.RadioButton ip_radio;
        private System.Windows.Forms.RadioButton udp_radio;
        private System.Windows.Forms.RadioButton tcp_radio;
        private System.Windows.Forms.TextBox quellip_edit;
        private System.Windows.Forms.TextBox quellport_edit;
        private System.Windows.Forms.TextBox interface_edit;
        private System.Windows.Forms.TextBox zielip_edit;
        private System.Windows.Forms.TextBox zielport_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox direction_group;
        private System.Windows.Forms.RadioButton inout_radio;
        private System.Windows.Forms.RadioButton out_radio;
        private System.Windows.Forms.RadioButton in_radio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox acl_listbox;
        private System.Windows.Forms.Button add_button;
    }
}


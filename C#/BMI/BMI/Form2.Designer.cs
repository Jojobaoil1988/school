﻿namespace BMI
{
    partial class Form2
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
            this.bmilabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmilabel
            // 
            this.bmilabel.AutoSize = true;
            this.bmilabel.Location = new System.Drawing.Point(48, 64);
            this.bmilabel.Name = "bmilabel";
            this.bmilabel.Size = new System.Drawing.Size(35, 13);
            this.bmilabel.TabIndex = 0;
            this.bmilabel.Text = "label1";
            this.bmilabel.Click += new System.EventHandler(this.bmilabel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bmilabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmilabel;
    }
}
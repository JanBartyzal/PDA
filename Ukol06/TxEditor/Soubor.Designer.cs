﻿namespace TxEditor
{
    partial class Soubor
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
            this.souboryIO1 = new TxEditor.SouboryIO();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // souboryIO1
            // 
            this.souboryIO1.Location = new System.Drawing.Point(2, 0);
            this.souboryIO1.Name = "souboryIO1";
            this.souboryIO1.Size = new System.Drawing.Size(545, 91);
            this.souboryIO1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nastav";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Soubor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.souboryIO1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Soubor";
            this.Text = "Soubor";
            this.ResumeLayout(false);

        }

        #endregion

        private SouboryIO souboryIO1;
        private System.Windows.Forms.Button button1;
    }
}
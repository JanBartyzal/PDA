namespace Kopiruj
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
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbVelke = new System.Windows.Forms.CheckBox();
            this.cbInvariant = new System.Windows.Forms.CheckBox();
            this.cbTrim = new System.Windows.Forms.CheckBox();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonNahled = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(1, 122);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(115, 17);
            this.cbMale.TabIndex = 0;
            this.cbMale.Text = "Vše na malé znaky";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // cbVelke
            // 
            this.cbVelke.AutoSize = true;
            this.cbVelke.Location = new System.Drawing.Point(122, 122);
            this.cbVelke.Name = "cbVelke";
            this.cbVelke.Size = new System.Drawing.Size(119, 17);
            this.cbVelke.TabIndex = 1;
            this.cbVelke.Text = "Vše na velké znaky";
            this.cbVelke.UseVisualStyleBackColor = true;
            this.cbVelke.CheckedChanged += new System.EventHandler(this.cbVelke_CheckedChanged);
            // 
            // cbInvariant
            // 
            this.cbInvariant.AutoSize = true;
            this.cbInvariant.Location = new System.Drawing.Point(247, 122);
            this.cbInvariant.Name = "cbInvariant";
            this.cbInvariant.Size = new System.Drawing.Size(98, 17);
            this.cbInvariant.TabIndex = 2;
            this.cbInvariant.Text = "Invariant znaky";
            this.cbInvariant.UseVisualStyleBackColor = true;
            this.cbInvariant.CheckedChanged += new System.EventHandler(this.cbInvariant_CheckedChanged);
            // 
            // cbTrim
            // 
            this.cbTrim.AutoSize = true;
            this.cbTrim.Location = new System.Drawing.Point(342, 122);
            this.cbTrim.Name = "cbTrim";
            this.cbTrim.Size = new System.Drawing.Size(77, 17);
            this.cbTrim.TabIndex = 3;
            this.cbTrim.Text = "Trim mezer";
            this.cbTrim.UseVisualStyleBackColor = true;
            this.cbTrim.CheckedChanged += new System.EventHandler(this.cbTrim_CheckedChanged);
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(469, 78);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 60);
            this.buttonUloz.TabIndex = 4;
            this.buttonUloz.Text = "Proveď";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(1, 155);
            this.textBoxSrc.Multiline = true;
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.ReadOnly = true;
            this.textBoxSrc.Size = new System.Drawing.Size(392, 242);
            this.textBoxSrc.TabIndex = 5;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(409, 155);
            this.textBoxDest.Multiline = true;
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.ReadOnly = true;
            this.textBoxDest.Size = new System.Drawing.Size(367, 242);
            this.textBoxDest.TabIndex = 6;
            // 
            // buttonNahled
            // 
            this.buttonNahled.Location = new System.Drawing.Point(469, 12);
            this.buttonNahled.Name = "buttonNahled";
            this.buttonNahled.Size = new System.Drawing.Size(75, 60);
            this.buttonNahled.TabIndex = 7;
            this.buttonNahled.Text = "Náhled";
            this.buttonNahled.UseVisualStyleBackColor = true;
            this.buttonNahled.Click += new System.EventHandler(this.buttonNahled_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(551, 106);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelProgress.Location = new System.Drawing.Point(551, 87);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(101, 13);
            this.labelProgress.TabIndex = 9;
            this.labelProgress.Text = "Zkopírováno znaků";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonNahled);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.cbTrim);
            this.Controls.Add(this.cbInvariant);
            this.Controls.Add(this.cbVelke);
            this.Controls.Add(this.cbMale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbVelke;
        private System.Windows.Forms.CheckBox cbInvariant;
        private System.Windows.Forms.CheckBox cbTrim;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Button buttonNahled;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
    }
}


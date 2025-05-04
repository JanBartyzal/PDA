namespace Ukol2
{
    partial class UserControl_Password2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Password2 = new System.Windows.Forms.TextBox();
            this.button_CheckPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Location = new System.Drawing.Point(137, 7);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.PasswordChar = '*';
            this.textBox_Password1.Size = new System.Drawing.Size(149, 22);
            this.textBox_Password1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Retype Password";
            // 
            // textBox_Password2
            // 
            this.textBox_Password2.Location = new System.Drawing.Point(137, 39);
            this.textBox_Password2.Name = "textBox_Password2";
            this.textBox_Password2.PasswordChar = '*';
            this.textBox_Password2.Size = new System.Drawing.Size(149, 22);
            this.textBox_Password2.TabIndex = 4;
            // 
            // button_CheckPass
            // 
            this.button_CheckPass.Location = new System.Drawing.Point(137, 68);
            this.button_CheckPass.Name = "button_CheckPass";
            this.button_CheckPass.Size = new System.Drawing.Size(149, 23);
            this.button_CheckPass.TabIndex = 6;
            this.button_CheckPass.Text = "Check Passwd";
            this.button_CheckPass.UseVisualStyleBackColor = true;
            this.button_CheckPass.Click += new System.EventHandler(this.button_CheckPass_Click);
            // 
            // UserControl_Password2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_CheckPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Password2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password1);
            this.Name = "UserControl_Password2";
            this.Size = new System.Drawing.Size(453, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Password2;
        private System.Windows.Forms.Button button_CheckPass;
    }
}

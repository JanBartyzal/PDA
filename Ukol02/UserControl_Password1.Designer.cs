namespace Ukol2
{
    partial class UserControl_Password1
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
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1_Password1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Location = new System.Drawing.Point(85, 3);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.PasswordChar = '*';
            this.textBox_Password1.Size = new System.Drawing.Size(149, 22);
            this.textBox_Password1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // checkBox1_Password1
            // 
            this.checkBox1_Password1.AutoSize = true;
            this.checkBox1_Password1.Location = new System.Drawing.Point(241, 4);
            this.checkBox1_Password1.Name = "checkBox1_Password1";
            this.checkBox1_Password1.Size = new System.Drawing.Size(124, 20);
            this.checkBox1_Password1.TabIndex = 2;
            this.checkBox1_Password1.Text = "Show password";
            this.checkBox1_Password1.UseVisualStyleBackColor = true;
            this.checkBox1_Password1.CheckedChanged += new System.EventHandler(this.checkBox1_Password1_CheckedChanged);
            // 
            // UserControl_Password1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1_Password1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password1);
            this.Name = "UserControl_Password1";
            this.Size = new System.Drawing.Size(436, 93);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1_Password1;
    }
}

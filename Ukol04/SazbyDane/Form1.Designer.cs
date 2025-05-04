namespace SazbyDane
{
    partial class SazbyDane
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbVstup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSazba = new System.Windows.Forms.ComboBox();
            this.tbDan = new System.Windows.Forms.TextBox();
            this.tbCelkem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Částka";
            // 
            // tbVstup
            // 
            this.tbVstup.Location = new System.Drawing.Point(69, 39);
            this.tbVstup.Name = "tbVstup";
            this.tbVstup.Size = new System.Drawing.Size(100, 20);
            this.tbVstup.TabIndex = 1;
            this.tbVstup.TextChanged += new System.EventHandler(this.tbVstup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sazba";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbSazba
            // 
            this.cbSazba.FormattingEnabled = true;
            this.cbSazba.Items.AddRange(new object[] {
            "0%",
            "5%",
            "15%",
            "19%",
            "21%"});
            this.cbSazba.Location = new System.Drawing.Point(69, 65);
            this.cbSazba.Name = "cbSazba";
            this.cbSazba.Size = new System.Drawing.Size(66, 21);
            this.cbSazba.TabIndex = 3;
            this.cbSazba.SelectedIndexChanged += new System.EventHandler(this.cbSazba_SelectedIndexChanged);
            // 
            // tbDan
            // 
            this.tbDan.Enabled = false;
            this.tbDan.Location = new System.Drawing.Point(69, 92);
            this.tbDan.Name = "tbDan";
            this.tbDan.Size = new System.Drawing.Size(100, 20);
            this.tbDan.TabIndex = 4;
            // 
            // tbCelkem
            // 
            this.tbCelkem.Enabled = false;
            this.tbCelkem.Location = new System.Drawing.Point(69, 118);
            this.tbCelkem.Name = "tbCelkem";
            this.tbCelkem.Size = new System.Drawing.Size(100, 20);
            this.tbCelkem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Daň";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celkem";
            // 
            // SazbyDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCelkem);
            this.Controls.Add(this.tbDan);
            this.Controls.Add(this.cbSazba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVstup);
            this.Controls.Add(this.label1);
            this.Name = "SazbyDane";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVstup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSazba;
        private System.Windows.Forms.TextBox tbDan;
        private System.Windows.Forms.TextBox tbCelkem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


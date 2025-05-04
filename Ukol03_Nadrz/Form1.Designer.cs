namespace Ukol03_Nadrz
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
            this.button_nova = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_pridat = new System.Windows.Forms.Button();
            this.button_odebrat = new System.Windows.Forms.Button();
            this.label_celkem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_nova
            // 
            this.button_nova.Location = new System.Drawing.Point(254, 45);
            this.button_nova.Name = "button_nova";
            this.button_nova.Size = new System.Drawing.Size(109, 23);
            this.button_nova.TabIndex = 0;
            this.button_nova.Text = "Nová nádrž";
            this.button_nova.UseVisualStyleBackColor = true;
            this.button_nova.Click += new System.EventHandler(this.button_nova_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kapacita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Množství";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "50";
            this.textBox2.Visible = false;
            // 
            // button_pridat
            // 
            this.button_pridat.Location = new System.Drawing.Point(254, 77);
            this.button_pridat.Name = "button_pridat";
            this.button_pridat.Size = new System.Drawing.Size(75, 23);
            this.button_pridat.TabIndex = 5;
            this.button_pridat.Text = "Přidat";
            this.button_pridat.UseVisualStyleBackColor = true;
            this.button_pridat.Visible = false;
            this.button_pridat.Click += new System.EventHandler(this.button_pridat_Click);
            // 
            // button_odebrat
            // 
            this.button_odebrat.Location = new System.Drawing.Point(254, 106);
            this.button_odebrat.Name = "button_odebrat";
            this.button_odebrat.Size = new System.Drawing.Size(75, 23);
            this.button_odebrat.TabIndex = 6;
            this.button_odebrat.Text = "Odebrat";
            this.button_odebrat.UseVisualStyleBackColor = true;
            this.button_odebrat.Visible = false;
            this.button_odebrat.Click += new System.EventHandler(this.button_odebrat_Click);
            // 
            // label_celkem
            // 
            this.label_celkem.AutoSize = true;
            this.label_celkem.Location = new System.Drawing.Point(121, 154);
            this.label_celkem.Name = "label_celkem";
            this.label_celkem.Size = new System.Drawing.Size(44, 16);
            this.label_celkem.TabIndex = 7;
            this.label_celkem.Text = "label3";
            this.label_celkem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 225);
            this.Controls.Add(this.label_celkem);
            this.Controls.Add(this.button_odebrat);
            this.Controls.Add(this.button_pridat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_nova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nova;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_pridat;
        private System.Windows.Forms.Button button_odebrat;
        private System.Windows.Forms.Label label_celkem;

        private Nadrz _nadrz = null;
        

    }
}


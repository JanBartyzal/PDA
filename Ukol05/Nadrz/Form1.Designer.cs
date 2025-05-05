namespace Nadrz
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
            this.cbNadrze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNadrzObjem1 = new System.Windows.Forms.TextBox();
            this.tbNadrzNazev1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNovaNadrz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNadrzObjem2 = new System.Windows.Forms.TextBox();
            this.tbNadrzNazev2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLitry = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStavNadrze = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNadrze
            // 
            this.cbNadrze.FormattingEnabled = true;
            this.cbNadrze.Location = new System.Drawing.Point(94, 43);
            this.cbNadrze.Name = "cbNadrze";
            this.cbNadrze.Size = new System.Drawing.Size(121, 21);
            this.cbNadrze.TabIndex = 0;
            this.cbNadrze.SelectedIndexChanged += new System.EventHandler(this.cbNadrze_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nádrž";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNadrzObjem1);
            this.groupBox1.Controls.Add(this.tbNadrzNazev1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonNovaNadrz);
            this.groupBox1.Location = new System.Drawing.Point(481, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nová nádrž";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Objem";
            // 
            // tbNadrzObjem1
            // 
            this.tbNadrzObjem1.Location = new System.Drawing.Point(72, 60);
            this.tbNadrzObjem1.Name = "tbNadrzObjem1";
            this.tbNadrzObjem1.Size = new System.Drawing.Size(100, 20);
            this.tbNadrzObjem1.TabIndex = 10;
            // 
            // tbNadrzNazev1
            // 
            this.tbNadrzNazev1.Location = new System.Drawing.Point(72, 34);
            this.tbNadrzNazev1.Name = "tbNadrzNazev1";
            this.tbNadrzNazev1.Size = new System.Drawing.Size(100, 20);
            this.tbNadrzNazev1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Název";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonNovaNadrz
            // 
            this.buttonNovaNadrz.Location = new System.Drawing.Point(72, 86);
            this.buttonNovaNadrz.Name = "buttonNovaNadrz";
            this.buttonNovaNadrz.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaNadrz.TabIndex = 7;
            this.buttonNovaNadrz.Text = "Vložit";
            this.buttonNovaNadrz.UseVisualStyleBackColor = true;
            this.buttonNovaNadrz.Click += new System.EventHandler(this.buttonNovaNadrz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbStavNadrze);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbLitry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNadrzObjem2);
            this.groupBox2.Controls.Add(this.tbNadrzNazev2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(481, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 194);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pridat/odebrat z nádrže";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Objem";
            // 
            // tbNadrzObjem2
            // 
            this.tbNadrzObjem2.Location = new System.Drawing.Point(72, 60);
            this.tbNadrzObjem2.Name = "tbNadrzObjem2";
            this.tbNadrzObjem2.ReadOnly = true;
            this.tbNadrzObjem2.Size = new System.Drawing.Size(100, 20);
            this.tbNadrzObjem2.TabIndex = 10;
            // 
            // tbNadrzNazev2
            // 
            this.tbNadrzNazev2.Location = new System.Drawing.Point(72, 34);
            this.tbNadrzNazev2.Name = "tbNadrzNazev2";
            this.tbNadrzNazev2.ReadOnly = true;
            this.tbNadrzNazev2.Size = new System.Drawing.Size(100, 20);
            this.tbNadrzNazev2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Název";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Litry";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbLitry
            // 
            this.tbLitry.Location = new System.Drawing.Point(72, 117);
            this.tbLitry.Name = "tbLitry";
            this.tbLitry.Size = new System.Drawing.Size(100, 20);
            this.tbLitry.TabIndex = 12;
            this.tbLitry.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Odebrat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Smazat";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Nová";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stav";
            // 
            // tbStavNadrze
            // 
            this.tbStavNadrze.Location = new System.Drawing.Point(72, 87);
            this.tbStavNadrze.Name = "tbStavNadrze";
            this.tbStavNadrze.ReadOnly = true;
            this.tbStavNadrze.Size = new System.Drawing.Size(100, 20);
            this.tbStavNadrze.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNadrze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNadrze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNadrzObjem1;
        private System.Windows.Forms.TextBox tbNadrzNazev1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNovaNadrz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNadrzObjem2;
        private System.Windows.Forms.TextBox tbNadrzNazev2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLitry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStavNadrze;
    }
}


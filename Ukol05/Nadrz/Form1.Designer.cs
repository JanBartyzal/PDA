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
            this.label7 = new System.Windows.Forms.Label();
            this.tbStavNadrze = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLitry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNadrzObjem2 = new System.Windows.Forms.TextBox();
            this.tbNadrzNazev2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbNadrz = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tbFindByID = new System.Windows.Forms.TextBox();
            this.tbFindByName = new System.Windows.Forms.TextBox();
            this.tbVysledekHledani = new System.Windows.Forms.TextBox();
            this.buttonHledejID = new System.Windows.Forms.Button();
            this.buttonHledenNazev = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nahrajAUlozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nahrajSeznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložSeznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nahrajDebugSeznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // lbNadrz
            // 
            this.lbNadrz.FormattingEnabled = true;
            this.lbNadrz.Location = new System.Drawing.Point(94, 133);
            this.lbNadrz.Name = "lbNadrz";
            this.lbNadrz.Size = new System.Drawing.Size(120, 147);
            this.lbNadrz.TabIndex = 15;
            this.lbNadrz.SelectedIndexChanged += new System.EventHandler(this.lbNadrz_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(237, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 168);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Řazení nardží";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vzestupně";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sestupně";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Podle ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Podle názvu";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Podle stavu";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tbFindByID
            // 
            this.tbFindByID.Location = new System.Drawing.Point(146, 363);
            this.tbFindByID.Name = "tbFindByID";
            this.tbFindByID.Size = new System.Drawing.Size(48, 20);
            this.tbFindByID.TabIndex = 17;
            // 
            // tbFindByName
            // 
            this.tbFindByName.Location = new System.Drawing.Point(94, 389);
            this.tbFindByName.Name = "tbFindByName";
            this.tbFindByName.Size = new System.Drawing.Size(100, 20);
            this.tbFindByName.TabIndex = 18;
            // 
            // tbVysledekHledani
            // 
            this.tbVysledekHledani.Location = new System.Drawing.Point(94, 416);
            this.tbVysledekHledani.Name = "tbVysledekHledani";
            this.tbVysledekHledani.ReadOnly = true;
            this.tbVysledekHledani.Size = new System.Drawing.Size(304, 20);
            this.tbVysledekHledani.TabIndex = 19;
            // 
            // buttonHledejID
            // 
            this.buttonHledejID.Location = new System.Drawing.Point(201, 360);
            this.buttonHledejID.Name = "buttonHledejID";
            this.buttonHledejID.Size = new System.Drawing.Size(75, 23);
            this.buttonHledejID.TabIndex = 20;
            this.buttonHledejID.Text = "Hledej";
            this.buttonHledejID.UseVisualStyleBackColor = true;
            this.buttonHledejID.Click += new System.EventHandler(this.buttonHledejID_Click);
            // 
            // buttonHledenNazev
            // 
            this.buttonHledenNazev.Location = new System.Drawing.Point(201, 389);
            this.buttonHledenNazev.Name = "buttonHledenNazev";
            this.buttonHledenNazev.Size = new System.Drawing.Size(75, 23);
            this.buttonHledenNazev.TabIndex = 21;
            this.buttonHledenNazev.Text = "Hledej";
            this.buttonHledenNazev.UseVisualStyleBackColor = true;
            this.buttonHledenNazev.Click += new System.EventHandler(this.buttonHledenNazev_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hldej dle ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dle nazvu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konecToolStripMenuItem,
            this.nahrajAUlozToolStripMenuItem,
            this.oAplikaciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // nahrajAUlozToolStripMenuItem
            // 
            this.nahrajAUlozToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nahrajSeznamToolStripMenuItem,
            this.uložSeznamToolStripMenuItem,
            this.nahrajDebugSeznamToolStripMenuItem});
            this.nahrajAUlozToolStripMenuItem.Name = "nahrajAUlozToolStripMenuItem";
            this.nahrajAUlozToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.nahrajAUlozToolStripMenuItem.Text = "Nahraj a uloz";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.oAplikaciToolStripMenuItem.Text = "O Aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // nahrajSeznamToolStripMenuItem
            // 
            this.nahrajSeznamToolStripMenuItem.Name = "nahrajSeznamToolStripMenuItem";
            this.nahrajSeznamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nahrajSeznamToolStripMenuItem.Text = "Nahraj seznam";
            this.nahrajSeznamToolStripMenuItem.Click += new System.EventHandler(this.nahrajSeznamToolStripMenuItem_Click);
            // 
            // uložSeznamToolStripMenuItem
            // 
            this.uložSeznamToolStripMenuItem.Name = "uložSeznamToolStripMenuItem";
            this.uložSeznamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložSeznamToolStripMenuItem.Text = "Ulož seznam";
            this.uložSeznamToolStripMenuItem.Click += new System.EventHandler(this.uložSeznamToolStripMenuItem_Click);
            // 
            // nahrajDebugSeznamToolStripMenuItem
            // 
            this.nahrajDebugSeznamToolStripMenuItem.Name = "nahrajDebugSeznamToolStripMenuItem";
            this.nahrajDebugSeznamToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nahrajDebugSeznamToolStripMenuItem.Text = "Nahraj debug seznam";
            this.nahrajDebugSeznamToolStripMenuItem.Click += new System.EventHandler(this.nahrajDebugSeznamToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonHledenNazev);
            this.Controls.Add(this.buttonHledejID);
            this.Controls.Add(this.tbVysledekHledani);
            this.Controls.Add(this.tbFindByName);
            this.Controls.Add(this.tbFindByID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbNadrz);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNadrze);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ListBox lbNadrz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbFindByID;
        private System.Windows.Forms.TextBox tbFindByName;
        private System.Windows.Forms.TextBox tbVysledekHledani;
        private System.Windows.Forms.Button buttonHledejID;
        private System.Windows.Forms.Button buttonHledenNazev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nahrajAUlozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nahrajSeznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložSeznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nahrajDebugSeznamToolStripMenuItem;
    }
}


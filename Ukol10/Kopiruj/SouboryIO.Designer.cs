namespace TxEditor
{
    partial class SouboryIO
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
            this.tbFileOpen = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tbFileSave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFileOpen
            // 
            this.tbFileOpen.Location = new System.Drawing.Point(4, 19);
            this.tbFileOpen.Name = "tbFileOpen";
            this.tbFileOpen.ReadOnly = true;
            this.tbFileOpen.Size = new System.Drawing.Size(260, 20);
            this.tbFileOpen.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(289, 16);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(161, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Vybrat soubor pro otevření";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(289, 45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(161, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Vybrat soubor pro uložení";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tbFileSave
            // 
            this.tbFileSave.Location = new System.Drawing.Point(4, 48);
            this.tbFileSave.Name = "tbFileSave";
            this.tbFileSave.ReadOnly = true;
            this.tbFileSave.Size = new System.Drawing.Size(260, 20);
            this.tbFileSave.TabIndex = 2;
            // 
            // SouboryIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbFileSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.tbFileOpen);
            this.Name = "SouboryIO";
            this.Size = new System.Drawing.Size(545, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFileOpen;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox tbFileSave;
    }
}

namespace Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSpeaker1 = new System.Windows.Forms.Button();
            this.comboBoxWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSpeaker2 = new System.Windows.Forms.Button();
            this.buttonSpeaker3 = new System.Windows.Forms.Button();
            this.textBoxExplaination = new System.Windows.Forms.TextBox();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonSpeaker1);
            this.panel1.Controls.Add(this.comboBoxWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 472);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(249, 381);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 66);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSpeaker1
            // 
            this.buttonSpeaker1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeaker1.BackgroundImage")));
            this.buttonSpeaker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeaker1.Location = new System.Drawing.Point(249, 3);
            this.buttonSpeaker1.Name = "buttonSpeaker1";
            this.buttonSpeaker1.Size = new System.Drawing.Size(75, 66);
            this.buttonSpeaker1.TabIndex = 1;
            this.buttonSpeaker1.UseVisualStyleBackColor = true;
            this.buttonSpeaker1.Click += new System.EventHandler(this.buttonSpeaker1_Click);
            // 
            // comboBoxWord
            // 
            this.comboBoxWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxWord.FormattingEnabled = true;
            this.comboBoxWord.Location = new System.Drawing.Point(3, 3);
            this.comboBoxWord.Name = "comboBoxWord";
            this.comboBoxWord.Size = new System.Drawing.Size(240, 462);
            this.comboBoxWord.TabIndex = 0;
            this.comboBoxWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSpeaker2);
            this.panel2.Controls.Add(this.buttonSpeaker3);
            this.panel2.Controls.Add(this.textBoxExplaination);
            this.panel2.Controls.Add(this.textBoxMeaning);
            this.panel2.Location = new System.Drawing.Point(351, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 472);
            this.panel2.TabIndex = 1;
            // 
            // buttonSpeaker2
            // 
            this.buttonSpeaker2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeaker2.BackgroundImage")));
            this.buttonSpeaker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeaker2.Location = new System.Drawing.Point(503, 3);
            this.buttonSpeaker2.Name = "buttonSpeaker2";
            this.buttonSpeaker2.Size = new System.Drawing.Size(75, 40);
            this.buttonSpeaker2.TabIndex = 2;
            this.buttonSpeaker2.UseVisualStyleBackColor = true;
            this.buttonSpeaker2.Click += new System.EventHandler(this.buttonSpeaker2_Click);
            // 
            // buttonSpeaker3
            // 
            this.buttonSpeaker3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeaker3.BackgroundImage")));
            this.buttonSpeaker3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeaker3.Location = new System.Drawing.Point(503, 381);
            this.buttonSpeaker3.Name = "buttonSpeaker3";
            this.buttonSpeaker3.Size = new System.Drawing.Size(75, 66);
            this.buttonSpeaker3.TabIndex = 3;
            this.buttonSpeaker3.UseVisualStyleBackColor = true;
            this.buttonSpeaker3.Click += new System.EventHandler(this.buttonSpeaker3_Click);
            // 
            // textBoxExplaination
            // 
            this.textBoxExplaination.Location = new System.Drawing.Point(3, 49);
            this.textBoxExplaination.Multiline = true;
            this.textBoxExplaination.Name = "textBoxExplaination";
            this.textBoxExplaination.Size = new System.Drawing.Size(494, 420);
            this.textBoxExplaination.TabIndex = 1;
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.Location = new System.Drawing.Point(3, 3);
            this.textBoxMeaning.Multiline = true;
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(494, 40);
            this.textBoxMeaning.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dictionary | English - VietNamese - by LucasNAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSpeaker1;
        private System.Windows.Forms.ComboBox comboBoxWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSpeaker2;
        private System.Windows.Forms.Button buttonSpeaker3;
        private System.Windows.Forms.TextBox textBoxExplaination;
        private System.Windows.Forms.TextBox textBoxMeaning;
    }
}


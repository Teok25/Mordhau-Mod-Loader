namespace MordhauModManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InactiveMods = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ActiveMods = new System.Windows.Forms.ListBox();
            this.Install = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModSizeLabel = new System.Windows.Forms.Label();
            this.ModReleaseDateLabel = new System.Windows.Forms.Label();
            this.ModVersionLabel = new System.Windows.Forms.Label();
            this.ModAuthorsLabel = new System.Windows.Forms.Label();
            this.ModNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMordhauDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(5, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Mod";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(5, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Selected Mod";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InactiveMods
            // 
            this.InactiveMods.FormattingEnabled = true;
            this.InactiveMods.Location = new System.Drawing.Point(5, 21);
            this.InactiveMods.Name = "InactiveMods";
            this.InactiveMods.Size = new System.Drawing.Size(282, 264);
            this.InactiveMods.TabIndex = 3;
            this.InactiveMods.SelectedIndexChanged += new System.EventHandler(this.InactiveMods_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(5, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Activate Selected Mod  ⯈⯈⯈";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(6, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "⯇⯇⯇ Deactivate Selected Mod";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ActiveMods
            // 
            this.ActiveMods.FormattingEnabled = true;
            this.ActiveMods.Location = new System.Drawing.Point(6, 23);
            this.ActiveMods.Name = "ActiveMods";
            this.ActiveMods.Size = new System.Drawing.Size(282, 264);
            this.ActiveMods.TabIndex = 6;
            this.ActiveMods.SelectedIndexChanged += new System.EventHandler(this.ActiveMods_SelectedIndexChanged);
            // 
            // Install
            // 
            this.Install.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Install.Location = new System.Drawing.Point(6, 293);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(282, 20);
            this.Install.TabIndex = 9;
            this.Install.Text = "Confirm";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inactive Mods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Active Mods";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ModDescriptionLabel);
            this.panel1.Controls.Add(this.ModSizeLabel);
            this.panel1.Controls.Add(this.ModReleaseDateLabel);
            this.panel1.Controls.Add(this.ModVersionLabel);
            this.panel1.Controls.Add(this.ModAuthorsLabel);
            this.panel1.Controls.Add(this.ModNameLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 111);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mod Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ActiveMods);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.Install);
            this.panel2.Location = new System.Drawing.Point(306, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 384);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.InactiveMods);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(4, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 384);
            this.panel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Author(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Release Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "File Size";
            // 
            // ModSizeLabel
            // 
            this.ModSizeLabel.AutoSize = true;
            this.ModSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModSizeLabel.Location = new System.Drawing.Point(94, 77);
            this.ModSizeLabel.Name = "ModSizeLabel";
            this.ModSizeLabel.Size = new System.Drawing.Size(0, 13);
            this.ModSizeLabel.TabIndex = 20;
            // 
            // ModReleaseDateLabel
            // 
            this.ModReleaseDateLabel.AutoSize = true;
            this.ModReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModReleaseDateLabel.Location = new System.Drawing.Point(94, 62);
            this.ModReleaseDateLabel.Name = "ModReleaseDateLabel";
            this.ModReleaseDateLabel.Size = new System.Drawing.Size(0, 13);
            this.ModReleaseDateLabel.TabIndex = 19;
            // 
            // ModVersionLabel
            // 
            this.ModVersionLabel.AutoSize = true;
            this.ModVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModVersionLabel.Location = new System.Drawing.Point(94, 47);
            this.ModVersionLabel.Name = "ModVersionLabel";
            this.ModVersionLabel.Size = new System.Drawing.Size(0, 13);
            this.ModVersionLabel.TabIndex = 18;
            // 
            // ModAuthorsLabel
            // 
            this.ModAuthorsLabel.AutoSize = true;
            this.ModAuthorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModAuthorsLabel.Location = new System.Drawing.Point(94, 32);
            this.ModAuthorsLabel.Name = "ModAuthorsLabel";
            this.ModAuthorsLabel.Size = new System.Drawing.Size(0, 13);
            this.ModAuthorsLabel.TabIndex = 17;
            // 
            // ModNameLabel
            // 
            this.ModNameLabel.AutoSize = true;
            this.ModNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModNameLabel.Location = new System.Drawing.Point(94, 2);
            this.ModNameLabel.Name = "ModNameLabel";
            this.ModNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ModNameLabel.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMordhauDirectoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youtubeTutorialToolStripMenuItem,
            this.textTutorialToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // setMordhauDirectoryToolStripMenuItem
            // 
            this.setMordhauDirectoryToolStripMenuItem.Name = "setMordhauDirectoryToolStripMenuItem";
            this.setMordhauDirectoryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.setMordhauDirectoryToolStripMenuItem.Text = "Set Mordhau Directory";
            // 
            // youtubeTutorialToolStripMenuItem
            // 
            this.youtubeTutorialToolStripMenuItem.Name = "youtubeTutorialToolStripMenuItem";
            this.youtubeTutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youtubeTutorialToolStripMenuItem.Text = "Youtube Tutorial";
            // 
            // textTutorialToolStripMenuItem
            // 
            this.textTutorialToolStripMenuItem.Name = "textTutorialToolStripMenuItem";
            this.textTutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textTutorialToolStripMenuItem.Text = "Text Tutorial";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ModDescriptionLabel
            // 
            this.ModDescriptionLabel.AutoSize = true;
            this.ModDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModDescriptionLabel.Location = new System.Drawing.Point(94, 17);
            this.ModDescriptionLabel.Name = "ModDescriptionLabel";
            this.ModDescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.ModDescriptionLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 546);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Teok\'s Mod Loader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox InactiveMods;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox ActiveMods;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ModSizeLabel;
        private System.Windows.Forms.Label ModReleaseDateLabel;
        private System.Windows.Forms.Label ModVersionLabel;
        private System.Windows.Forms.Label ModAuthorsLabel;
        private System.Windows.Forms.Label ModNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMordhauDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ModDescriptionLabel;
    }
}


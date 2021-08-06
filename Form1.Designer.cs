
namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CurrentService = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Hairstyle = new System.Windows.Forms.RadioButton();
            this.MKover = new System.Windows.Forms.RadioButton();
            this.Manq = new System.Windows.Forms.RadioButton();
            this.Perm = new System.Windows.Forms.RadioButton();
            this.NoOpt = new System.Windows.Forms.RadioButton();
            this.Ten = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayandaCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.twenty = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twenty);
            this.groupBox1.Controls.Add(this.Ten);
            this.groupBox1.Controls.Add(this.NoOpt);
            this.groupBox1.Location = new System.Drawing.Point(43, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Perm);
            this.groupBox2.Controls.Add(this.Manq);
            this.groupBox2.Controls.Add(this.MKover);
            this.groupBox2.Controls.Add(this.Hairstyle);
            this.groupBox2.Location = new System.Drawing.Point(384, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CurrentService
            // 
            this.CurrentService.AutoSize = true;
            this.CurrentService.Location = new System.Drawing.Point(94, 290);
            this.CurrentService.Name = "CurrentService";
            this.CurrentService.Size = new System.Drawing.Size(83, 13);
            this.CurrentService.TabIndex = 2;
            this.CurrentService.Text = "Current Servive:";
            this.CurrentService.Click += new System.EventHandler(this.label1_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(94, 340);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(103, 13);
            this.Total.TabIndex = 3;
            this.Total.Text = "Total of all Services:";
            // 
            // Hairstyle
            // 
            this.Hairstyle.AutoSize = true;
            this.Hairstyle.Location = new System.Drawing.Point(18, 20);
            this.Hairstyle.Name = "Hairstyle";
            this.Hairstyle.Size = new System.Drawing.Size(65, 17);
            this.Hairstyle.TabIndex = 0;
            this.Hairstyle.TabStop = true;
            this.Hairstyle.Text = "Hairstyle";
            this.Hairstyle.UseVisualStyleBackColor = true;
            this.Hairstyle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MKover
            // 
            this.MKover.AutoSize = true;
            this.MKover.Location = new System.Drawing.Point(18, 56);
            this.MKover.Name = "MKover";
            this.MKover.Size = new System.Drawing.Size(73, 17);
            this.MKover.TabIndex = 1;
            this.MKover.TabStop = true;
            this.MKover.Text = "Makeover";
            this.MKover.UseVisualStyleBackColor = true;
            // 
            // Manq
            // 
            this.Manq.AutoSize = true;
            this.Manq.Location = new System.Drawing.Point(18, 93);
            this.Manq.Name = "Manq";
            this.Manq.Size = new System.Drawing.Size(69, 17);
            this.Manq.TabIndex = 2;
            this.Manq.TabStop = true;
            this.Manq.Text = "Manicure";
            this.Manq.UseVisualStyleBackColor = true;
            this.Manq.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Perm
            // 
            this.Perm.AutoSize = true;
            this.Perm.Location = new System.Drawing.Point(18, 127);
            this.Perm.Name = "Perm";
            this.Perm.Size = new System.Drawing.Size(76, 17);
            this.Perm.TabIndex = 3;
            this.Perm.TabStop = true;
            this.Perm.Text = "Permanent";
            this.Perm.UseVisualStyleBackColor = true;
            // 
            // NoOpt
            // 
            this.NoOpt.AutoSize = true;
            this.NoOpt.Checked = true;
            this.NoOpt.Location = new System.Drawing.Point(16, 20);
            this.NoOpt.Name = "NoOpt";
            this.NoOpt.Size = new System.Drawing.Size(51, 17);
            this.NoOpt.TabIndex = 0;
            this.NoOpt.TabStop = true;
            this.NoOpt.Text = "None\r\n";
            this.NoOpt.UseVisualStyleBackColor = true;
            this.NoOpt.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Location = new System.Drawing.Point(16, 56);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(45, 17);
            this.Ten.TabIndex = 1;
            this.Ten.Text = "10%";
            this.Ten.UseVisualStyleBackColor = true;
            this.Ten.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.nextPatronToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayandaCCToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ayandaCCToolStripMenuItem
            // 
            this.ayandaCCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.ayandaCCToolStripMenuItem.Name = "ayandaCCToolStripMenuItem";
            this.ayandaCCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayandaCCToolStripMenuItem.Text = "Ayanda CC";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // nextPatronToolStripMenuItem
            // 
            this.nextPatronToolStripMenuItem.Name = "nextPatronToolStripMenuItem";
            this.nextPatronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextPatronToolStripMenuItem.Text = "Next Patron";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(402, 290);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(117, 22);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(402, 331);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(117, 22);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // twenty
            // 
            this.twenty.AutoSize = true;
            this.twenty.Location = new System.Drawing.Point(16, 82);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(45, 17);
            this.twenty.TabIndex = 2;
            this.twenty.TabStop = true;
            this.twenty.Text = "20%";
            this.twenty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(690, 411);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.CurrentService);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Consultation Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CurrentService;
        private System.Windows.Forms.RadioButton Hairstyle;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.RadioButton Manq;
        private System.Windows.Forms.RadioButton MKover;
        private System.Windows.Forms.RadioButton Perm;
        private System.Windows.Forms.RadioButton NoOpt;
        private System.Windows.Forms.RadioButton Ten;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextPatronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayandaCCToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.RadioButton twenty;
    }
}


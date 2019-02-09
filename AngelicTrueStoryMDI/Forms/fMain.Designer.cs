namespace AngelicTrueStoryMDI
{
    partial class fMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.schoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ангелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolToolStripMenuItem,
            this.прочитатьБазуToolStripMenuItem,
            this.ангелToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // schoolToolStripMenuItem
            // 
            this.schoolToolStripMenuItem.Name = "schoolToolStripMenuItem";
            this.schoolToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.schoolToolStripMenuItem.Tag = "20";
            this.schoolToolStripMenuItem.Text = "\"Накидки\"";
            this.schoolToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // прочитатьБазуToolStripMenuItem
            // 
            this.прочитатьБазуToolStripMenuItem.Name = "прочитатьБазуToolStripMenuItem";
            this.прочитатьБазуToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.прочитатьБазуToolStripMenuItem.Tag = "30";
            this.прочитатьБазуToolStripMenuItem.Text = "Справочники";
            this.прочитатьБазуToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ангелToolStripMenuItem
            // 
            this.ангелToolStripMenuItem.Name = "ангелToolStripMenuItem";
            this.ангелToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ангелToolStripMenuItem.Tag = "10";
            this.ангелToolStripMenuItem.Text = "Ангел";
            this.ангелToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fMain";
            this.Text = "The Hell v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.fMain_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem schoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ангелToolStripMenuItem;
    }
}


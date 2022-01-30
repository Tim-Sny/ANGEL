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
            this.miSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefs = new System.Windows.Forms.ToolStripMenuItem();
            this.miAngel = new System.Windows.Forms.ToolStripMenuItem();
            this.miBonesAndStones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSchool,
            this.miRefs,
            this.miAngel,
            this.miBonesAndStones});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miSchool
            // 
            this.miSchool.Name = "miSchool";
            this.miSchool.Size = new System.Drawing.Size(76, 20);
            this.miSchool.Tag = "20";
            this.miSchool.Text = "\"Накидки\"";
            this.miSchool.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // miRefs
            // 
            this.miRefs.Name = "miRefs";
            this.miRefs.Size = new System.Drawing.Size(94, 20);
            this.miRefs.Tag = "30";
            this.miRefs.Text = "Справочники";
            this.miRefs.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // miAngel
            // 
            this.miAngel.Name = "miAngel";
            this.miAngel.Size = new System.Drawing.Size(52, 20);
            this.miAngel.Tag = "10";
            this.miAngel.Text = "Ангел";
            this.miAngel.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // miBonesAndStones
            // 
            this.miBonesAndStones.Name = "miBonesAndStones";
            this.miBonesAndStones.Size = new System.Drawing.Size(116, 20);
            this.miBonesAndStones.Tag = "40";
            this.miBonesAndStones.Text = "И кости, и камни!";
            this.miBonesAndStones.Click += new System.EventHandler(this.MenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem miSchool;
        private System.Windows.Forms.ToolStripMenuItem miRefs;
        private System.Windows.Forms.ToolStripMenuItem miAngel;
        private System.Windows.Forms.ToolStripMenuItem miBonesAndStones;
    }
}


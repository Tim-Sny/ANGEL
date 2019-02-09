namespace AngelicTrueStoryMDI.Controls
{
    partial class PointsLabel
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
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.lbShift = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tlMain.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLevel
            // 
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLevel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLevel.Location = new System.Drawing.Point(0, 0);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(43, 28);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "0";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbPoint.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPoint.Location = new System.Drawing.Point(36, 0);
            this.lbPoint.Margin = new System.Windows.Forms.Padding(0);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(13, 13);
            this.lbPoint.TabIndex = 1;
            this.lbPoint.Text = "0";
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 3;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.Controls.Add(this.pnCenter, 1, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 3;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.Size = new System.Drawing.Size(69, 33);
            this.tlMain.TabIndex = 2;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.lbShift);
            this.pnCenter.Controls.Add(this.lbPoint);
            this.pnCenter.Controls.Add(this.lbLevel);
            this.pnCenter.Location = new System.Drawing.Point(3, 2);
            this.pnCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(62, 28);
            this.pnCenter.TabIndex = 0;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.BackColor = System.Drawing.Color.Transparent;
            this.lbShift.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbShift.ForeColor = System.Drawing.Color.Green;
            this.lbShift.Location = new System.Drawing.Point(36, 13);
            this.lbShift.Margin = new System.Windows.Forms.Padding(0);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(13, 13);
            this.lbShift.TabIndex = 2;
            this.lbShift.Text = "0";
            this.lbShift.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // PointsLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMain);
            this.Name = "PointsLabel";
            this.Size = new System.Drawing.Size(69, 33);
            this.tlMain.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label lbShift;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

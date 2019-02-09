namespace AngelicTrueStoryMDI.Controls
{
    partial class DayEnablePanel
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
            this.lBottom = new System.Windows.Forms.Label();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cbBox = new System.Windows.Forms.CheckBox();
            this.lTop = new System.Windows.Forms.Label();
            this.tlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBottom
            // 
            this.lBottom.AutoSize = true;
            this.lBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lBottom.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBottom.ForeColor = System.Drawing.Color.Maroon;
            this.lBottom.Location = new System.Drawing.Point(0, 27);
            this.lBottom.Margin = new System.Windows.Forms.Padding(0);
            this.lBottom.Name = "lBottom";
            this.lBottom.Size = new System.Drawing.Size(50, 10);
            this.lBottom.TabIndex = 2;
            this.lBottom.Text = "Параметр";
            this.lBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 1;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanel.Controls.Add(this.lBottom, 0, 2);
            this.tlPanel.Controls.Add(this.cbBox, 0, 1);
            this.tlPanel.Controls.Add(this.lTop, 0, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanel.MinimumSize = new System.Drawing.Size(50, 50);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 3;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tlPanel.Size = new System.Drawing.Size(50, 50);
            this.tlPanel.TabIndex = 1;
            // 
            // cbBox
            // 
            this.cbBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBox.AutoSize = true;
            this.cbBox.Location = new System.Drawing.Point(17, 13);
            this.cbBox.Margin = new System.Windows.Forms.Padding(0);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(15, 14);
            this.cbBox.TabIndex = 1;
            this.cbBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBox.UseVisualStyleBackColor = true;
            this.cbBox.CheckedChanged += new System.EventHandler(this.cbBox_CheckedChanged);
            // 
            // lTop
            // 
            this.lTop.AutoSize = true;
            this.lTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lTop.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lTop.Location = new System.Drawing.Point(3, 0);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(44, 13);
            this.lTop.TabIndex = 2;
            this.lTop.Text = "+00";
            this.lTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DayEnablePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlPanel);
            this.MinimumSize = new System.Drawing.Size(45, 37);
            this.Name = "DayEnablePanel";
            this.Size = new System.Drawing.Size(45, 37);
            this.tlPanel.ResumeLayout(false);
            this.tlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lBottom;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.CheckBox cbBox;
        private System.Windows.Forms.Label lTop;
    }
}

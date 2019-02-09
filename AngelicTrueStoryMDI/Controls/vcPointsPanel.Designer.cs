namespace AngelicTrueStoryMDI.Controls
{
    partial class PointsPanel
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
            this.tlMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lBL = new System.Windows.Forms.Label();
            this.lBR = new System.Windows.Forms.Label();
            this.tlPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.lTL = new System.Windows.Forms.Label();
            this.lTC = new System.Windows.Forms.Label();
            this.lTR = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tlMainPanel.SuspendLayout();
            this.tlPanelBottom.SuspendLayout();
            this.tlPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMainPanel
            // 
            this.tlMainPanel.ColumnCount = 1;
            this.tlMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMainPanel.Controls.Add(this.tlPanelBottom, 0, 2);
            this.tlMainPanel.Controls.Add(this.tlPanelTop, 0, 0);
            this.tlMainPanel.Controls.Add(this.textBox, 0, 1);
            this.tlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.tlMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tlMainPanel.Name = "tlMainPanel";
            this.tlMainPanel.RowCount = 3;
            this.tlMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMainPanel.Size = new System.Drawing.Size(95, 53);
            this.tlMainPanel.TabIndex = 8;
            // 
            // tlPanelBottom
            // 
            this.tlPanelBottom.ColumnCount = 2;
            this.tlPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelBottom.Controls.Add(this.lBL, 0, 0);
            this.tlPanelBottom.Controls.Add(this.lBR, 1, 0);
            this.tlPanelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlPanelBottom.Location = new System.Drawing.Point(0, 38);
            this.tlPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelBottom.Name = "tlPanelBottom";
            this.tlPanelBottom.RowCount = 1;
            this.tlPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanelBottom.Size = new System.Drawing.Size(95, 12);
            this.tlPanelBottom.TabIndex = 8;
            // 
            // lBL
            // 
            this.lBL.AutoSize = true;
            this.lBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBL.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBL.ForeColor = System.Drawing.Color.Maroon;
            this.lBL.Location = new System.Drawing.Point(0, 0);
            this.lBL.Margin = new System.Windows.Forms.Padding(0);
            this.lBL.Name = "lBL";
            this.lBL.Size = new System.Drawing.Size(47, 15);
            this.lBL.TabIndex = 3;
            this.lBL.Text = "Н-ЛВ";
            // 
            // lBR
            // 
            this.lBR.AutoSize = true;
            this.lBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBR.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBR.ForeColor = System.Drawing.Color.Purple;
            this.lBR.Location = new System.Drawing.Point(47, 0);
            this.lBR.Margin = new System.Windows.Forms.Padding(0);
            this.lBR.Name = "lBR";
            this.lBR.Size = new System.Drawing.Size(48, 15);
            this.lBR.TabIndex = 3;
            this.lBR.Text = "Н-ПР";
            this.lBR.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tlPanelTop
            // 
            this.tlPanelTop.ColumnCount = 3;
            this.tlPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPanelTop.Controls.Add(this.lTL, 0, 0);
            this.tlPanelTop.Controls.Add(this.lTC, 1, 0);
            this.tlPanelTop.Controls.Add(this.lTR, 2, 0);
            this.tlPanelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlPanelTop.Location = new System.Drawing.Point(0, 3);
            this.tlPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlPanelTop.Name = "tlPanelTop";
            this.tlPanelTop.RowCount = 1;
            this.tlPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanelTop.Size = new System.Drawing.Size(95, 12);
            this.tlPanelTop.TabIndex = 6;
            // 
            // lTL
            // 
            this.lTL.AutoSize = true;
            this.lTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTL.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTL.ForeColor = System.Drawing.Color.Black;
            this.lTL.Location = new System.Drawing.Point(0, 0);
            this.lTL.Margin = new System.Windows.Forms.Padding(0);
            this.lTL.Name = "lTL";
            this.lTL.Size = new System.Drawing.Size(31, 15);
            this.lTL.TabIndex = 3;
            this.lTL.Text = "В-ЛВ";
            this.lTL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lTC
            // 
            this.lTC.AutoSize = true;
            this.lTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTC.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTC.ForeColor = System.Drawing.Color.Blue;
            this.lTC.Location = new System.Drawing.Point(31, 0);
            this.lTC.Margin = new System.Windows.Forms.Padding(0);
            this.lTC.Name = "lTC";
            this.lTC.Size = new System.Drawing.Size(31, 15);
            this.lTC.TabIndex = 3;
            this.lTC.Text = "В-СР";
            this.lTC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lTR
            // 
            this.lTR.AutoSize = true;
            this.lTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTR.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lTR.Location = new System.Drawing.Point(62, 0);
            this.lTR.Margin = new System.Windows.Forms.Padding(0);
            this.lTR.Name = "lTR";
            this.lTR.Size = new System.Drawing.Size(33, 15);
            this.lTR.TabIndex = 3;
            this.lTR.Text = "В-ПР";
            this.lTR.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lTR.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lTR_MouseClick);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(3, 18);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(89, 20);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "Накидка";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // PointsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "PointsPanel";
            this.Size = new System.Drawing.Size(95, 53);
            this.tlMainPanel.ResumeLayout(false);
            this.tlMainPanel.PerformLayout();
            this.tlPanelBottom.ResumeLayout(false);
            this.tlPanelBottom.PerformLayout();
            this.tlPanelTop.ResumeLayout(false);
            this.tlPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMainPanel;
        private System.Windows.Forms.TableLayoutPanel tlPanelBottom;
        private System.Windows.Forms.Label lBL;
        private System.Windows.Forms.Label lBR;
        private System.Windows.Forms.TableLayoutPanel tlPanelTop;
        private System.Windows.Forms.Label lTL;
        private System.Windows.Forms.Label lTC;
        private System.Windows.Forms.Label lTR;
        private System.Windows.Forms.TextBox textBox;
    }
}

namespace AngelicTrueStoryMDI.Controls
{
    partial class CHSelectPanel
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMainPanel
            // 
            this.tlMainPanel.ColumnCount = 1;
            this.tlMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMainPanel.Controls.Add(this.comboBox, 0, 1);
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
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(0, 16);
            this.comboBox.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(95, 21);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // CHSelectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "CHSelectPanel";
            this.Size = new System.Drawing.Size(95, 53);
            this.tlMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMainPanel;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

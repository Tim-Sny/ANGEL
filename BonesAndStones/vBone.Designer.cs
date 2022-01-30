namespace BonesAndStones
{
    partial class vBone
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
            this.lbBone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBone
            // 
            this.lbBone.BackColor = System.Drawing.Color.Transparent;
            this.lbBone.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBone.ForeColor = System.Drawing.Color.DarkGray;
            this.lbBone.Location = new System.Drawing.Point(5, 6);
            this.lbBone.Margin = new System.Windows.Forms.Padding(0);
            this.lbBone.Name = "lbBone";
            this.lbBone.Size = new System.Drawing.Size(15, 10);
            this.lbBone.TabIndex = 0;
            this.lbBone.Text = "88";
            this.lbBone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vBone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbBone);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(24, 24);
            this.MinimumSize = new System.Drawing.Size(24, 24);
            this.Name = "vBone";
            this.Size = new System.Drawing.Size(24, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBone;
    }
}

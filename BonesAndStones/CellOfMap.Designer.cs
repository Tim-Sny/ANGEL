namespace BonesAndStones
{
    partial class CellOfMap
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
            this.lbPoints = new System.Windows.Forms.Label();
            this.lbSame = new System.Windows.Forms.Label();
            this.pnCell = new System.Windows.Forms.Panel();
            this.flpBones = new System.Windows.Forms.FlowLayoutPanel();
            this.lbOther = new System.Windows.Forms.Label();
            this.pnBorder = new System.Windows.Forms.Panel();
            this.vBoneWhite = new BonesAndStones.vBone();
            this.vBoneStone = new BonesAndStones.vBone();
            this.vBoneBlack = new BonesAndStones.vBone();
            this.pnCell.SuspendLayout();
            this.flpBones.SuspendLayout();
            this.pnBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPoints
            // 
            this.lbPoints.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPoints.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPoints.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPoints.Location = new System.Drawing.Point(3, 3);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(63, 34);
            this.lbPoints.TabIndex = 0;
            this.lbPoints.Text = "+5";
            this.lbPoints.Click += new System.EventHandler(this._CellClick);
            // 
            // lbSame
            // 
            this.lbSame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSame.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSame.ForeColor = System.Drawing.Color.White;
            this.lbSame.Location = new System.Drawing.Point(61, 0);
            this.lbSame.Name = "lbSame";
            this.lbSame.Size = new System.Drawing.Size(31, 19);
            this.lbSame.TabIndex = 1;
            this.lbSame.Text = "+5";
            this.lbSame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSame.Click += new System.EventHandler(this._CellClick);
            // 
            // pnCell
            // 
            this.pnCell.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnCell.Controls.Add(this.flpBones);
            this.pnCell.Controls.Add(this.lbOther);
            this.pnCell.Controls.Add(this.lbSame);
            this.pnCell.Controls.Add(this.lbPoints);
            this.pnCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCell.ForeColor = System.Drawing.Color.Gray;
            this.pnCell.Location = new System.Drawing.Point(4, 4);
            this.pnCell.Name = "pnCell";
            this.pnCell.Size = new System.Drawing.Size(92, 92);
            this.pnCell.TabIndex = 2;
            this.pnCell.Click += new System.EventHandler(this._CellClick);
            // 
            // flpBones
            // 
            this.flpBones.Controls.Add(this.vBoneWhite);
            this.flpBones.Controls.Add(this.vBoneStone);
            this.flpBones.Controls.Add(this.vBoneBlack);
            this.flpBones.Location = new System.Drawing.Point(0, 40);
            this.flpBones.Name = "flpBones";
            this.flpBones.Size = new System.Drawing.Size(92, 30);
            this.flpBones.TabIndex = 2;
            this.flpBones.Click += new System.EventHandler(this._CellClick);
            // 
            // lbOther
            // 
            this.lbOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOther.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOther.ForeColor = System.Drawing.Color.Black;
            this.lbOther.Location = new System.Drawing.Point(58, 18);
            this.lbOther.Margin = new System.Windows.Forms.Padding(0);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(34, 19);
            this.lbOther.TabIndex = 1;
            this.lbOther.Text = "+5";
            this.lbOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbOther.Click += new System.EventHandler(this._CellClick);
            // 
            // pnBorder
            // 
            this.pnBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBorder.Controls.Add(this.pnCell);
            this.pnBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBorder.Location = new System.Drawing.Point(0, 0);
            this.pnBorder.Name = "pnBorder";
            this.pnBorder.Padding = new System.Windows.Forms.Padding(4);
            this.pnBorder.Size = new System.Drawing.Size(100, 100);
            this.pnBorder.TabIndex = 3;
            // 
            // vBoneWhite
            // 
            this.vBoneWhite.BoneType = BonesAndStones.BoneType.White;
            this.vBoneWhite.Count = 5;
            this.vBoneWhite.Location = new System.Drawing.Point(2, 2);
            this.vBoneWhite.Margin = new System.Windows.Forms.Padding(2);
            this.vBoneWhite.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBoneWhite.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBoneWhite.Name = "vBoneWhite";
            this.vBoneWhite.Size = new System.Drawing.Size(24, 24);
            this.vBoneWhite.TabIndex = 0;
            // 
            // vBoneStone
            // 
            this.vBoneStone.BoneType = BonesAndStones.BoneType.Stone;
            this.vBoneStone.Count = 5;
            this.vBoneStone.Location = new System.Drawing.Point(30, 2);
            this.vBoneStone.Margin = new System.Windows.Forms.Padding(2);
            this.vBoneStone.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBoneStone.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBoneStone.Name = "vBoneStone";
            this.vBoneStone.Size = new System.Drawing.Size(24, 24);
            this.vBoneStone.TabIndex = 1;
            // 
            // vBoneBlack
            // 
            this.vBoneBlack.BoneType = BonesAndStones.BoneType.Black;
            this.vBoneBlack.Count = 5;
            this.vBoneBlack.Location = new System.Drawing.Point(58, 2);
            this.vBoneBlack.Margin = new System.Windows.Forms.Padding(2);
            this.vBoneBlack.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBoneBlack.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBoneBlack.Name = "vBoneBlack";
            this.vBoneBlack.Size = new System.Drawing.Size(24, 24);
            this.vBoneBlack.TabIndex = 2;
            // 
            // CellOfMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBorder);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "CellOfMap";
            this.Size = new System.Drawing.Size(100, 100);
            this.pnCell.ResumeLayout(false);
            this.flpBones.ResumeLayout(false);
            this.pnBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lbSame;
        private System.Windows.Forms.Panel pnCell;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.FlowLayoutPanel flpBones;
        private System.Windows.Forms.Panel pnBorder;
        private vBone vBoneWhite;
        private vBone vBoneStone;
        private vBone vBoneBlack;
    }
}

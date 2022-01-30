namespace BonesAndStones
{
    partial class fBonesAndStones
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnCup = new System.Windows.Forms.Panel();
            this.BonesPlayer0 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPlayerBlack = new System.Windows.Forms.Panel();
            this.lbBlackDice = new System.Windows.Forms.Label();
            this.BonesPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBlack = new System.Windows.Forms.Label();
            this.pnPlayerWhite = new System.Windows.Forms.Panel();
            this.lbWhiteDice = new System.Windows.Forms.Label();
            this.BonesPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbWhite = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tlpMap = new System.Windows.Forms.TableLayoutPanel();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.tsGameStep = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.BASMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.vCupWhite = new BonesAndStones.vBone();
            this.vCupStone = new BonesAndStones.vBone();
            this.vCupBlack = new BonesAndStones.vBone();
            this.vBlackPlayerWhite = new BonesAndStones.vBone();
            this.vBlackPlayerStone = new BonesAndStones.vBone();
            this.vBlackPlayerBlack = new BonesAndStones.vBone();
            this.vWhitePlayerWhite = new BonesAndStones.vBone();
            this.vWhitePlayerStone = new BonesAndStones.vBone();
            this.vWhitePlayerBlack = new BonesAndStones.vBone();
            this.lbWhitePoints = new System.Windows.Forms.Label();
            this.lbBlackPoints = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnCup.SuspendLayout();
            this.BonesPlayer0.SuspendLayout();
            this.pnPlayerBlack.SuspendLayout();
            this.BonesPlayer2.SuspendLayout();
            this.pnPlayerWhite.SuspendLayout();
            this.BonesPlayer1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.Status.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pnCup);
            this.pnTop.Controls.Add(this.pnPlayerBlack);
            this.pnTop.Controls.Add(this.pnPlayerWhite);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 24);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(663, 59);
            this.pnTop.TabIndex = 1;
            // 
            // pnCup
            // 
            this.pnCup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnCup.Controls.Add(this.BonesPlayer0);
            this.pnCup.Controls.Add(this.label1);
            this.pnCup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCup.Location = new System.Drawing.Point(224, 0);
            this.pnCup.Name = "pnCup";
            this.pnCup.Size = new System.Drawing.Size(212, 59);
            this.pnCup.TabIndex = 1;
            // 
            // BonesPlayer0
            // 
            this.BonesPlayer0.Controls.Add(this.vCupWhite);
            this.BonesPlayer0.Controls.Add(this.vCupStone);
            this.BonesPlayer0.Controls.Add(this.vCupBlack);
            this.BonesPlayer0.Location = new System.Drawing.Point(72, 21);
            this.BonesPlayer0.Name = "BonesPlayer0";
            this.BonesPlayer0.Size = new System.Drawing.Size(84, 33);
            this.BonesPlayer0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Чаша";
            // 
            // pnPlayerBlack
            // 
            this.pnPlayerBlack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnPlayerBlack.Controls.Add(this.lbBlackPoints);
            this.pnPlayerBlack.Controls.Add(this.lbBlackDice);
            this.pnPlayerBlack.Controls.Add(this.BonesPlayer2);
            this.pnPlayerBlack.Controls.Add(this.lbBlack);
            this.pnPlayerBlack.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPlayerBlack.Location = new System.Drawing.Point(436, 0);
            this.pnPlayerBlack.Name = "pnPlayerBlack";
            this.pnPlayerBlack.Size = new System.Drawing.Size(227, 59);
            this.pnPlayerBlack.TabIndex = 2;
            // 
            // lbBlackDice
            // 
            this.lbBlackDice.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlackDice.Location = new System.Drawing.Point(48, 9);
            this.lbBlackDice.Name = "lbBlackDice";
            this.lbBlackDice.Size = new System.Drawing.Size(80, 45);
            this.lbBlackDice.TabIndex = 3;
            this.lbBlackDice.Text = "| 5";
            this.lbBlackDice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbBlackDice.MouseClick += new System.Windows.Forms.MouseEventHandler(this._MouseClick);
            // 
            // BonesPlayer2
            // 
            this.BonesPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BonesPlayer2.Controls.Add(this.vBlackPlayerWhite);
            this.BonesPlayer2.Controls.Add(this.vBlackPlayerStone);
            this.BonesPlayer2.Controls.Add(this.vBlackPlayerBlack);
            this.BonesPlayer2.Location = new System.Drawing.Point(130, 21);
            this.BonesPlayer2.Name = "BonesPlayer2";
            this.BonesPlayer2.Size = new System.Drawing.Size(97, 33);
            this.BonesPlayer2.TabIndex = 1;
            // 
            // lbBlack
            // 
            this.lbBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBlack.AutoSize = true;
            this.lbBlack.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlack.Location = new System.Drawing.Point(130, -1);
            this.lbBlack.Name = "lbBlack";
            this.lbBlack.Size = new System.Drawing.Size(97, 19);
            this.lbBlack.TabIndex = 0;
            this.lbBlack.Text = "Чёрный игрок";
            // 
            // pnPlayerWhite
            // 
            this.pnPlayerWhite.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnPlayerWhite.Controls.Add(this.lbWhitePoints);
            this.pnPlayerWhite.Controls.Add(this.lbWhiteDice);
            this.pnPlayerWhite.Controls.Add(this.BonesPlayer1);
            this.pnPlayerWhite.Controls.Add(this.lbWhite);
            this.pnPlayerWhite.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPlayerWhite.Location = new System.Drawing.Point(0, 0);
            this.pnPlayerWhite.Name = "pnPlayerWhite";
            this.pnPlayerWhite.Size = new System.Drawing.Size(224, 59);
            this.pnPlayerWhite.TabIndex = 0;
            // 
            // lbWhiteDice
            // 
            this.lbWhiteDice.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhiteDice.Location = new System.Drawing.Point(95, 9);
            this.lbWhiteDice.Name = "lbWhiteDice";
            this.lbWhiteDice.Size = new System.Drawing.Size(80, 45);
            this.lbWhiteDice.TabIndex = 3;
            this.lbWhiteDice.Text = "2 -";
            this.lbWhiteDice.MouseClick += new System.Windows.Forms.MouseEventHandler(this._MouseClick);
            // 
            // BonesPlayer1
            // 
            this.BonesPlayer1.Controls.Add(this.vWhitePlayerWhite);
            this.BonesPlayer1.Controls.Add(this.vWhitePlayerStone);
            this.BonesPlayer1.Controls.Add(this.vWhitePlayerBlack);
            this.BonesPlayer1.Location = new System.Drawing.Point(0, 21);
            this.BonesPlayer1.Name = "BonesPlayer1";
            this.BonesPlayer1.Size = new System.Drawing.Size(97, 33);
            this.BonesPlayer1.TabIndex = 2;
            // 
            // lbWhite
            // 
            this.lbWhite.AutoSize = true;
            this.lbWhite.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhite.Location = new System.Drawing.Point(-2, 0);
            this.lbWhite.Name = "lbWhite";
            this.lbWhite.Size = new System.Drawing.Size(91, 19);
            this.lbWhite.TabIndex = 0;
            this.lbWhite.Text = "Белый игрок";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.tlpMap);
            this.pnMain.Controls.Add(this.Status);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 83);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(663, 575);
            this.pnMain.TabIndex = 2;
            // 
            // tlpMap
            // 
            this.tlpMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tlpMap.ColumnCount = 6;
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMap.Location = new System.Drawing.Point(0, 0);
            this.tlpMap.Name = "tlpMap";
            this.tlpMap.RowCount = 6;
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMap.Size = new System.Drawing.Size(663, 553);
            this.tlpMap.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGameStep});
            this.Status.Location = new System.Drawing.Point(0, 553);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(663, 22);
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // tsGameStep
            // 
            this.tsGameStep.AutoSize = false;
            this.tsGameStep.Name = "tsGameStep";
            this.tsGameStep.Size = new System.Drawing.Size(250, 17);
            this.tsGameStep.Text = "GameStep";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BASMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.MdiWindowListItem = this.BASMenu;
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(663, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Tag = "40";
            // 
            // BASMenu
            // 
            this.BASMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem13,
            this.MenuItem26,
            this.MenuItem39});
            this.BASMenu.Name = "BASMenu";
            this.BASMenu.Size = new System.Drawing.Size(66, 20);
            this.BASMenu.Text = "Играть...";
            // 
            // MenuItem13
            // 
            this.MenuItem13.Name = "MenuItem13";
            this.MenuItem13.Size = new System.Drawing.Size(114, 22);
            this.MenuItem13.Tag = "13";
            this.MenuItem13.Text = "... до 13";
            // 
            // MenuItem26
            // 
            this.MenuItem26.Name = "MenuItem26";
            this.MenuItem26.Size = new System.Drawing.Size(114, 22);
            this.MenuItem26.Tag = "26";
            this.MenuItem26.Text = "... до 26";
            // 
            // MenuItem39
            // 
            this.MenuItem39.Name = "MenuItem39";
            this.MenuItem39.Size = new System.Drawing.Size(114, 22);
            this.MenuItem39.Tag = "39";
            this.MenuItem39.Text = "... до 39";
            // 
            // vCupWhite
            // 
            this.vCupWhite.BoneType = BonesAndStones.BoneType.White;
            this.vCupWhite.Count = 5;
            this.vCupWhite.Location = new System.Drawing.Point(2, 2);
            this.vCupWhite.Margin = new System.Windows.Forms.Padding(2);
            this.vCupWhite.MaximumSize = new System.Drawing.Size(24, 24);
            this.vCupWhite.MinimumSize = new System.Drawing.Size(24, 24);
            this.vCupWhite.Name = "vCupWhite";
            this.vCupWhite.Size = new System.Drawing.Size(24, 24);
            this.vCupWhite.TabIndex = 0;
            this.vCupWhite.Click += new System.EventHandler(this._BoneClick);
            // 
            // vCupStone
            // 
            this.vCupStone.BoneType = BonesAndStones.BoneType.Stone;
            this.vCupStone.Count = 5;
            this.vCupStone.Location = new System.Drawing.Point(30, 2);
            this.vCupStone.Margin = new System.Windows.Forms.Padding(2);
            this.vCupStone.MaximumSize = new System.Drawing.Size(24, 24);
            this.vCupStone.MinimumSize = new System.Drawing.Size(24, 24);
            this.vCupStone.Name = "vCupStone";
            this.vCupStone.Size = new System.Drawing.Size(24, 24);
            this.vCupStone.TabIndex = 1;
            this.vCupStone.Click += new System.EventHandler(this._BoneClick);
            // 
            // vCupBlack
            // 
            this.vCupBlack.BoneType = BonesAndStones.BoneType.Black;
            this.vCupBlack.Count = 5;
            this.vCupBlack.Location = new System.Drawing.Point(58, 2);
            this.vCupBlack.Margin = new System.Windows.Forms.Padding(2);
            this.vCupBlack.MaximumSize = new System.Drawing.Size(24, 24);
            this.vCupBlack.MinimumSize = new System.Drawing.Size(24, 24);
            this.vCupBlack.Name = "vCupBlack";
            this.vCupBlack.Size = new System.Drawing.Size(24, 24);
            this.vCupBlack.TabIndex = 2;
            this.vCupBlack.Click += new System.EventHandler(this._BoneClick);
            // 
            // vBlackPlayerWhite
            // 
            this.vBlackPlayerWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vBlackPlayerWhite.BoneType = BonesAndStones.BoneType.White;
            this.vBlackPlayerWhite.Count = 5;
            this.vBlackPlayerWhite.Location = new System.Drawing.Point(2, 2);
            this.vBlackPlayerWhite.Margin = new System.Windows.Forms.Padding(2);
            this.vBlackPlayerWhite.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerWhite.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerWhite.Name = "vBlackPlayerWhite";
            this.vBlackPlayerWhite.Size = new System.Drawing.Size(24, 24);
            this.vBlackPlayerWhite.TabIndex = 0;
            this.vBlackPlayerWhite.Click += new System.EventHandler(this._BoneClick);
            // 
            // vBlackPlayerStone
            // 
            this.vBlackPlayerStone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vBlackPlayerStone.BoneType = BonesAndStones.BoneType.Stone;
            this.vBlackPlayerStone.Count = 5;
            this.vBlackPlayerStone.Location = new System.Drawing.Point(30, 2);
            this.vBlackPlayerStone.Margin = new System.Windows.Forms.Padding(2);
            this.vBlackPlayerStone.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerStone.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerStone.Name = "vBlackPlayerStone";
            this.vBlackPlayerStone.Size = new System.Drawing.Size(24, 24);
            this.vBlackPlayerStone.TabIndex = 1;
            this.vBlackPlayerStone.Click += new System.EventHandler(this._BoneClick);
            // 
            // vBlackPlayerBlack
            // 
            this.vBlackPlayerBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vBlackPlayerBlack.BoneType = BonesAndStones.BoneType.Black;
            this.vBlackPlayerBlack.Count = 5;
            this.vBlackPlayerBlack.Location = new System.Drawing.Point(58, 2);
            this.vBlackPlayerBlack.Margin = new System.Windows.Forms.Padding(2);
            this.vBlackPlayerBlack.MaximumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerBlack.MinimumSize = new System.Drawing.Size(24, 24);
            this.vBlackPlayerBlack.Name = "vBlackPlayerBlack";
            this.vBlackPlayerBlack.Size = new System.Drawing.Size(24, 24);
            this.vBlackPlayerBlack.TabIndex = 2;
            this.vBlackPlayerBlack.Click += new System.EventHandler(this._BoneClick);
            // 
            // vWhitePlayerWhite
            // 
            this.vWhitePlayerWhite.BoneType = BonesAndStones.BoneType.White;
            this.vWhitePlayerWhite.Count = 5;
            this.vWhitePlayerWhite.Location = new System.Drawing.Point(2, 2);
            this.vWhitePlayerWhite.Margin = new System.Windows.Forms.Padding(2);
            this.vWhitePlayerWhite.MaximumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerWhite.MinimumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerWhite.Name = "vWhitePlayerWhite";
            this.vWhitePlayerWhite.Size = new System.Drawing.Size(24, 24);
            this.vWhitePlayerWhite.TabIndex = 0;
            this.vWhitePlayerWhite.Click += new System.EventHandler(this._BoneClick);
            // 
            // vWhitePlayerStone
            // 
            this.vWhitePlayerStone.BoneType = BonesAndStones.BoneType.Stone;
            this.vWhitePlayerStone.Count = 5;
            this.vWhitePlayerStone.Location = new System.Drawing.Point(30, 2);
            this.vWhitePlayerStone.Margin = new System.Windows.Forms.Padding(2);
            this.vWhitePlayerStone.MaximumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerStone.MinimumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerStone.Name = "vWhitePlayerStone";
            this.vWhitePlayerStone.Size = new System.Drawing.Size(24, 24);
            this.vWhitePlayerStone.TabIndex = 1;
            this.vWhitePlayerStone.Click += new System.EventHandler(this._BoneClick);
            // 
            // vWhitePlayerBlack
            // 
            this.vWhitePlayerBlack.BoneType = BonesAndStones.BoneType.Black;
            this.vWhitePlayerBlack.Count = 5;
            this.vWhitePlayerBlack.Location = new System.Drawing.Point(58, 2);
            this.vWhitePlayerBlack.Margin = new System.Windows.Forms.Padding(2);
            this.vWhitePlayerBlack.MaximumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerBlack.MinimumSize = new System.Drawing.Size(24, 24);
            this.vWhitePlayerBlack.Name = "vWhitePlayerBlack";
            this.vWhitePlayerBlack.Size = new System.Drawing.Size(24, 24);
            this.vWhitePlayerBlack.TabIndex = 2;
            this.vWhitePlayerBlack.Click += new System.EventHandler(this._BoneClick);
            // 
            // lbWhitePoints
            // 
            this.lbWhitePoints.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhitePoints.Location = new System.Drawing.Point(95, -1);
            this.lbWhitePoints.Name = "lbWhitePoints";
            this.lbWhitePoints.Size = new System.Drawing.Size(39, 19);
            this.lbWhitePoints.TabIndex = 0;
            this.lbWhitePoints.Text = "39";
            // 
            // lbBlackPoints
            // 
            this.lbBlackPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBlackPoints.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBlackPoints.Location = new System.Drawing.Point(87, -1);
            this.lbBlackPoints.Name = "lbBlackPoints";
            this.lbBlackPoints.Size = new System.Drawing.Size(41, 19);
            this.lbBlackPoints.TabIndex = 0;
            this.lbBlackPoints.Text = "39";
            this.lbBlackPoints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fBonesAndStones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 658);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "fBonesAndStones";
            this.Text = "И кости, и камни!";
            this.pnTop.ResumeLayout(false);
            this.pnCup.ResumeLayout(false);
            this.pnCup.PerformLayout();
            this.BonesPlayer0.ResumeLayout(false);
            this.pnPlayerBlack.ResumeLayout(false);
            this.pnPlayerBlack.PerformLayout();
            this.BonesPlayer2.ResumeLayout(false);
            this.pnPlayerWhite.ResumeLayout(false);
            this.pnPlayerWhite.PerformLayout();
            this.BonesPlayer1.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.TableLayoutPanel tlpMap;
        private System.Windows.Forms.Panel pnPlayerBlack;
        private System.Windows.Forms.Label lbBlack;
        private System.Windows.Forms.Panel pnCup;
        private System.Windows.Forms.FlowLayoutPanel BonesPlayer0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPlayerWhite;
        private System.Windows.Forms.Label lbWhite;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem BASMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem13;
        private System.Windows.Forms.ToolStripMenuItem MenuItem26;
        private System.Windows.Forms.ToolStripMenuItem MenuItem39;
        private System.Windows.Forms.FlowLayoutPanel BonesPlayer2;
        private System.Windows.Forms.FlowLayoutPanel BonesPlayer1;
        private vBone vBlackPlayerWhite;
        private vBone vBlackPlayerStone;
        private vBone vBlackPlayerBlack;
        private vBone vCupWhite;
        private vBone vCupStone;
        private vBone vCupBlack;
        private vBone vWhitePlayerWhite;
        private vBone vWhitePlayerStone;
        private vBone vWhitePlayerBlack;
        private System.Windows.Forms.Label lbBlackDice;
        private System.Windows.Forms.Label lbWhiteDice;
        private System.Windows.Forms.ToolStripStatusLabel tsGameStep;
        private System.Windows.Forms.Label lbBlackPoints;
        private System.Windows.Forms.Label lbWhitePoints;
    }
}


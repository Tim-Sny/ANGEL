namespace Angel
{
    partial class fReferences
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
            this.components = new System.ComponentModel.Container();
            this.tcRefs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDsActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDsActivityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sActivityTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHell = new Angel.dsHell();
            this.sActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDsActivityTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sActivityTableAdapter = new Angel.dsHellTableAdapters.sActivityTableAdapter();
            this.sActivityTypeTableAdapter = new Angel.dsHellTableAdapters.sActivityTypeTableAdapter();
            this.tcRefs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sActivityTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRefs
            // 
            this.tcRefs.Controls.Add(this.tabPage1);
            this.tcRefs.Controls.Add(this.tabPage2);
            this.tcRefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRefs.Location = new System.Drawing.Point(0, 0);
            this.tcRefs.Name = "tcRefs";
            this.tcRefs.SelectedIndex = 0;
            this.tcRefs.Size = new System.Drawing.Size(800, 450);
            this.tcRefs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Тренировки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(786, 418);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsActivityDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDsActivityTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sActivityBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDsActivityDataGridViewTextBoxColumn
            // 
            this.iDsActivityDataGridViewTextBoxColumn.DataPropertyName = "IDsActivity";
            this.iDsActivityDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDsActivityDataGridViewTextBoxColumn.Name = "iDsActivityDataGridViewTextBoxColumn";
            this.iDsActivityDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // iDsActivityTypeDataGridViewTextBoxColumn
            // 
            this.iDsActivityTypeDataGridViewTextBoxColumn.DataPropertyName = "IDsActivityType";
            this.iDsActivityTypeDataGridViewTextBoxColumn.DataSource = this.sActivityTypeBindingSource;
            this.iDsActivityTypeDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.iDsActivityTypeDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.iDsActivityTypeDataGridViewTextBoxColumn.Name = "iDsActivityTypeDataGridViewTextBoxColumn";
            this.iDsActivityTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDsActivityTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDsActivityTypeDataGridViewTextBoxColumn.ValueMember = "IDsActivityType";
            // 
            // sActivityTypeBindingSource
            // 
            this.sActivityTypeBindingSource.DataMember = "sActivityType";
            this.sActivityTypeBindingSource.DataSource = this.dsHell;
            // 
            // dsHell
            // 
            this.dsHell.DataSetName = "dsHell";
            this.dsHell.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sActivityBindingSource
            // 
            this.sActivityBindingSource.DataMember = "sActivity";
            this.sActivityBindingSource.DataSource = this.dsHell;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsActivityTypeDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sActivityTypeBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(198, 418);
            this.dataGridView2.TabIndex = 0;
            // 
            // iDsActivityTypeDataGridViewTextBoxColumn1
            // 
            this.iDsActivityTypeDataGridViewTextBoxColumn1.DataPropertyName = "IDsActivityType";
            this.iDsActivityTypeDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDsActivityTypeDataGridViewTextBoxColumn1.Name = "iDsActivityTypeDataGridViewTextBoxColumn1";
            this.iDsActivityTypeDataGridViewTextBoxColumn1.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Группа";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 115;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sActivityTableAdapter
            // 
            this.sActivityTableAdapter.ClearBeforeFill = true;
            // 
            // sActivityTypeTableAdapter
            // 
            this.sActivityTypeTableAdapter.ClearBeforeFill = true;
            // 
            // fReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcRefs);
            this.Name = "fReferences";
            this.Tag = "30";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.fReferences_Load);
            this.tcRefs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sActivityTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRefs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsHell dsHell;
        private System.Windows.Forms.BindingSource sActivityBindingSource;
        private dsHellTableAdapters.sActivityTableAdapter sActivityTableAdapter;
        private System.Windows.Forms.BindingSource sActivityTypeBindingSource;
        private dsHellTableAdapters.sActivityTypeTableAdapter sActivityTypeTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsActivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDsActivityTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsActivityTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}
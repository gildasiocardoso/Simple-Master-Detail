namespace SimpleMasterDetail
{
    partial class FormMain
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
            System.Windows.Forms.Label iD_GROUP_PRODUCTLabel;
            System.Windows.Forms.Label dSC_GROUP_PRODUCTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sUBGROUP_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataModel = new SimpleMasterDetail.DataModel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gROUP_PRODUCTTableAdapter = new SimpleMasterDetail.DataModelTableAdapters.GROUP_PRODUCTTableAdapter();
            this.tableAdapterManager = new SimpleMasterDetail.DataModelTableAdapters.TableAdapterManager();
            this.sUBGROUP_PRODUCTTableAdapter = new SimpleMasterDetail.DataModelTableAdapters.SUBGROUP_PRODUCTTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sUBGROUP_PRODUCTDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_SUBGROUP_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSC_SUBGROUP_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_GROUP_PRODUCTTextBox = new System.Windows.Forms.TextBox();
            this.dSC_GROUP_PRODUCTTextBox = new System.Windows.Forms.TextBox();
            this.gROUP_PRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gROUP_PRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_GROUP_PRODUCTLabel = new System.Windows.Forms.Label();
            dSC_GROUP_PRODUCTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataModel)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingNavigator)).BeginInit();
            this.gROUP_PRODUCTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_GROUP_PRODUCTLabel
            // 
            iD_GROUP_PRODUCTLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            iD_GROUP_PRODUCTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_GROUP_PRODUCTLabel.Location = new System.Drawing.Point(8, 24);
            iD_GROUP_PRODUCTLabel.Name = "iD_GROUP_PRODUCTLabel";
            iD_GROUP_PRODUCTLabel.Size = new System.Drawing.Size(94, 17);
            iD_GROUP_PRODUCTLabel.TabIndex = 11;
            iD_GROUP_PRODUCTLabel.Text = "Id:";
            iD_GROUP_PRODUCTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dSC_GROUP_PRODUCTLabel
            // 
            dSC_GROUP_PRODUCTLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            dSC_GROUP_PRODUCTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dSC_GROUP_PRODUCTLabel.Location = new System.Drawing.Point(8, 46);
            dSC_GROUP_PRODUCTLabel.Name = "dSC_GROUP_PRODUCTLabel";
            dSC_GROUP_PRODUCTLabel.Size = new System.Drawing.Size(94, 17);
            dSC_GROUP_PRODUCTLabel.TabIndex = 13;
            dSC_GROUP_PRODUCTLabel.Text = "Description:";
            dSC_GROUP_PRODUCTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sUBGROUP_PRODUCTBindingSource
            // 
            this.sUBGROUP_PRODUCTBindingSource.DataMember = "SUBGROUP_PRD_FK_GROUP_PRD";
            this.sUBGROUP_PRODUCTBindingSource.DataSource = this.gROUP_PRODUCTBindingSource;
            // 
            // gROUP_PRODUCTBindingSource
            // 
            this.gROUP_PRODUCTBindingSource.DataMember = "GROUP_PRODUCT";
            this.gROUP_PRODUCTBindingSource.DataSource = this.dataModel;
            // 
            // dataModel
            // 
            this.dataModel.DataSetName = "DataModel";
            this.dataModel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 93);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "\nExample to how to configure (almost without code) a simple master detail using:\n" +
    "- DataSet\n- Relation\n- DataAdapters\n- BindingSource DataSource";
            // 
            // gROUP_PRODUCTTableAdapter
            // 
            this.gROUP_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GROUP_PRODUCTTableAdapter = this.gROUP_PRODUCTTableAdapter;
            this.tableAdapterManager.SUBGROUP_PRODUCTTableAdapter = this.sUBGROUP_PRODUCTTableAdapter;
            this.tableAdapterManager.UpdateOrder = SimpleMasterDetail.DataModelTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sUBGROUP_PRODUCTTableAdapter
            // 
            this.sUBGROUP_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 368);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Model representation (picture)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 349);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(395, 93);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 368);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gROUP_PRODUCTBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(402, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 368);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sUBGROUP_PRODUCTDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 271);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subgroup of Products";
            // 
            // sUBGROUP_PRODUCTDataGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Empty;
            this.sUBGROUP_PRODUCTDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.sUBGROUP_PRODUCTDataGridView.AutoGenerateColumns = false;
            this.sUBGROUP_PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBGROUP_PRODUCTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SUBGROUP_PRODUCT,
            this.DSC_SUBGROUP_PRODUCT,
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn});
            this.sUBGROUP_PRODUCTDataGridView.DataSource = this.sUBGROUP_PRODUCTBindingSource;
            this.sUBGROUP_PRODUCTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sUBGROUP_PRODUCTDataGridView.Location = new System.Drawing.Point(3, 16);
            this.sUBGROUP_PRODUCTDataGridView.Name = "sUBGROUP_PRODUCTDataGridView";
            this.sUBGROUP_PRODUCTDataGridView.Size = new System.Drawing.Size(392, 252);
            this.sUBGROUP_PRODUCTDataGridView.TabIndex = 12;
            // 
            // ID_SUBGROUP_PRODUCT
            // 
            this.ID_SUBGROUP_PRODUCT.DataPropertyName = "ID_SUBGROUP_PRODUCT";
            this.ID_SUBGROUP_PRODUCT.HeaderText = "Id SubGroup";
            this.ID_SUBGROUP_PRODUCT.Name = "ID_SUBGROUP_PRODUCT";
            this.ID_SUBGROUP_PRODUCT.ReadOnly = true;
            this.ID_SUBGROUP_PRODUCT.Width = 120;
            // 
            // DSC_SUBGROUP_PRODUCT
            // 
            this.DSC_SUBGROUP_PRODUCT.DataPropertyName = "DSC_SUBGROUP_PRODUCT";
            this.DSC_SUBGROUP_PRODUCT.HeaderText = "Description Subgroup";
            this.DSC_SUBGROUP_PRODUCT.Name = "DSC_SUBGROUP_PRODUCT";
            this.DSC_SUBGROUP_PRODUCT.Width = 350;
            // 
            // iDGROUPPRODUCTDataGridViewTextBoxColumn
            // 
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn.DataPropertyName = "ID_GROUP_PRODUCT";
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn.HeaderText = "ID_GROUP_PRODUCT";
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn.Name = "iDGROUPPRODUCTDataGridViewTextBoxColumn";
            this.iDGROUPPRODUCTDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iD_GROUP_PRODUCTLabel);
            this.groupBox1.Controls.Add(this.iD_GROUP_PRODUCTTextBox);
            this.groupBox1.Controls.Add(dSC_GROUP_PRODUCTLabel);
            this.groupBox1.Controls.Add(this.dSC_GROUP_PRODUCTTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 72);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group of Products";
            // 
            // iD_GROUP_PRODUCTTextBox
            // 
            this.iD_GROUP_PRODUCTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gROUP_PRODUCTBindingSource, "ID_GROUP_PRODUCT", true));
            this.iD_GROUP_PRODUCTTextBox.Location = new System.Drawing.Point(103, 22);
            this.iD_GROUP_PRODUCTTextBox.Name = "iD_GROUP_PRODUCTTextBox";
            this.iD_GROUP_PRODUCTTextBox.ReadOnly = true;
            this.iD_GROUP_PRODUCTTextBox.Size = new System.Drawing.Size(73, 20);
            this.iD_GROUP_PRODUCTTextBox.TabIndex = 12;
            // 
            // dSC_GROUP_PRODUCTTextBox
            // 
            this.dSC_GROUP_PRODUCTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gROUP_PRODUCTBindingSource, "DSC_GROUP_PRODUCT", true));
            this.dSC_GROUP_PRODUCTTextBox.Location = new System.Drawing.Point(103, 44);
            this.dSC_GROUP_PRODUCTTextBox.Name = "dSC_GROUP_PRODUCTTextBox";
            this.dSC_GROUP_PRODUCTTextBox.Size = new System.Drawing.Size(413, 20);
            this.dSC_GROUP_PRODUCTTextBox.TabIndex = 14;
            // 
            // gROUP_PRODUCTBindingNavigator
            // 
            this.gROUP_PRODUCTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gROUP_PRODUCTBindingNavigator.BindingSource = this.gROUP_PRODUCTBindingSource;
            this.gROUP_PRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gROUP_PRODUCTBindingNavigator.DeleteItem = null;
            this.gROUP_PRODUCTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gROUP_PRODUCTBindingNavigatorSaveItem});
            this.gROUP_PRODUCTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gROUP_PRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gROUP_PRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gROUP_PRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gROUP_PRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gROUP_PRODUCTBindingNavigator.Name = "gROUP_PRODUCTBindingNavigator";
            this.gROUP_PRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gROUP_PRODUCTBindingNavigator.Size = new System.Drawing.Size(398, 25);
            this.gROUP_PRODUCTBindingNavigator.TabIndex = 14;
            this.gROUP_PRODUCTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // gROUP_PRODUCTBindingNavigatorSaveItem
            // 
            this.gROUP_PRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gROUP_PRODUCTBindingNavigatorSaveItem.Image")));
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Name = "gROUP_PRODUCTBindingNavigatorSaveItem";
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormMain";
            this.Text = "Configuring Master Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataModel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingNavigator)).EndInit();
            this.gROUP_PRODUCTBindingNavigator.ResumeLayout(false);
            this.gROUP_PRODUCTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataModel dataModel;
        private System.Windows.Forms.BindingSource gROUP_PRODUCTBindingSource;
        private DataModelTableAdapters.GROUP_PRODUCTTableAdapter gROUP_PRODUCTTableAdapter;
        private DataModelTableAdapters.TableAdapterManager tableAdapterManager;
        private DataModelTableAdapters.SUBGROUP_PRODUCTTableAdapter sUBGROUP_PRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource sUBGROUP_PRODUCTBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox iD_GROUP_PRODUCTTextBox;
        private System.Windows.Forms.TextBox dSC_GROUP_PRODUCTTextBox;
        private System.Windows.Forms.BindingNavigator gROUP_PRODUCTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton gROUP_PRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView sUBGROUP_PRODUCTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SUBGROUP_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSC_SUBGROUP_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGROUPPRODUCTDataGridViewTextBoxColumn;
    }
}


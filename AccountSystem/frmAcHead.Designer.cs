namespace AccountSystem
{
    partial class frmAcHead
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
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label modifiedLabel;
            System.Windows.Forms.Label accHeadNameLabel;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label accHeadCodeLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcHead));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accHeadDS = new AccountSystem.AccHeadDS();
            this.tblAccHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccHeadTableAdapter = new AccountSystem.AccHeadDSTableAdapters.TblAccHeadTableAdapter();
            this.tableAdapterManager = new AccountSystem.AccHeadDSTableAdapters.TableAdapterManager();
            this.tblAccHeadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tblAccHeadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.repliCheckBox = new System.Windows.Forms.CheckBox();
            this.accHeadNameTextBox = new System.Windows.Forms.TextBox();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.accHeadCodeTextBox = new System.Windows.Forms.TextBox();
            this.tblAccHeadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accTypeComboBox = new System.Windows.Forms.ComboBox();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            accHeadNameLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            accHeadCodeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accHeadDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingNavigator)).BeginInit();
            this.tblAccHeadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdLabel.Location = new System.Drawing.Point(12, 262);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 0;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modifiedLabel.Location = new System.Drawing.Point(345, 262);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(50, 13);
            modifiedLabel.TabIndex = 3;
            modifiedLabel.Text = "Modified:";
            // 
            // accHeadNameLabel
            // 
            accHeadNameLabel.AutoSize = true;
            accHeadNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accHeadNameLabel.Location = new System.Drawing.Point(10, 41);
            accHeadNameLabel.Name = "accHeadNameLabel";
            accHeadNameLabel.Size = new System.Drawing.Size(77, 13);
            accHeadNameLabel.TabIndex = 2;
            accHeadNameLabel.Text = "Head Name:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(387, 149);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 11;
            companyIDLabel.Text = "Company ID:";
            // 
            // accHeadCodeLabel
            // 
            accHeadCodeLabel.AutoSize = true;
            accHeadCodeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accHeadCodeLabel.Location = new System.Drawing.Point(10, 15);
            accHeadCodeLabel.Name = "accHeadCodeLabel";
            accHeadCodeLabel.Size = new System.Drawing.Size(83, 13);
            accHeadCodeLabel.TabIndex = 0;
            accHeadCodeLabel.Text = "Account Head:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 13);
            label1.TabIndex = 6;
            label1.Text = "Account Type:";
            // 
            // accHeadDS
            // 
            this.accHeadDS.DataSetName = "AccHeadDS";
            this.accHeadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccHeadBindingSource
            // 
            this.tblAccHeadBindingSource.DataMember = "TblAccHead";
            this.tblAccHeadBindingSource.DataSource = this.accHeadDS;
            // 
            // tblAccHeadTableAdapter
            // 
            this.tblAccHeadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblAccHeadTableAdapter = this.tblAccHeadTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.AccHeadDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblAccHeadBindingNavigator
            // 
            this.tblAccHeadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblAccHeadBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tblAccHeadBindingNavigator.BindingSource = this.tblAccHeadBindingSource;
            this.tblAccHeadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblAccHeadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblAccHeadBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblAccHeadBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblAccHeadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel3,
            this.tblAccHeadBindingNavigatorSaveItem,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.tblAccHeadBindingNavigator.Location = new System.Drawing.Point(0, 295);
            this.tblAccHeadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblAccHeadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblAccHeadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblAccHeadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblAccHeadBindingNavigator.Name = "tblAccHeadBindingNavigator";
            this.tblAccHeadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblAccHeadBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tblAccHeadBindingNavigator.Size = new System.Drawing.Size(622, 25);
            this.tblAccHeadBindingNavigator.TabIndex = 2;
            this.tblAccHeadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator.Visible = false;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(253, 22);
            this.toolStripLabel1.Text = "                                                                                 " +
                " ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel3.Text = "  ";
            // 
            // tblAccHeadBindingNavigatorSaveItem
            // 
            this.tblAccHeadBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.tblAccHeadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblAccHeadBindingNavigatorSaveItem.Image")));
            this.tblAccHeadBindingNavigatorSaveItem.Name = "tblAccHeadBindingNavigatorSaveItem";
            this.tblAccHeadBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.tblAccHeadBindingNavigatorSaveItem.Text = "Save Data";
            this.tblAccHeadBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblAccHeadBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "&Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // createdTextBox
            // 
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "Created", true));
            this.createdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTextBox.Location = new System.Drawing.Point(59, 262);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(104, 11);
            this.createdTextBox.TabIndex = 1;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "Modified", true));
            this.modifiedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedTextBox.Location = new System.Drawing.Point(395, 262);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(104, 11);
            this.modifiedTextBox.TabIndex = 4;
            // 
            // repliCheckBox
            // 
            this.repliCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblAccHeadBindingSource, "Repli", true));
            this.repliCheckBox.Location = new System.Drawing.Point(450, 189);
            this.repliCheckBox.Name = "repliCheckBox";
            this.repliCheckBox.Size = new System.Drawing.Size(104, 24);
            this.repliCheckBox.TabIndex = 8;
            this.repliCheckBox.Text = "Repli";
            this.repliCheckBox.UseVisualStyleBackColor = true;
            // 
            // accHeadNameTextBox
            // 
            this.accHeadNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "AccHeadName", true));
            this.accHeadNameTextBox.Location = new System.Drawing.Point(105, 37);
            this.accHeadNameTextBox.Name = "accHeadNameTextBox";
            this.accHeadNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.accHeadNameTextBox.TabIndex = 3;
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "CompanyID", true));
            this.companyIDTextBox.Location = new System.Drawing.Point(482, 146);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.companyIDTextBox.TabIndex = 12;
            // 
            // accHeadCodeTextBox
            // 
            this.accHeadCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "AccHeadCode", true));
            this.accHeadCodeTextBox.Location = new System.Drawing.Point(105, 12);
            this.accHeadCodeTextBox.Name = "accHeadCodeTextBox";
            this.accHeadCodeTextBox.ReadOnly = true;
            this.accHeadCodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.accHeadCodeTextBox.TabIndex = 1;
            // 
            // tblAccHeadDataGridView
            // 
            this.tblAccHeadDataGridView.AllowUserToAddRows = false;
            this.tblAccHeadDataGridView.AllowUserToDeleteRows = false;
            this.tblAccHeadDataGridView.AllowUserToResizeColumns = false;
            this.tblAccHeadDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblAccHeadDataGridView.AutoGenerateColumns = false;
            this.tblAccHeadDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblAccHeadDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblAccHeadDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblAccHeadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblAccHeadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
            this.tblAccHeadDataGridView.DataSource = this.tblAccHeadBindingSource;
            this.tblAccHeadDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.Location = new System.Drawing.Point(125, 116);
            this.tblAccHeadDataGridView.Name = "tblAccHeadDataGridView";
            this.tblAccHeadDataGridView.ReadOnly = true;
            this.tblAccHeadDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblAccHeadDataGridView.RowHeadersVisible = false;
            this.tblAccHeadDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblAccHeadDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAccHeadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAccHeadDataGridView.Size = new System.Drawing.Size(321, 131);
            this.tblAccHeadDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AccHeadCode";
            dataGridViewCellStyle2.Format = "0#";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Account Head";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccHeadName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Head Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tblAccHeadDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.accTypeComboBox);
            this.groupBox2.Controls.Add(this.accHeadCodeTextBox);
            this.groupBox2.Controls.Add(accHeadNameLabel);
            this.groupBox2.Controls.Add(this.accHeadNameTextBox);
            this.groupBox2.Controls.Add(accHeadCodeLabel);
            this.groupBox2.Location = new System.Drawing.Point(20, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // accTypeComboBox
            // 
            this.accTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccHeadBindingSource, "AccType", true));
            this.accTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accTypeComboBox.FormattingEnabled = true;
            this.accTypeComboBox.Items.AddRange(new object[] {
            "Revenue",
            "Expenditure",
            "Assets",
            "Liabilities",
            "Capital"});
            this.accTypeComboBox.Location = new System.Drawing.Point(105, 63);
            this.accTypeComboBox.Name = "accTypeComboBox";
            this.accTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accTypeComboBox.TabIndex = 5;
            // 
            // frmAcHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.repliCheckBox);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(modifiedLabel);
            this.Controls.Add(this.modifiedTextBox);
            this.Controls.Add(companyIDLabel);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(this.tblAccHeadBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcHead";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Chart of Account";
            this.Load += new System.EventHandler(this.frmAcHead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accHeadDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingNavigator)).EndInit();
            this.tblAccHeadBindingNavigator.ResumeLayout(false);
            this.tblAccHeadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccHeadDS accHeadDS;
        private System.Windows.Forms.BindingSource tblAccHeadBindingSource;
        private AccHeadDSTableAdapters.TblAccHeadTableAdapter tblAccHeadTableAdapter;
        private AccHeadDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblAccHeadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblAccHeadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox modifiedTextBox;
        private System.Windows.Forms.CheckBox repliCheckBox;
        private System.Windows.Forms.TextBox accHeadNameTextBox;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.TextBox accHeadCodeTextBox;
        private System.Windows.Forms.DataGridView tblAccHeadDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox accTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
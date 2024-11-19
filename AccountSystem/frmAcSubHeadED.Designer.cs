namespace AccountSystem
{
    partial class frmAcSubHeadED
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
            System.Windows.Forms.Label accSubNameLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label modifiedLabel;
            System.Windows.Forms.Label repliLabel;
            System.Windows.Forms.Label accSubCodeLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcSubHeadED));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accSubHDS = new AccountSystem.AccSubHDS();
            this.tblAccSubHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccSubHeadTableAdapter = new AccountSystem.AccSubHDSTableAdapters.TblAccSubHeadTableAdapter();
            this.tableAdapterManager = new AccountSystem.AccSubHDSTableAdapters.TableAdapterManager();
            this.tblAccSubHeadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tblAccSubHeadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.accSubNameTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.repliCheckBox = new System.Windows.Forms.CheckBox();
            this.accSubCodeTextBox = new System.Windows.Forms.TextBox();
            this.cboHead = new System.Windows.Forms.ComboBox();
            this.tblAccHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accHeadDS = new AccountSystem.AccHeadDS();
            this.tblAccHeadTableAdapter = new AccountSystem.AccHeadDSTableAdapters.TblAccHeadTableAdapter();
            this.tblAccHeadDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            accSubNameLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            repliLabel = new System.Windows.Forms.Label();
            accSubCodeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accSubHDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccSubHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccSubHeadBindingNavigator)).BeginInit();
            this.tblAccSubHeadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accHeadDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accSubNameLabel
            // 
            accSubNameLabel.AutoSize = true;
            accSubNameLabel.Location = new System.Drawing.Point(11, 52);
            accSubNameLabel.Name = "accSubNameLabel";
            accSubNameLabel.Size = new System.Drawing.Size(78, 15);
            accSubNameLabel.TabIndex = 2;
            accSubNameLabel.Text = "Sub Account:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdLabel.Location = new System.Drawing.Point(-1, 247);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 0;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modifiedLabel.Location = new System.Drawing.Point(390, 249);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(50, 13);
            modifiedLabel.TabIndex = 2;
            modifiedLabel.Text = "Modified:";
            // 
            // repliLabel
            // 
            repliLabel.AutoSize = true;
            repliLabel.Location = new System.Drawing.Point(314, 154);
            repliLabel.Name = "repliLabel";
            repliLabel.Size = new System.Drawing.Size(39, 15);
            repliLabel.TabIndex = 11;
            repliLabel.Text = "Repli:";
            // 
            // accSubCodeLabel
            // 
            accSubCodeLabel.AutoSize = true;
            accSubCodeLabel.Location = new System.Drawing.Point(314, 187);
            accSubCodeLabel.Name = "accSubCodeLabel";
            accSubCodeLabel.Size = new System.Drawing.Size(86, 15);
            accSubCodeLabel.TabIndex = 13;
            accSubCodeLabel.Text = "Acc Sub Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Account Head:";
            // 
            // accSubHDS
            // 
            this.accSubHDS.DataSetName = "AccSubHDS";
            this.accSubHDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccSubHeadBindingSource
            // 
            this.tblAccSubHeadBindingSource.DataMember = "TblAccSubHead";
            this.tblAccSubHeadBindingSource.DataSource = this.accSubHDS;
            // 
            // tblAccSubHeadTableAdapter
            // 
            this.tblAccSubHeadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblAccSubHeadTableAdapter = this.tblAccSubHeadTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.AccSubHDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblAccSubHeadBindingNavigator
            // 
            this.tblAccSubHeadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblAccSubHeadBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tblAccSubHeadBindingNavigator.BindingSource = this.tblAccSubHeadBindingSource;
            this.tblAccSubHeadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblAccSubHeadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblAccSubHeadBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblAccSubHeadBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblAccSubHeadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel4,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel2,
            this.tblAccSubHeadBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.toolStripButton1});
            this.tblAccSubHeadBindingNavigator.Location = new System.Drawing.Point(0, 279);
            this.tblAccSubHeadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblAccSubHeadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblAccSubHeadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblAccSubHeadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblAccSubHeadBindingNavigator.Name = "tblAccSubHeadBindingNavigator";
            this.tblAccSubHeadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblAccSubHeadBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tblAccSubHeadBindingNavigator.Size = new System.Drawing.Size(557, 25);
            this.tblAccSubHeadBindingNavigator.TabIndex = 4;
            this.tblAccSubHeadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(295, 22);
            this.toolStripLabel4.Text = "                                                                                 " +
                "               ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // tblAccSubHeadBindingNavigatorSaveItem
            // 
            this.tblAccSubHeadBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tblAccSubHeadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblAccSubHeadBindingNavigatorSaveItem.Image")));
            this.tblAccSubHeadBindingNavigatorSaveItem.Name = "tblAccSubHeadBindingNavigatorSaveItem";
            this.tblAccSubHeadBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.tblAccSubHeadBindingNavigatorSaveItem.Text = "Save Data";
            this.tblAccSubHeadBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblAccSubHeadBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "&Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // accSubNameTextBox
            // 
            this.accSubNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccSubHeadBindingSource, "AccSubName", true));
            this.accSubNameTextBox.Location = new System.Drawing.Point(113, 49);
            this.accSubNameTextBox.Name = "accSubNameTextBox";
            this.accSubNameTextBox.Size = new System.Drawing.Size(241, 21);
            this.accSubNameTextBox.TabIndex = 3;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccSubHeadBindingSource, "Created", true));
            this.createdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTextBox.Location = new System.Drawing.Point(48, 247);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(121, 11);
            this.createdTextBox.TabIndex = 1;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccSubHeadBindingSource, "Modified", true));
            this.modifiedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedTextBox.Location = new System.Drawing.Point(439, 249);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(121, 11);
            this.modifiedTextBox.TabIndex = 3;
            // 
            // repliCheckBox
            // 
            this.repliCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblAccSubHeadBindingSource, "Repli", true));
            this.repliCheckBox.Location = new System.Drawing.Point(417, 149);
            this.repliCheckBox.Name = "repliCheckBox";
            this.repliCheckBox.Size = new System.Drawing.Size(121, 28);
            this.repliCheckBox.TabIndex = 12;
            this.repliCheckBox.Text = "checkBox1";
            this.repliCheckBox.UseVisualStyleBackColor = true;
            // 
            // accSubCodeTextBox
            // 
            this.accSubCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccSubHeadBindingSource, "AccSubCode", true));
            this.accSubCodeTextBox.Location = new System.Drawing.Point(390, 122);
            this.accSubCodeTextBox.Name = "accSubCodeTextBox";
            this.accSubCodeTextBox.Size = new System.Drawing.Size(121, 21);
            this.accSubCodeTextBox.TabIndex = 14;
            // 
            // cboHead
            // 
            this.cboHead.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblAccSubHeadBindingSource, "AccHeadID", true));
            this.cboHead.DataSource = this.tblAccHeadBindingSource;
            this.cboHead.DisplayMember = "AccHeadName";
            this.cboHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHead.FormattingEnabled = true;
            this.cboHead.Location = new System.Drawing.Point(113, 17);
            this.cboHead.Name = "cboHead";
            this.cboHead.Size = new System.Drawing.Size(164, 23);
            this.cboHead.TabIndex = 1;
            this.cboHead.ValueMember = "AccHeadID";
            this.cboHead.SelectedIndexChanged += new System.EventHandler(this.cboHead_SelectedIndexChanged);
            // 
            // tblAccHeadBindingSource
            // 
            this.tblAccHeadBindingSource.DataMember = "TblAccHead";
            this.tblAccHeadBindingSource.DataSource = this.accHeadDS;
            // 
            // accHeadDS
            // 
            this.accHeadDS.DataSetName = "AccHeadDS";
            this.accHeadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccHeadTableAdapter
            // 
            this.tblAccHeadTableAdapter.ClearBeforeFill = true;
            // 
            // tblAccHeadDataGridView
            // 
            this.tblAccHeadDataGridView.AllowUserToAddRows = false;
            this.tblAccHeadDataGridView.AllowUserToDeleteRows = false;
            this.tblAccHeadDataGridView.AllowUserToResizeColumns = false;
            this.tblAccHeadDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblAccHeadDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblAccHeadDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblAccHeadDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblAccHeadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblAccHeadDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.tblAccHeadDataGridView.Location = new System.Drawing.Point(120, 95);
            this.tblAccHeadDataGridView.Name = "tblAccHeadDataGridView";
            this.tblAccHeadDataGridView.ReadOnly = true;
            this.tblAccHeadDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblAccHeadDataGridView.RowHeadersVisible = false;
            this.tblAccHeadDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblAccHeadDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tblAccHeadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAccHeadDataGridView.Size = new System.Drawing.Size(368, 134);
            this.tblAccHeadDataGridView.TabIndex = 1;
            this.tblAccHeadDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAccHeadDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tblAccHeadDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.cboHead);
            this.groupBox2.Controls.Add(accSubNameLabel);
            this.groupBox2.Controls.Add(this.accSubNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // frmAcSubHeadED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 304);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(modifiedLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accSubCodeTextBox);
            this.Controls.Add(repliLabel);
            this.Controls.Add(this.modifiedTextBox);
            this.Controls.Add(this.repliCheckBox);
            this.Controls.Add(accSubCodeLabel);
            this.Controls.Add(this.tblAccSubHeadBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcSubHeadED";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Sub Head";
            this.Load += new System.EventHandler(this.frmAcHead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accSubHDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccSubHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccSubHeadBindingNavigator)).EndInit();
            this.tblAccSubHeadBindingNavigator.ResumeLayout(false);
            this.tblAccSubHeadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accHeadDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccHeadDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccSubHDS accSubHDS;
        private System.Windows.Forms.BindingSource tblAccSubHeadBindingSource;
        private AccSubHDSTableAdapters.TblAccSubHeadTableAdapter tblAccSubHeadTableAdapter;
        private AccSubHDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblAccSubHeadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblAccSubHeadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox accSubNameTextBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox modifiedTextBox;
        private System.Windows.Forms.CheckBox repliCheckBox;
        private System.Windows.Forms.TextBox accSubCodeTextBox;
        private System.Windows.Forms.ComboBox cboHead;
        private System.Windows.Forms.BindingSource tblAccHeadBindingSource;
        private AccHeadDS accHeadDS;
        private AccHeadDSTableAdapters.TblAccHeadTableAdapter tblAccHeadTableAdapter;
        private System.Windows.Forms.DataGridView tblAccHeadDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}
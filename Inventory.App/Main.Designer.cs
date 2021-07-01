
namespace Inventory.App
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokalizacjaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddItem = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.splitContainerCategories = new System.Windows.Forms.SplitContainer();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCategoriesCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryCategoryId = new System.Windows.Forms.TextBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLocations = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLocationsLocationName = new System.Windows.Forms.TextBox();
            this.textBoxLocationsLocationId = new System.Windows.Forms.TextBox();
            this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAddItem.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCategories)).BeginInit();
            this.splitContainerCategories.Panel1.SuspendLayout();
            this.splitContainerCategories.Panel2.SuspendLayout();
            this.splitContainerCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabPageLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 439);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 439);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemName,
            this.Category,
            this.Location,
            this.SerialNumber,
            this.LokalizacjaId,
            this.CategoryIdColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 83);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(829, 385);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "Nazwa";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CategoryName";
            this.Category.HeaderText = "Kategoria";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "LocationName";
            this.Location.HeaderText = "Lokalizacja";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Numer Seryjny";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 200;
            // 
            // LokalizacjaId
            // 
            this.LokalizacjaId.DataPropertyName = "LocationId";
            this.LokalizacjaId.HeaderText = "LokalizacjaId";
            this.LokalizacjaId.Name = "LokalizacjaId";
            this.LokalizacjaId.ReadOnly = true;
            this.LokalizacjaId.Visible = false;
            // 
            // CategoryIdColumn
            // 
            this.CategoryIdColumn.DataPropertyName = "CategoryId";
            this.CategoryIdColumn.HeaderText = "CategoryId";
            this.CategoryIdColumn.Name = "CategoryIdColumn";
            this.CategoryIdColumn.ReadOnly = true;
            this.CategoryIdColumn.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonResetSearch);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxLocation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSerialNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 74);
            this.panel2.TabIndex = 2;
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(3, 51);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(30, 23);
            this.buttonResetSearch.TabIndex = 11;
            this.buttonResetSearch.Text = "x";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(770, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 32);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lokalizacja";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(427, 54);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 8;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numer Seryjny";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(526, 54);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(201, 20);
            this.textBoxSerialNumber.TabIndex = 6;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategoria";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(328, 54);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 4;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(40, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(40, 54);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(38, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddItem);
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Controls.Add(this.tabPageLocations);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 471);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageAddItem
            // 
            this.tabPageAddItem.Controls.Add(this.panel1);
            this.tabPageAddItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddItem.Name = "tabPageAddItem";
            this.tabPageAddItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddItem.Size = new System.Drawing.Size(841, 445);
            this.tabPageAddItem.TabIndex = 0;
            this.tabPageAddItem.Text = "Przedmioty";
            this.tabPageAddItem.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.splitContainerCategories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(841, 445);
            this.tabPageCategories.TabIndex = 1;
            this.tabPageCategories.Text = "Kategorie";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // splitContainerCategories
            // 
            this.splitContainerCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCategories.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCategories.Name = "splitContainerCategories";
            this.splitContainerCategories.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCategories.Panel1
            // 
            this.splitContainerCategories.Panel1.Controls.Add(this.button1);
            this.splitContainerCategories.Panel1.Controls.Add(this.buttonAddCategory);
            this.splitContainerCategories.Panel1.Controls.Add(this.label5);
            this.splitContainerCategories.Panel1.Controls.Add(this.label6);
            this.splitContainerCategories.Panel1.Controls.Add(this.textBoxCategoriesCategoryName);
            this.splitContainerCategories.Panel1.Controls.Add(this.textBoxCategoryCategoryId);
            // 
            // splitContainerCategories.Panel2
            // 
            this.splitContainerCategories.Panel2.Controls.Add(this.dataGridViewCategories);
            this.splitContainerCategories.Size = new System.Drawing.Size(835, 439);
            this.splitContainerCategories.SplitterDistance = 77;
            this.splitContainerCategories.TabIndex = 0;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddCategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddCategory.Location = new System.Drawing.Point(354, 38);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(39, 32);
            this.buttonAddCategory.TabIndex = 11;
            this.buttonAddCategory.Text = "+";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nazwa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // textBoxCategoriesCategoryName
            // 
            this.textBoxCategoriesCategoryName.Location = new System.Drawing.Point(79, 57);
            this.textBoxCategoriesCategoryName.Name = "textBoxCategoriesCategoryName";
            this.textBoxCategoriesCategoryName.Size = new System.Drawing.Size(252, 20);
            this.textBoxCategoriesCategoryName.TabIndex = 5;
            this.textBoxCategoriesCategoryName.TextChanged += new System.EventHandler(this.textBoxCategoryCategoryId_TextChanged);
            // 
            // textBoxCategoryCategoryId
            // 
            this.textBoxCategoryCategoryId.Location = new System.Drawing.Point(42, 57);
            this.textBoxCategoryCategoryId.Name = "textBoxCategoryCategoryId";
            this.textBoxCategoryCategoryId.Size = new System.Drawing.Size(38, 20);
            this.textBoxCategoryCategoryId.TabIndex = 4;
            this.textBoxCategoryCategoryId.TextChanged += new System.EventHandler(this.textBoxCategoryCategoryId_TextChanged);
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.ColumnHeadersVisible = false;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName});
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(835, 358);
            this.dataGridViewCategories.TabIndex = 0;
            this.dataGridViewCategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCategories_CellMouseDoubleClick);
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "Id";
            this.CategoryId.HeaderText = "Id";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Width = 35;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "Nazwa";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 250;
            // 
            // tabPageLocations
            // 
            this.tabPageLocations.Controls.Add(this.splitContainer1);
            this.tabPageLocations.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocations.Name = "tabPageLocations";
            this.tabPageLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocations.Size = new System.Drawing.Size(841, 445);
            this.tabPageLocations.TabIndex = 2;
            this.tabPageLocations.Text = "Lokalizacje";
            this.tabPageLocations.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLocationsLocationName);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLocationsLocationId);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewLocations);
            this.splitContainer1.Size = new System.Drawing.Size(835, 439);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddLocation.ForeColor = System.Drawing.Color.White;
            this.buttonAddLocation.Location = new System.Drawing.Point(354, 38);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(39, 32);
            this.buttonAddLocation.TabIndex = 11;
            this.buttonAddLocation.Text = "+";
            this.buttonAddLocation.UseVisualStyleBackColor = false;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nazwa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID";
            // 
            // textBoxLocationsLocationName
            // 
            this.textBoxLocationsLocationName.Location = new System.Drawing.Point(79, 57);
            this.textBoxLocationsLocationName.Name = "textBoxLocationsLocationName";
            this.textBoxLocationsLocationName.Size = new System.Drawing.Size(252, 20);
            this.textBoxLocationsLocationName.TabIndex = 5;
            this.textBoxLocationsLocationName.TextChanged += new System.EventHandler(this.textBoxLocationsLocationId_TextChanged);
            // 
            // textBoxLocationsLocationId
            // 
            this.textBoxLocationsLocationId.Location = new System.Drawing.Point(42, 57);
            this.textBoxLocationsLocationId.Name = "textBoxLocationsLocationId";
            this.textBoxLocationsLocationId.Size = new System.Drawing.Size(38, 20);
            this.textBoxLocationsLocationId.TabIndex = 4;
            this.textBoxLocationsLocationId.TextChanged += new System.EventHandler(this.textBoxLocationsLocationId_TextChanged);
            // 
            // dataGridViewLocations
            // 
            this.dataGridViewLocations.AllowUserToAddRows = false;
            this.dataGridViewLocations.AllowUserToDeleteRows = false;
            this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocations.ColumnHeadersVisible = false;
            this.dataGridViewLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLocations.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLocations.Name = "dataGridViewLocations";
            this.dataGridViewLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocations.Size = new System.Drawing.Size(835, 358);
            this.dataGridViewLocations.TabIndex = 0;
            this.dataGridViewLocations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLocations_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddItem.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            this.splitContainerCategories.Panel1.ResumeLayout(false);
            this.splitContainerCategories.Panel1.PerformLayout();
            this.splitContainerCategories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCategories)).EndInit();
            this.splitContainerCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabPageLocations.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddItem;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.SplitContainer splitContainerCategories;
        private System.Windows.Forms.TabPage tabPageLocations;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCategoriesCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryCategoryId;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLocationsLocationName;
        private System.Windows.Forms.TextBox textBoxLocationsLocationId;
        private System.Windows.Forms.DataGridView dataGridViewLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokalizacjaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIdColumn;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


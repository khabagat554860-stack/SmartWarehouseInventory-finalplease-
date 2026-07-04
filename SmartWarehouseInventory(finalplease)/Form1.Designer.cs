namespace SmartWarehouseInventory_finalplease_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            btnTest = new Button();
            label2 = new Label();
            btnDelete = new Button();
            btnLoad = new Button();
            btnInsert = new Button();
            lblStorageFee = new Label();
            lblStorageFeeTitle = new Label();
            txtSpecial = new TextBox();
            lblSpecial = new Label();
            cmbItemType = new ComboBox();
            lblItemType = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            txtBaseCost = new TextBox();
            lblBaseCost = new Label();
            txtItemName = new TextBox();
            lblItemName = new Label();
            txtItemID = new TextBox();
            lblItemID = new Label();
            panel2 = new Panel();
            dgvInventory = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SteelBlue;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(984, 70);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 37);
            label1.TabIndex = 0;
            label1.Text = "Smart Warehouse Inventory";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnTest);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(lblStorageFee);
            panel1.Controls.Add(lblStorageFeeTitle);
            panel1.Controls.Add(txtSpecial);
            panel1.Controls.Add(lblSpecial);
            panel1.Controls.Add(cmbItemType);
            panel1.Controls.Add(lblItemType);
            panel1.Controls.Add(numQuantity);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(txtBaseCost);
            panel1.Controls.Add(lblBaseCost);
            panel1.Controls.Add(txtItemName);
            panel1.Controls.Add(lblItemName);
            panel1.Controls.Add(txtItemID);
            panel1.Controls.Add(lblItemID);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 541);
            panel1.TabIndex = 1;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.SteelBlue;
            btnTest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.ForeColor = Color.White;
            btnTest.Location = new Point(173, 392);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(153, 30);
            btnTest.TabIndex = 18;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 18);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 17;
            label2.Text = "ITEM INFORMATION";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(21, 489);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(21, 442);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(166, 30);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load / Refresh Grid";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SteelBlue;
            btnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(21, 392);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(101, 30);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Insert Item";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblStorageFee
            // 
            lblStorageFee.AutoSize = true;
            lblStorageFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorageFee.Location = new Point(24, 352);
            lblStorageFee.Name = "lblStorageFee";
            lblStorageFee.Size = new Size(51, 21);
            lblStorageFee.TabIndex = 13;
            lblStorageFee.Text = "₱0.00";
            // 
            // lblStorageFeeTitle
            // 
            lblStorageFeeTitle.AutoSize = true;
            lblStorageFeeTitle.BackColor = Color.LightGray;
            lblStorageFeeTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStorageFeeTitle.Location = new Point(24, 331);
            lblStorageFeeTitle.Name = "lblStorageFeeTitle";
            lblStorageFeeTitle.Size = new Size(98, 21);
            lblStorageFeeTitle.TabIndex = 12;
            lblStorageFeeTitle.Text = "Storage Fee";
            // 
            // txtSpecial
            // 
            txtSpecial.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpecial.Location = new Point(173, 284);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.Size = new Size(100, 29);
            txtSpecial.TabIndex = 11;
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.BackColor = Color.LightGray;
            lblSpecial.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecial.Location = new Point(24, 292);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(133, 21);
            lblSpecial.TabIndex = 10;
            lblSpecial.Text = "Special Attribute";
            // 
            // cmbItemType
            // 
            cmbItemType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbItemType.FormattingEnabled = true;
            cmbItemType.Items.AddRange(new object[] { "Perishable", "Fragile" });
            cmbItemType.Location = new Point(121, 242);
            cmbItemType.Name = "cmbItemType";
            cmbItemType.Size = new Size(121, 29);
            cmbItemType.TabIndex = 9;
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.BackColor = Color.LightGray;
            lblItemType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemType.Location = new Point(24, 250);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(83, 21);
            lblItemType.TabIndex = 8;
            lblItemType.Text = "Item Type";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(111, 194);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(102, 29);
            numQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.LightGray;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(24, 202);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 21);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // txtBaseCost
            // 
            txtBaseCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBaseCost.Location = new Point(121, 149);
            txtBaseCost.Name = "txtBaseCost";
            txtBaseCost.Size = new Size(100, 29);
            txtBaseCost.TabIndex = 5;
            // 
            // lblBaseCost
            // 
            lblBaseCost.AutoSize = true;
            lblBaseCost.BackColor = Color.LightGray;
            lblBaseCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaseCost.Location = new Point(26, 157);
            lblBaseCost.Name = "lblBaseCost";
            lblBaseCost.Size = new Size(81, 21);
            lblBaseCost.TabIndex = 4;
            lblBaseCost.Text = "Base Cost";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(130, 105);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(101, 29);
            txtItemName.TabIndex = 3;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.LightGray;
            lblItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.Location = new Point(24, 113);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 21);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name";
            // 
            // txtItemID
            // 
            txtItemID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemID.Location = new Point(96, 58);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(93, 29);
            txtItemID.TabIndex = 1;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.BackColor = Color.LightGray;
            lblItemID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemID.Location = new Point(26, 66);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(64, 21);
            lblItemID.TabIndex = 0;
            lblItemID.Text = "Item ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dgvInventory);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 541);
            panel2.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(634, 541);
            dgvInventory.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Warehouse Inventory";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Label lblItemID;
        private Panel panel2;
        private TextBox txtBaseCost;
        private Label lblBaseCost;
        private TextBox txtItemName;
        private Label lblItemName;
        private TextBox txtItemID;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private Label lblSpecial;
        private ComboBox cmbItemType;
        private Label lblItemType;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnInsert;
        private Label lblStorageFee;
        private Label lblStorageFeeTitle;
        private TextBox txtSpecial;
        private Label label2;
        private DataGridView dgvInventory;
        private Button btnTest;
    }
}

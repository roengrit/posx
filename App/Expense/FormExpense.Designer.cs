namespace PosX.App.Expense
{
    partial class FormExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpense));
            this.mainGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTaxType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDocRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtBranchNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.AccessibleName = "Table";
            this.mainGrid.AllowDraggingColumns = true;
            this.mainGrid.AllowEditing = false;
            this.mainGrid.AllowResizingColumns = true;
            this.mainGrid.AllowResizingHiddenColumns = true;
            this.mainGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.mainGrid.BackColor = System.Drawing.SystemColors.Window;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 0);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(1147, 248);
            this.mainGrid.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainGrid);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 379);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 131);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ค้นหา";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายละเอียดสินค้า/บริการ/ค่าใช้จ่าย";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(299, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 283);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.cbTaxType);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDocRef);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.txtBranchNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBranchName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.txtDocNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTaxId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1147, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียดเอกสาร";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbTaxType
            // 
            this.cbTaxType.DisplayMember = "name";
            this.cbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaxType.FormattingEnabled = true;
            this.cbTaxType.Items.AddRange(new object[] {
            "ไม่มีภาษี",
            "ภาษีแยกนอก",
            "ภาษีรวมใน",
            "ภาษีอัตราศูนย์"});
            this.cbTaxType.Location = new System.Drawing.Point(687, 106);
            this.cbTaxType.Name = "cbTaxType";
            this.cbTaxType.Size = new System.Drawing.Size(240, 21);
            this.cbTaxType.TabIndex = 60;
            this.cbTaxType.ValueMember = "id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "ประเภทภาษี :";
            // 
            // txtDocRef
            // 
            this.txtDocRef.BackColor = System.Drawing.Color.White;
            this.txtDocRef.Location = new System.Drawing.Point(687, 80);
            this.txtDocRef.Name = "txtDocRef";
            this.txtDocRef.Size = new System.Drawing.Size(240, 20);
            this.txtDocRef.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "อ้างอิง :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "วันที่ :";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(687, 54);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(143, 20);
            this.dtDate.TabIndex = 56;
            // 
            // txtBranchNo
            // 
            this.txtBranchNo.BackColor = System.Drawing.Color.White;
            this.txtBranchNo.Location = new System.Drawing.Point(358, 162);
            this.txtBranchNo.Name = "txtBranchNo";
            this.txtBranchNo.Size = new System.Drawing.Size(214, 20);
            this.txtBranchNo.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "เลขที่สาขา :";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.Color.White;
            this.txtBranchName.Location = new System.Drawing.Point(126, 163);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(156, 20);
            this.txtBranchName.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "ชื่อสาขา :";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMember.Image")));
            this.btnSearchMember.Location = new System.Drawing.Point(283, 26);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(22, 22);
            this.btnSearchMember.TabIndex = 42;
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtDocNo
            // 
            this.txtDocNo.BackColor = System.Drawing.Color.White;
            this.txtDocNo.Enabled = false;
            this.txtDocNo.Location = new System.Drawing.Point(687, 27);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(240, 20);
            this.txtDocNo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "เลขที่เอกสาร :";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(358, 136);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(214, 20);
            this.txtFax.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "โทรสาร :";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.Location = new System.Drawing.Point(126, 137);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(156, 20);
            this.txtTel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "โทรศัพท์ :";
            // 
            // txtTaxId
            // 
            this.txtTaxId.BackColor = System.Drawing.Color.White;
            this.txtTaxId.Location = new System.Drawing.Point(126, 189);
            this.txtTaxId.Name = "txtTaxId";
            this.txtTaxId.Size = new System.Drawing.Size(156, 20);
            this.txtTaxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "เลขประจำตัวผู้เสียภาษี :";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(126, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(156, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(126, 77);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(446, 54);
            this.txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ที่อยู่ :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(126, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(446, 20);
            this.txtName.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(94, 55);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "ชื่อ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "รหัสคู่ค้า :";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.Text = "ปิดหน้าจอ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnFind,
            this.toolStripSeparator2,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 5);
            this.toolStrip1.Size = new System.Drawing.Size(1147, 36);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 28);
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.Text = "ยกเลิก";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 28);
            this.btnAdd.Text = "เพิ่ม";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 28);
            this.btnFind.Text = "ค้นหา";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(836, 54);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(91, 20);
            this.dtTime.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(922, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "ส่วนลด :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(870, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "มูลค่ารวมก่อนภาษี :";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(979, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(979, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(867, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "ภาษีมูลค่าเพิ่ม (7%) :";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(911, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "มูลค่ารวม :";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(979, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(979, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "หมายเหตุ :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(75, 16);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 54);
            this.textBox3.TabIndex = 62;
            // 
            // FormExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormExpense";
            this.Text = "รายการซื้อ/รับ";
            this.Load += new System.EventHandler(this.FormExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid mainGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtBranchNo;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtBranchName;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearchMember;
        internal System.Windows.Forms.TextBox txtDocNo;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtTaxId;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDate;
        internal System.Windows.Forms.TextBox txtDocRef;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTaxType;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.DateTimePicker dtTime;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox textBox6;
        internal System.Windows.Forms.TextBox textBox7;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
    }
}
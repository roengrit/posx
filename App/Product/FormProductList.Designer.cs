namespace PosX.App.Product
{
    partial class FormProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductList));
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn1 = new Syncfusion.WinForms.DataGrid.GridColumn();
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn2 = new Syncfusion.WinForms.DataGrid.GridColumn();
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn3 = new Syncfusion.WinForms.DataGrid.GridColumn();
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn4 = new Syncfusion.WinForms.DataGrid.GridColumn();
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn5 = new Syncfusion.WinForms.DataGrid.GridColumn();
            Syncfusion.WinForms.DataGrid.GridColumn gridColumn6 = new Syncfusion.WinForms.DataGrid.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1432, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 28);
            this.toolStripButton2.Text = "ยกเลิก";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(48, 28);
            this.toolStripButton3.Text = "ลบ";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(53, 28);
            this.toolStripButton4.Text = "เพิ่ม";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton1.Text = "บันทึก";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(80, 28);
            this.toolStripButton5.Text = "ปิดหน้าจอ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 187);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sfDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 310);
            this.panel2.TabIndex = 2;
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            gridColumn1.AllowDragging = true;
            gridColumn1.AllowFiltering = true;
            gridColumn1.AllowResizing = true;
            gridColumn1.AllowSorting = true;
            gridColumn1.EnableCaseSensitiveFiterRow = false;
            gridColumn1.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn1.FilterRowText = null;
            gridColumn1.FormatProvider = null;
            gridColumn1.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn1.HeaderText = "รหัสสินค้า";
            gridColumn1.MappingName = "Column1";
            gridColumn1.MaximumWidth = 0D;
            gridColumn1.MinimumWidth = 150D;
            gridColumn1.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn2.AllowDragging = true;
            gridColumn2.AllowFiltering = true;
            gridColumn2.AllowResizing = true;
            gridColumn2.AllowSorting = true;
            gridColumn2.EnableCaseSensitiveFiterRow = false;
            gridColumn2.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn2.FilterRowText = null;
            gridColumn2.FormatProvider = null;
            gridColumn2.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn2.HeaderText = "ชื่อสินค้า";
            gridColumn2.MappingName = "Column2";
            gridColumn2.MaximumWidth = 0D;
            gridColumn2.MinimumWidth = 500D;
            gridColumn2.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn3.AllowDragging = true;
            gridColumn3.AllowFiltering = true;
            gridColumn3.AllowResizing = true;
            gridColumn3.AllowSorting = true;
            gridColumn3.EnableCaseSensitiveFiterRow = false;
            gridColumn3.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn3.FilterRowText = null;
            gridColumn3.FormatProvider = null;
            gridColumn3.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn3.HeaderText = "หน่วยสินค้า";
            gridColumn3.MappingName = "Column5";
            gridColumn3.MaximumWidth = 0D;
            gridColumn3.MinimumWidth = 0D;
            gridColumn3.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn4.AllowDragging = true;
            gridColumn4.AllowFiltering = true;
            gridColumn4.AllowResizing = true;
            gridColumn4.AllowSorting = true;
            gridColumn4.EnableCaseSensitiveFiterRow = false;
            gridColumn4.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn4.FilterRowText = null;
            gridColumn4.FormatProvider = null;
            gridColumn4.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn4.HeaderText = "ยอดคงเหลือ";
            gridColumn4.MappingName = "Column6";
            gridColumn4.MaximumWidth = 0D;
            gridColumn4.MinimumWidth = 0D;
            gridColumn4.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn5.AllowDragging = true;
            gridColumn5.AllowFiltering = true;
            gridColumn5.AllowResizing = true;
            gridColumn5.AllowSorting = true;
            gridColumn5.EnableCaseSensitiveFiterRow = false;
            gridColumn5.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn5.FilterRowText = null;
            gridColumn5.FormatProvider = null;
            gridColumn5.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn5.HeaderText = "ราคาต่อหน่วย";
            gridColumn5.MappingName = "Column3";
            gridColumn5.MaximumWidth = 0D;
            gridColumn5.MinimumWidth = 0D;
            gridColumn5.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn6.AllowDragging = true;
            gridColumn6.AllowFiltering = true;
            gridColumn6.AllowResizing = true;
            gridColumn6.AllowSorting = true;
            gridColumn6.EnableCaseSensitiveFiterRow = false;
            gridColumn6.FilterRowCondition = Syncfusion.WinForms.DataGrid.Enums.FilterRowCondition.BeginsWith;
            gridColumn6.FilterRowText = null;
            gridColumn6.FormatProvider = null;
            gridColumn6.GroupMode = Syncfusion.Data.DataReflectionMode.Value;
            gridColumn6.HeaderText = "ราคาขาย";
            gridColumn6.MappingName = "Column4";
            gridColumn6.MaximumWidth = 0D;
            gridColumn6.MinimumWidth = 0D;
            gridColumn6.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            this.sfDataGrid.Columns.Add(gridColumn1);
            this.sfDataGrid.Columns.Add(gridColumn2);
            this.sfDataGrid.Columns.Add(gridColumn3);
            this.sfDataGrid.Columns.Add(gridColumn4);
            this.sfDataGrid.Columns.Add(gridColumn5);
            this.sfDataGrid.Columns.Add(gridColumn6);
            this.sfDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.Size = new System.Drawing.Size(1432, 310);
            this.sfDataGrid.TabIndex = 2;
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormProductList";
            this.Text = "รายการสินค้า";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;

    }
}
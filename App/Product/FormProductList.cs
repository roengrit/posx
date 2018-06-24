using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;

namespace PosX.App.Product
{
    public partial class FormProductList : DockContent
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        private Product itemAction = new Product();
        private Product itemSelection = new Product();
        private bool IsAddOrEdit;

        public FormProductList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainGrid_CurrentCellActivated(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatedEventArgs e)
        {
            //e.DataRow.
        }

        private void mainGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            cbUnit.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_unit");
            cbCategory.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_category");
            cbType.SelectedIndex = 0;
            this.Search();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("ic_category");
            frm.Text = "จัดการหมวดหมู่";
            frm.ShowDialog();
            cbCategory.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_category");
            if (this.IsAddOrEdit)
            {
                cbCategory.SelectedValue = this.itemAction.CategoryId;
            }
        }

        private void Search(string s = "")
        {
            mainGrid.DataSource = new App.Product.ProductRepository().GetProductList(string.IsNullOrEmpty(s) ? txtSearch.Text : s);
            lblRetCount.Text = "จำนวน " + mainGrid.View.Records.Count + " รายการ";
            if (mainGrid.View.Records.Count > 0)
            {
                mainGrid.Columns[1].MinimumWidth = 600;
            }
            this.itemSelection = new Product();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("ic_unit");
            frm.Text = "จัดการหน่วย";
            frm.ShowDialog();
            cbUnit.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_unit");
            if (this.IsAddOrEdit)
            {
                cbUnit.SelectedValue = this.itemAction.UnitId;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
            }
        }

        private void mainGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Id" ||
                e.Column.MappingName == "Type" ||
                e.Column.MappingName == "UnitId" ||
                e.Column.MappingName == "CategoryId" ||
                e.Column.MappingName == "AverageCost" ||
                e.Column.MappingName == "Description" ||
                e.Column.MappingName == "Barcode"
                )
                e.Cancel = true;

        }

        private void AddOrEdit()
        {
            this.itemAction = this.itemAction ?? new Product { };
            this.IsAddOrEdit = true;
            this.txtDescription.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.itemAction.Id = 0;

            this.txtSearch.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtPurchasePrice.Text = "0.00";
            txtSalePrice.Text = "0.00";
            txtDescription.Text = string.Empty;
            cbCategory.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
        }

        private void Cancel()
        {
            this.IsAddOrEdit = false;
            this.txtDescription.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.itemAction.Id = 0;
            this.txtDescription.Text = string.Empty;
            this.txtSearch.Text = string.Empty;
            this.mainGrid.ClearSelection();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtPurchasePrice.Text = "0.00";
            txtSalePrice.Text = "0.00";
            txtDescription.Text = string.Empty;
            cbCategory.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddOrEdit();
            this.txtProductCode.Text = "P" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            this.AddOrEdit();
            this.itemAction = e.DataRow.RowData as Product;
            txtProductCode.Text = this.itemAction.Code;
            txtDescription.Text = this.itemAction.Description;
            txtProductName.Text = this.itemAction.Name;
            cbUnit.SelectedValue = this.itemAction.UnitId;
            cbCategory.SelectedValue = this.itemAction.CategoryId;
            cbType.SelectedIndex = this.itemAction.Type;
            txtSalePrice.Text = this.itemAction.SalePrice.ToString("N2");
            txtPurchasePrice.Text = this.itemAction.PurchasePrice.ToString("N2");
            txtBarcode.Text = this.itemAction.Barcode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.itemAction.Id == 0)
            {
                var ex = new App.Product.ProductRepository().SaveProduct(
                new Product
                {
                    Description = txtDescription.Text,
                    CategoryId = Convert.ToInt32(cbCategory.SelectedValue),
                    Name = txtProductName.Text,
                    AverageCost = 0,
                    BalanceQty = 0,
                    PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                    Type = cbType.SelectedIndex,
                    UnitId = Convert.ToInt32(cbUnit.SelectedValue),
                    Code = txtProductCode.Text,
                    Barcode = txtBarcode.Text
                });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var ex = new App.Product.ProductRepository().UpdateProduct(
                   new Product
                   {
                       Description = txtDescription.Text,
                       CategoryId = Convert.ToInt32(cbCategory.SelectedValue),
                       Name = txtProductName.Text,
                       AverageCost = 0,
                       BalanceQty = 0,
                       PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                       SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                       Type = cbType.SelectedIndex,
                       UnitId = Convert.ToInt32(cbUnit.SelectedValue),
                       Code = txtProductCode.Text,
                       Barcode = txtBarcode.Text,
                       Id = this.itemAction.Id
                   });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.Search(txtProductCode.Text);
            this.Cancel();
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Search(string.Empty);
        }

        private void mainGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.itemSelection = e.AddedItems[0] as Product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.itemSelection != null)
                if (this.itemSelection.Id > 0)
                {
                    if (MessageBox.Show("คุณต้องการลบข้อมูล " + this.itemSelection.Name + " ใช่หรือไม่?", "คำถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                    {
                        return;
                    }
                    var ex = new App.Product.ProductRepository().DeleteProduct(this.itemSelection.Id);
                    if (ex != null)
                    {
                        MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Cancel();
                    this.Search(this.itemAction.Code);

                }
        }

        private void mainGrid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            try
            {
                this.itemSelection = e.DataRow.RowData as Product;
            }
            catch (Exception)
            {
                 
            }
        }
    }
}

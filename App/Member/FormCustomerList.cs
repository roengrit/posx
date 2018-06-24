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

namespace PosX.App.Member
{
    public partial class FormCustomerList : DockContent
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        private Member itemAction = new Member();
        private Member itemSelection = new Member();

        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainGrid_CurrentCellActivated(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatedEventArgs e)
        {
           
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
            this.Search();
        } 

        private void Search(string s = "")
        {
            mainGrid.DataSource = new App.Member.MemberRepository().GetMemberList(string.IsNullOrEmpty(s) ? txtSearch.Text : s);
            lblRetCount.Text = "จำนวน " + mainGrid.View.Records.Count + " รายการ";
            if (mainGrid.View.Records.Count > 0)
            {
                mainGrid.Columns[1].MinimumWidth = 600;
            }
            this.itemSelection = new Member();
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
            if (e.Column.MappingName == "Id" )
                e.Cancel = true;

        }

        private void AddOrEdit()
        {
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;

            this.itemAction.Id = 0;
            this.mainGrid.ClearSelection();
            this.txtCode.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtTaxId.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtSearch.Text = string.Empty;
            this.txtContact.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFacebook.Text = string.Empty;
            this.txtFax.Text = string.Empty;
            this.txtLine.Text = string.Empty;
            this.txtTel.Text = string.Empty;
        }

        private void Cancel()
        {
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;

            this.itemAction.Id = 0;       
            this.mainGrid.ClearSelection();
            this.txtCode.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtTaxId.Text = string.Empty; 
            this.txtAddress.Text = string.Empty;
            this.txtSearch.Text = string.Empty;
            this.txtContact.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFacebook.Text = string.Empty;
            this.txtFax.Text = string.Empty;
            this.txtLine.Text = string.Empty;
            this.txtTel.Text = string.Empty;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddOrEdit();
            this.txtCode.Text = "C" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            this.AddOrEdit();
            this.itemAction = e.DataRow.RowData as Member;
            this.txtCode.Text = this.itemAction.Code;
            this.txtAddress.Text = this.itemAction.Address;
            this.txtName.Text = this.itemAction.Name;
            this.txtTaxId.Text = this.itemAction.TaxId;
            this.txtFax.Text = this.itemAction.Fax;
            this.txtLine.Text = this.itemAction.Line;
            this.txtContact.Text = this.itemAction.Contact;
            this.txtEmail.Text = this.itemAction.Email;
            this.txtFacebook.Text = this.itemAction.Facebook;
            this.txtTel.Text = this.itemAction.Tel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.itemAction.Id == 0)
            {
                var ex = new App.Member.MemberRepository().SaveMember(new Member
                {
                    Address = txtAddress.Text,
                    Code = txtCode.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    Facebook = txtFacebook.Text,
                    Fax = txtFax.Text,
                    Line = txtLine.Text,
                    Name = txtName.Text,
                    TaxId = txtTaxId.Text,
                    Tel = txtTel.Text
                });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var ex = new App.Member.MemberRepository().UpdateMember(new Member
                {
                    Address = txtAddress.Text,
                    Code = txtCode.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                    Facebook = txtFacebook.Text,
                    Fax = txtFax.Text,
                    Line = txtLine.Text,
                    Name = txtName.Text,
                    TaxId = txtTaxId.Text,
                    Tel = txtTel.Text,
                    Id = itemAction.Id
                });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.Search(txtCode.Text);
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
            this.itemSelection = e.AddedItems[0] as Member;
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
                    var ex = new App.Member.MemberRepository().DeleteMember(this.itemSelection.Id);
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
                this.itemSelection = e.DataRow.RowData as Member;
            }
            catch (Exception)
            {
                 
            }
        }
    }
}

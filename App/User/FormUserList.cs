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

namespace PosX.App.User
{
    public partial class FormUserList : DockContent
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        private User itemAction = new User();
        private User itemSelection = new User();
        private bool IsAddOrEdit;

        public FormUserList()
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
            cbDepartment.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "user_department");
            cbPosition.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "user_position");
            this.Search();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("user_department");
            frm.Text = "จัดการแผนก";
            frm.ShowDialog();
            cbDepartment.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "user_department");
            if (this.IsAddOrEdit)
            {
                cbDepartment.SelectedValue = this.itemAction.DeptId;
            }
        }

        private void Search(string s = "")
        {
            mainGrid.DataSource = new App.User.UserRepository().GetUserList(string.IsNullOrEmpty(s) ? txtSearch.Text : s);
            lblRetCount.Text = "จำนวน " + mainGrid.View.Records.Count + " รายการ";
            if (mainGrid.View.Records.Count > 0)
            {
                mainGrid.Columns[1].MinimumWidth = 600;
            }
            this.itemSelection = new User();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("user_position");
            frm.Text = "จัดการตำแหน่ง";
            frm.ShowDialog();
            cbPosition.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "user_position");
            if (this.IsAddOrEdit)
            {
                cbPosition.SelectedValue = this.itemAction.PosId;
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
                e.Column.MappingName == "PosId" ||
                e.Column.MappingName == "DeptId"  ||
                e.Column.MappingName == "Password"
                )
                e.Cancel = true;

        }

        private void AddOrEdit()
        {
            this.itemAction = this.itemAction ?? new User { };
            this.IsAddOrEdit = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.itemAction.Id = 0;

            this.txtSearch.Text = string.Empty;
            this.mainGrid.ClearSelection();
            txtUserCode.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtTelInCompany.Text = string.Empty;
            cbDepartment.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
        }

        private void Cancel()
        {
            this.IsAddOrEdit = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.itemAction.Id = 0;
            this.txtSearch.Text = string.Empty;
            this.mainGrid.ClearSelection();
            txtUserCode.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtTelInCompany.Text = string.Empty;
            cbDepartment.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddOrEdit();
            this.txtUserCode.Text = "U" + Guid.NewGuid().ToString("N").Substring(0, 5).ToUpper();
        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            this.AddOrEdit();
            this.itemAction = e.DataRow.RowData as User;
            txtUserCode.Text = this.itemAction.Code;
            txtUserName.Text = this.itemAction.Name;
            txtEmail.Text = this.itemAction.Email;
            txtPassword.Text = itemAction.Password;
            txtTel.Text = this.itemAction.Tel;
            txtTelInCompany.Text = this.itemAction.TelInCompany;
            cbPosition.SelectedValue = this.itemAction.PosId;
            cbDepartment.SelectedValue = this.itemAction.DeptId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserCode.Text))
            {
                MessageBox.Show("กรุณาระบุรหัสพนักงาน", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.itemAction.Id == 0)
            {
                var ex = new App.User.UserRepository().SaveUser(
                new User
                {
                    Code = txtUserCode.Text,
                    DeptId = Convert.ToInt32(cbDepartment.SelectedValue),
                    Email = txtEmail.Text,
                    Name = txtUserName.Text,
                    Password = txtPassword.Text,
                    PosId = Convert.ToInt32(cbPosition.SelectedValue),
                    Tel = txtTel.Text,
                    TelInCompany = txtTelInCompany.Text

                });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var ex = new App.User.UserRepository().UpdateUser(
                   new User
                   {
                       Code = txtUserCode.Text,
                       DeptId = Convert.ToInt32(cbDepartment.SelectedValue),
                       Email = txtEmail.Text,
                       Name = txtUserName.Text,
                       Password = txtPassword.Text,
                       PosId = Convert.ToInt32(cbPosition.SelectedValue),
                       Tel = txtTel.Text,
                       TelInCompany = txtTelInCompany.Text,
                       Id = this.itemAction.Id
                   });
                if (ex != null)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.Search(txtUserCode.Text);
            this.Cancel();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Search(string.Empty);
        }

        private void mainGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.itemSelection = e.AddedItems[0] as User;
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
                    var ex = new App.User.UserRepository().DeleteUser(this.itemSelection.Id);
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
                this.itemSelection = e.DataRow.RowData as User;
            }
            catch (Exception)
            {
                 
            }
        }
    }
}

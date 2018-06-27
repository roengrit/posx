using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosX.App.Member
{
    public partial class FormSearchMember : Form
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        public Member itemAction ;
        private Member itemSelection = new Member();

        public FormSearchMember()
        {
            InitializeComponent();
        }

        private void mainGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }

        private void Search(string s = "")
        {
            mainGrid.DataSource = new App.Member.MemberRepository().GetMemberList(string.IsNullOrEmpty(s) ? txtSearch.Text : s);
            lblRetCount.Text = "จำนวน " + mainGrid.View.Records.Count + " รายการ";
            if (mainGrid.View.Records.Count > 0)
            {
                mainGrid.Columns[3].MinimumWidth = 500;
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
            if (e.Column.MappingName == "Id"
                || e.Column.MappingName == "Email"
                || e.Column.MappingName == "Line"
                || e.Column.MappingName == "Facebook"
                || e.Column.MappingName == "Contact"
                )
                e.Cancel = true;

        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            this.itemAction = e.DataRow.RowData as Member;
            //this.txtCode.Text = this.itemAction.Code;
            //this.txtAddress.Text = this.itemAction.Address;
            //this.txtName.Text = this.itemAction.Name;
            //this.txtTaxId.Text = this.itemAction.TaxId;
            //this.txtFax.Text = this.itemAction.Fax;
            //this.txtLine.Text = this.itemAction.Line;
            //this.txtContact.Text = this.itemAction.Contact;
            //this.txtEmail.Text = this.itemAction.Email;
            //this.txtFacebook.Text = this.itemAction.Facebook;
            //this.txtTel.Text = this.itemAction.Tel;
             this.Close();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Search(string.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.itemAction = null;
            this.Close();
        }
    }
}

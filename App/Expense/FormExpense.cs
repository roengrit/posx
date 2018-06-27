using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PosX.App.Expense
{
    public partial class FormExpense : DockContent
    {
        public FormExpense()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            var frm = new App.Member.FormSearchMember();
            frm.ShowDialog();
            if (frm.itemAction != null)
            {
                this.txtCode.Text = frm.itemAction.Code;
                this.txtAddress.Text = frm.itemAction.Address;
                this.txtName.Text = frm.itemAction.Name;
                this.txtTaxId.Text = frm.itemAction.TaxId;
                this.txtFax.Text = frm.itemAction.Fax;
                this.txtTel.Text = frm.itemAction.Tel;
                this.txtBranchNo.Text = frm.itemAction.BranchNo;
                this.txtBranchName.Text = frm.itemAction.BranchName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace PosX
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "POSX : Version " + System.Reflection.Assembly.GetExecutingAssembly()
                                       .GetName()
                                       .Version
                                       .ToString();
            var frm = new PosX.App.FormDashboard();
            frm.Show(dockPanel);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void mProduct_Click(object sender, EventArgs e)
        {
            var frm = new PosX.App.Product.FormProductList();
            frm.Show(dockPanel);
        }

        private void mnCustomer_Click(object sender, EventArgs e)
        {
            var frm = new PosX.App.Member.FormCustomerList();
            frm.Show(dockPanel);  
        }

        private void mnUser_Click(object sender, EventArgs e)
        {
            var frm = new PosX.App.User.FormUserList();
            frm.Show(dockPanel);
        }

        private void mnExpensePurchase_Click(object sender, EventArgs e)
        {
            var frm = new PosX.App.Expense.FormExpense();
            frm.Show(dockPanel);
        }
    }
}

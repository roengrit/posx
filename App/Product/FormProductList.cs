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
        public FormProductList()
        {
            InitializeComponent();
            var orderInfo = new OrderInfoCollection();
            mainGrid.DataSource = orderInfo.OrdersListDetails;
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
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("ic_category");
            frm.Text = "จัดการหมวดหมู่";
            frm.ShowDialog();
            cbCategory.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_category");
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            var frm = new App.Normal.FormNormalMaster("ic_unit");
            frm.Text = "จัดการหน่วย";
            frm.ShowDialog();
            cbUnit.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(string.Empty, "ic_unit");
        }
    }
}

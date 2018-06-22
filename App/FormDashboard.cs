using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PosX.App
{
    public partial class FormDashboard : DockContent
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
        public FormDashboard()
        {
            InitializeComponent();
            var orderInfo = new Product.OrderInfoCollection();
            mainGrid.DataSource = orderInfo.OrdersListDetails;
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void mainGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }
    }
}

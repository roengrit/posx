using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosX.App.Normal
{
    public partial class FormNormalMaster : Form
    {
        public string table { get; set; }
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        public FormNormalMaster(string table)
        {
            this.table = table;
            InitializeComponent();
        }

        private void FormNormalMaster_Load(object sender, EventArgs e)
        {
            this.Search(string.Empty);
        }

        private void Search(string keyword)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList(keyword, this.table);
            mainGrid.ClearFilters();
            mainGrid.View.Filter = FilterRecords;
            mainGrid.View.RefreshFilter();
            lblRetCount.Text = "จำนวน " + mainGrid.RowCount + " รายการ";
        }


        public bool FilterRecords(object o)
        {
            var item = o as NormalMaster;
            if (item != null)
            {
                return !string.IsNullOrEmpty(item.Name);
            }
            return true;
        }

        private void mainGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search(txtSearch.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            var item = e.DataRow;
            var itemVal = e.DataRow.RowData;
        }

        private void mainGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Id")
                e.Cancel = true;
        }
    }
}

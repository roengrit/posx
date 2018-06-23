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
            mainGrid.DataSource = new App.Normal.NormalMasterRepository().GetNormalMasterList("", this.table);
            mainGrid.Columns[0].Visible = false;
            mainGrid.View.Filter = FilterRecords;
            mainGrid.View.RefreshFilter();
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
    }
}

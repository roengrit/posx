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
        public bool IsAddOrEdit { get; set; }
        public NormalMaster itemAction { get; set; }

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
            lblRetCount.Text = "จำนวน " + mainGrid.View.Records.Count + " รายการ";
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
            if (!this.IsAddOrEdit) return;
            if (this.itemAction.Id == 0)
            {
                new App.Normal.NormalMasterRepository().SaveNormalMaster(new NormalMaster { Name = txtDescription.Text }, this.table);
            }
            else
            {
                new App.Normal.NormalMasterRepository().UpdateNormalMaster(new NormalMaster { Name = txtDescription.Text, Id = this.itemAction.Id }, this.table);
            }
            this.Cancel();
            this.Search(txtSearch.Text);
        }

        private void mainGrid_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.Index == 0) return;
            this.AddOrEdit();
            var itemVal = e.DataRow.RowData as NormalMaster;
            this.txtDescription.Text = itemVal.Name;
            this.itemAction.Id = itemVal.Id;
        }

        private void mainGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Id")
                e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddOrEdit();
            this.txtDescription.Text = string.Empty;
        }

        private void AddOrEdit()
        {
            this.itemAction = this.itemAction ?? new NormalMaster { };
            this.IsAddOrEdit = true;
            this.txtSearch.Enabled = false;
            this.txtDescription.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.itemAction.Id = 0;
            this.txtSearch.Text = string.Empty;
        }

        private void Cancel()
        {
            this.IsAddOrEdit = false;
            this.txtSearch.Enabled = true;
            this.txtDescription.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.itemAction.Id = 0;
            this.txtDescription.Text = string.Empty;
            this.txtSearch.Text = string.Empty;
            this.mainGrid.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.itemAction.Id > 0 && !this.IsAddOrEdit)
            {
                if (MessageBox.Show("คุณต้องการลบข้อมูล " + this.itemAction.Name + " ใช่หรือไม่?", "คำถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                {
                    return;
                }
                new App.Normal.NormalMasterRepository().DeleteNormalMaster(this.itemAction.Id, this.table);
                this.Cancel();
                this.Search(txtSearch.Text);

            }
        }

        private void mainGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            var val = e.AddedItems[0] as NormalMaster;
            this.itemAction = this.itemAction ?? new NormalMaster { };
            if (val != null && !this.IsAddOrEdit)
            {
                this.itemAction.Id = val.Id;
                this.itemAction.Name = val.Name;
            }
        }
    }
}

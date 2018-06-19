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
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

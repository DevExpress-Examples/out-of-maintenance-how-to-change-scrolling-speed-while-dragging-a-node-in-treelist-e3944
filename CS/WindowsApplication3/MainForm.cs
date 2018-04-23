using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Handler;


namespace DXSample {
    public partial class MainForm: XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            for (int i = 0; i < 1500; i++)
                treeList1.AppendNode(new object[]{i}, null);
            SetDragScrollInterval();
        }

        private void OnDragScrollSpeadChanged(object sender, EventArgs e)
        {
            SetDragScrollInterval();
        }

        private void SetDragScrollInterval()
        {
            treeList1.DragScrollInterval = trackBarControl1.Value;
        }
    }
}

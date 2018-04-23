using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Handler;

namespace DXSample
{
    public class MyTreeList : TreeList
    {
        public MyTreeList() : base() { }
        public MyTreeList(object ignore) : base(ignore) { }

        protected override DevExpress.XtraTreeList.Handler.TreeListHandler CreateHandler()
        {
            return new MyTreeListHandler(this);
        }

        int _DragScrollInterval = 50;
        public int DragScrollInterval
        {
            get { return _DragScrollInterval; }
            set
            {
                if (_DragScrollInterval != value)
                    _DragScrollInterval = value;
            }
        }
    }

    public class MyTreeListHandler : TreeListHandler
    {
        public MyTreeListHandler(TreeList tree) : base(tree) { }

        protected override TreeListHandler.TreeListControlState CreateState(TreeListState state)
        {
            if (state == TreeListState.NodeDragging)
                return new MyNodeDraggingState(this);
            return base.CreateState(state);
        }
    }

    public class MyNodeDraggingState : TreeListHandler.NodeDraggingState
    {
        public MyNodeDraggingState(TreeListHandler handler) : base(handler) { }

        protected override int DragScrollInterval
        {
            get
            {
                return TreeList.DragScrollInterval;
            }
        }

        new MyTreeList TreeList
        {
            get { return base.TreeList as MyTreeList; }
        }
    }
}

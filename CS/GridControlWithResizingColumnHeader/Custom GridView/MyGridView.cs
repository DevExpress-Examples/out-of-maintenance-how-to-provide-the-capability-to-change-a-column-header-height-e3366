using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GridControlWithFindPanel
{
    public class MyGridView : GridView
    {
        public MyGridView()
            : this(null)
        {
        }

        public MyGridView(GridControl grid)
            : base(grid)
        {
            // put your initialization code here
        }

        protected override string ViewName
        {
            get
            {
                return "MyGridView";
            }
        }

        protected override void EndRowSizing()
        {
            int rowHandle = (int)(Painter.ReSizingObject);
            if (rowHandle > 0)
            {
                GridRowInfo ri = ViewInfo.GetGridRowInfo(rowHandle);
                if (ri == null) return;
                int height = (Painter.CurrentSizerPos - ri.DataBounds.Top) / ViewInfo.RowLineCount;
                if (height > 0)
                    RowHeight = height;
            }
            else
            {
                GridColumnsInfo ci = ViewInfo.ColumnsInfo;
                if (ci == null) return;
                int height = (Painter.CurrentSizerPos - ci.FirstColumnInfo.Bounds.Top) / ViewInfo.RowLineCount;
                if (height > 0)
                    ColumnPanelRowHeight = height;
            }
        }
    }
}
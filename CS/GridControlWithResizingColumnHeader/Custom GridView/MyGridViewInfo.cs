using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace GridControlWithFindPanel
{
    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(GridView gridView)
            : base(gridView)
        {
        }

        GridHitInfo CalcColumnPanelHitInfo(Point pt, GridHitInfo hi)
        {
            GridColumnInfoArgs ci = CalcColumnHitInfo(pt);
            bool bottomEdge;
            bottomEdge = IntInRangeBottom(pt.Y, ci.Bounds.Bottom, ci.Bounds.Bottom - ControlUtils.ColumnResizeEdgeSize);
            if (bottomEdge)
            {
                hi.HitTest = GridHitTest.RowEdge;
            }
            return hi;
        }

        protected bool IntInRangeBottom(int y, int top, int bottom)
        {
            if (bottom < top)
            {
                int temp = top;
                top = bottom;
                bottom = temp;
            }
            return (y >= top && y < bottom);
        }

        protected internal bool CheckHitTest(Rectangle bounds, Point point, GridHitTest hitTest)
        {
            if (GridDrawing.PtInRect(bounds, point))
            {
                return true;
            }
            return false;
        }

        public override GridHitInfo CalcHitInfo(Point pt)
        {
            GridHitInfo hi = base.CalcHitInfo(pt);
            hi.HitPoint = pt;
            if (!IsReady) return hi;
            if (View.OptionsView.ShowColumnHeaders && CheckHitTest(ViewRects.ColumnPanel, pt, GridHitTest.ColumnPanel))
            {
                return CalcColumnPanelHitInfo(pt, hi);
            }
            return hi;
        }
    }
}

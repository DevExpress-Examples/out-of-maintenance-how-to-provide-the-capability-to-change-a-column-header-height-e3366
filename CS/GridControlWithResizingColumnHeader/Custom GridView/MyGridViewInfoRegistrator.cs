using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;

namespace GridControlWithFindPanel
{
    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get
            {
                return "MyGridView";
            }
        }

        public override BaseView CreateView(GridControl grid)
        {
            return new MyGridView(grid as GridControl);
        }

        public override DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new MyGridViewInfo(view as MyGridView);
        }
    }
}

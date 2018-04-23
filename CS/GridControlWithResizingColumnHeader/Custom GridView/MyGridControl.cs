using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;

namespace GridControlWithFindPanel
{
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }
}

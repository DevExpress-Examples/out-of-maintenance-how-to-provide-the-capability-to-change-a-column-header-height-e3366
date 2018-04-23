Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator

Namespace GridControlWithFindPanel
	Public Class MyGridControl
		Inherits GridControl
		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class
End Namespace

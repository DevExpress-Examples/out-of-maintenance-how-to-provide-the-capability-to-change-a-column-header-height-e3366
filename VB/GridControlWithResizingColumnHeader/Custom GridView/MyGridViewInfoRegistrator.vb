Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator

Namespace GridControlWithFindPanel
	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(TryCast(grid, GridControl))
		End Function

		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo
			Return New MyGridViewInfo(TryCast(view, MyGridView))
		End Function
	End Class
End Namespace

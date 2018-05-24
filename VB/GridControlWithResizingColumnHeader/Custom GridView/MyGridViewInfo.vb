Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Drawing
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace GridControlWithFindPanel
    Public Class MyGridViewInfo
        Inherits GridViewInfo

        Public Sub New(ByVal gridView As GridView)
            MyBase.New(gridView)
        End Sub

        Private Function CalcColumnPanelHitInfo(ByVal pt As Point, ByVal hi As GridHitInfo) As GridHitInfo
            Dim ci As GridColumnInfoArgs = CalcColumnHitInfo(pt)
            Dim bottomEdge As Boolean
            bottomEdge = IntInRangeBottom(pt.Y, ci.Bounds.Bottom, ci.Bounds.Bottom - ControlUtils.ColumnResizeEdgeSize)
            If bottomEdge Then
                hi.HitTest = GridHitTest.RowEdge
            End If
            Return hi
        End Function

        Protected Function IntInRangeBottom(ByVal y As Integer, ByVal top As Integer, ByVal bottom As Integer) As Boolean
            If bottom < top Then
                Dim temp As Integer = top
                top = bottom
                bottom = temp
            End If
            Return (y >= top AndAlso y < bottom)
        End Function

        Protected Friend Function CheckHitTest(ByVal bounds As Rectangle, ByVal point As Point, ByVal hitTest As GridHitTest) As Boolean
            If GridDrawing.PtInRect(bounds, point) Then
                Return True
            End If
            Return False
        End Function

        Public Overrides Function CalcHitInfo(ByVal pt As Point, Optional ByVal ignoreData As Boolean = False) As GridHitInfo
            Dim hi As GridHitInfo = MyBase.CalcHitInfo(pt)
            hi.HitPoint = pt
            If Not IsReady Then
                Return hi
            End If
            If View.OptionsView.ShowColumnHeaders AndAlso CheckHitTest(ViewRects.ColumnPanel, pt, GridHitTest.ColumnPanel) Then
                Return CalcColumnPanelHitInfo(pt, hi)
            End If
            Return hi
        End Function
    End Class
End Namespace

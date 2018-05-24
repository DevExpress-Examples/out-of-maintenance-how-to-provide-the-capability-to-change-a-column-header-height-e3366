Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace GridControlWithFindPanel
    Public Class MyGridView
        Inherits GridView

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal grid As GridControl)
            MyBase.New(grid)
            ' put your initialization code here
        End Sub

        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property

        Protected Overrides Sub EndRowSizing()
            Dim rowHandle As Integer = CInt((Painter.ReSizingObject))
            If rowHandle > 0 Then
                Dim ri As GridRowInfo = ViewInfo.GetGridRowInfo(rowHandle)
                If ri Is Nothing Then
                    Return
                End If
                Dim height As Integer = (Painter.CurrentSizerPos - ri.DataBounds.Top) / ViewInfo.RowLineCount
                If height > 0 Then
                    RowHeight = height
                End If
            Else
                Dim ci As GridColumnsInfo = ViewInfo.ColumnsInfo
                If ci Is Nothing Then
                    Return
                End If
                Dim height As Integer = (Painter.CurrentSizerPos - ci.FirstColumnInfo.Bounds.Top) / ViewInfo.RowLineCount
                If height > 0 Then
                    ColumnPanelRowHeight = height
                End If
            End If
        End Sub
    End Class
End Namespace
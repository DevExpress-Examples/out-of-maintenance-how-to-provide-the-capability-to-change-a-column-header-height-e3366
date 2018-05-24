Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace GridControlWithResizingColumnHeader
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim rnd As New Random()
            Dim table As New DataTable()
            table.Columns.Add("Value1")
            table.Columns.Add("Value2")
            Dim i As Integer = 0
            Do While i < rnd.Next(100)
                table.Rows.Add(New Object() { "Custom" & rnd.Next(15), "Address" & rnd.Next(20) })
                i += 1
            Loop
            myGridControl1.DataSource = table
        End Sub
    End Class
End Namespace

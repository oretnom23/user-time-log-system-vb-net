' User Time-In System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Option Explicit On
Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Front_End.MdiParent = Me
        Front_End.StartPosition = FormStartPosition.CenterScreen
        Front_End.Show()
    End Sub

End Class
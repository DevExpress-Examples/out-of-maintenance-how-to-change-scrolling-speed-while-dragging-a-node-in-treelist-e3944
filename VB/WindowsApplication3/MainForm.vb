Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Handler


Namespace DXSample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            For i As Integer = 0 To 1499
                treeList1.AppendNode(New Object() {i}, -1)
            Next i
			SetDragScrollInterval()
		End Sub

		Private Sub OnDragScrollSpeadChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			SetDragScrollInterval()
		End Sub

		Private Sub SetDragScrollInterval()
			treeList1.DragScrollInterval = trackBarControl1.Value
		End Sub
	End Class
End Namespace

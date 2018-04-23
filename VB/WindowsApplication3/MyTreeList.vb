Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Handler

Namespace DXSample
	Public Class MyTreeList
		Inherits TreeList
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal ignore As Object)
			MyBase.New(ignore)
		End Sub

		Protected Overrides Function CreateHandler() As DevExpress.XtraTreeList.Handler.TreeListHandler
			Return New MyTreeListHandler(Me)
		End Function

		Private _DragScrollInterval As Integer = 50
		Public Property DragScrollInterval() As Integer
			Get
				Return _DragScrollInterval
			End Get
			Set(ByVal value As Integer)
				If _DragScrollInterval <> value Then
					_DragScrollInterval = value
				End If
			End Set
		End Property
	End Class

	Public Class MyTreeListHandler
		Inherits TreeListHandler
		Public Sub New(ByVal tree As TreeList)
			MyBase.New(tree)
		End Sub

		Protected Overrides Function CreateState(ByVal state As TreeListState) As TreeListHandler.TreeListControlState
			If state = TreeListState.NodeDragging Then
				Return New MyNodeDraggingState(Me)
			End If
			Return MyBase.CreateState(state)
		End Function
	End Class

	Public Class MyNodeDraggingState
		Inherits TreeListHandler.NodeDraggingState
		Public Sub New(ByVal handler As TreeListHandler)
			MyBase.New(handler)
		End Sub

		Protected Overrides ReadOnly Property DragScrollInterval() As Integer
			Get
				Return TreeList.DragScrollInterval
			End Get
		End Property

		Private Shadows ReadOnly Property TreeList() As MyTreeList
			Get
				Return TryCast(MyBase.TreeList, MyTreeList)
			End Get
		End Property
	End Class
End Namespace

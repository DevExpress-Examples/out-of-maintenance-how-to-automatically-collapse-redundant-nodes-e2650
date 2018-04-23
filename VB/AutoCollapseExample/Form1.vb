Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations

Namespace AutoCollapseExample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnTreeListAfterExpand(ByVal sender As Object, ByVal e As NodeEventArgs) Handles treeList1.AfterExpand
			CType(sender, TreeList).NodesIterator.DoOperation(New AutoCollapseNodeOperation(e.Node))
		End Sub
	End Class

	Public Class AutoCollapseNodeOperation
		Inherits TreeListOperation
		Private fNode As TreeListNode
		Public Sub New(ByVal node As TreeListNode)
			fNode = node
		End Sub
		Public Overrides Sub Execute(ByVal node As TreeListNode)
			If Not(node Is fNode) AndAlso node.Expanded AndAlso (Not node.HasAsParent(fNode)) AndAlso (Not fNode.HasAsParent(node)) Then
				node.Expanded = False
			End If
		End Sub
	End Class
End Namespace
Imports Microsoft.VisualBasic
Imports System
Namespace AutoCollapseExample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "Level 1 A"}, -1)
			Me.treeList1.AppendNode(New Object() { "Level 2 A"}, 0)
			Me.treeList1.AppendNode(New Object() { "Level 3 A"}, 1)
			Me.treeList1.AppendNode(New Object() { "Level 2 B"}, 0)
			Me.treeList1.AppendNode(New Object() { "Level 3 B"}, 3)
			Me.treeList1.AppendNode(New Object() { "Level 1 B"}, -1)
			Me.treeList1.AppendNode(New Object() { "Level 2 C"}, 5)
			Me.treeList1.AppendNode(New Object() { "Level 3 C"}, 6)
			Me.treeList1.AppendNode(New Object() { "Level 2 D"}, 5)
			Me.treeList1.AppendNode(New Object() { "Level 3 D"}, 8)
			Me.treeList1.AppendNode(New Object() { "Level 1 C"}, -1)
			Me.treeList1.AppendNode(New Object() { "Level 2 E"}, 10)
			Me.treeList1.AppendNode(New Object() { "Level 3 E"}, 11)
			Me.treeList1.AppendNode(New Object() { "Level 2 F"}, 10)
			Me.treeList1.AppendNode(New Object() { "Level 3 F"}, 13)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.Size = New System.Drawing.Size(401, 268)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.AfterExpand += New DevExpress.XtraTreeList.NodeEventHandler(Me.OnTreeListAfterExpand);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 56
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(401, 268)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "MainForm"
			Me.Text = "Dx Sample"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace


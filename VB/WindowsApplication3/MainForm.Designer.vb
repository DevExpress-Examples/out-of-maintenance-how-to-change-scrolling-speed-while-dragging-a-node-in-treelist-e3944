Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.treeList1 = New DXSample.MyTreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.DragScrollInterval = 50
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.DragNodes = True
			Me.treeList1.Size = New System.Drawing.Size(484, 319)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Number"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.trackBarControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 319)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(484, 40)
			Me.panelControl1.TabIndex = 1
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.trackBarControl1.EditValue = 10
			Me.trackBarControl1.Location = New System.Drawing.Point(3, 3)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.LargeChange = 10
			Me.trackBarControl1.Properties.Maximum = 100
			Me.trackBarControl1.Properties.Minimum = 10
			Me.trackBarControl1.Properties.ShowValueToolTip = True
			Me.trackBarControl1.Properties.SmallChange = 10
			Me.trackBarControl1.Properties.TickFrequency = 10
			Me.trackBarControl1.Size = New System.Drawing.Size(478, 34)
			Me.trackBarControl1.TabIndex = 0
			Me.trackBarControl1.Value = 10
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.OnDragScrollSpeadChanged);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(484, 359)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "MainForm"
			Me.Text = "How To Change TreeList Scroll Spead"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private treeList1 As MyTreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
	End Class
End Namespace


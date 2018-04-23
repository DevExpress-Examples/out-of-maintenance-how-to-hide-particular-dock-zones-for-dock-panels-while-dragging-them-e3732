Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Main
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
			Me.dockManager1 = New WindowsApplication3.MyDockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			Me.dockPanel3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010"
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1, Me.dockPanel2, Me.dockPanel3})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))))
			Me.dockPanel1.Appearance.Options.UseBackColor = True
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.dockPanel1.FloatLocation = New System.Drawing.Point(108, 226)
			Me.dockPanel1.ID = New System.Guid("0005ebbc-7cd1-4941-a50a-0402620c370f")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.Options.AllowDockBottom = False
			Me.dockPanel1.Options.AllowDockRight = False
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Text = "Left Top"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 24)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 172)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))))
			Me.dockPanel2.Appearance.Options.UseBackColor = True
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.dockPanel2.FloatLocation = New System.Drawing.Point(222, 317)
			Me.dockPanel2.ID = New System.Guid("1c2ebe60-d67b-4455-80e9-5c1467a05234")
			Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.Options.AllowDockBottom = False
			Me.dockPanel2.Options.AllowDockFill = False
			Me.dockPanel2.Options.AllowDockLeft = False
			Me.dockPanel2.Options.AllowDockRight = False
			Me.dockPanel2.Options.AllowDockTop = False
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel2.Size = New System.Drawing.Size(200, 200)
			Me.dockPanel2.Text = "Float"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 24)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(192, 172)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' dockPanel3
			' 
			Me.dockPanel3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))))
			Me.dockPanel3.Appearance.Options.UseBackColor = True
			Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
			Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
			Me.dockPanel3.FloatLocation = New System.Drawing.Point(284, 250)
			Me.dockPanel3.FloatSize = New System.Drawing.Size(200, 189)
			Me.dockPanel3.ID = New System.Guid("811f9785-6dcb-4a62-b981-5fee3ae52c5d")
			Me.dockPanel3.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel3.Name = "dockPanel3"
			Me.dockPanel3.Options.AllowDockLeft = False
			Me.dockPanel3.Options.AllowDockTop = False
			Me.dockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel3.Size = New System.Drawing.Size(200, 189)
			Me.dockPanel3.Text = "Bottom Right"
			' 
			' dockPanel3_Container
			' 
			Me.dockPanel3_Container.Location = New System.Drawing.Point(4, 24)
			Me.dockPanel3_Container.Name = "dockPanel3_Container"
			Me.dockPanel3_Container.Size = New System.Drawing.Size(192, 161)
			Me.dockPanel3_Container.TabIndex = 0
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(410, 357)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "How to hide dock zones"
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			Me.dockPanel3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockManager1 As MyDockManager
	End Class
End Namespace


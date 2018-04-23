Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Docking
Imports System.Windows.Forms
Imports System.ComponentModel

Namespace WindowsApplication3
	Public Class MyDockManager
		Inherits DockManager
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal form As ContainerControl)
			MyBase.New(form)
		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub

		Protected Overrides Function CreateVisualizer(ByVal role As VisualizerRole) As VS2005StyleDockingVisualizer
			If (Not SupportVS2010DockingStyle()) Then
				Return New MyVS2005StyleDockingVisualizer(role, DockModeVS2005FadeSpeed, DockModeVS2005FadeFramesCount, Me)
			End If
			Return MyBase.CreateVisualizer(role)
		End Function
	End Class

	Public Class MyVS2005StyleDockingVisualizer
		Inherits VS2005StyleDockingVisualizer
		Private manager As DockManager
		Public Sub New(ByVal role As VisualizerRole, ByVal fadeSpeed As Integer, ByVal framesCount As Integer, ByVal manager As DockManager)
			MyBase.New(role, fadeSpeed, framesCount)
			Me.manager = manager
		End Sub

		Protected Overrides Sub UpdateWindows()
			Dim panel As DockPanel = manager.ActivePanel
			If panel.Options.AllowDockBottom Then
				SetBoundsVisibility(GetFrame(VisualizerFormType.Bottom), Me.viewInfoCore(VisualizerFormType.Bottom))
			End If
			If panel.Options.AllowDockFill Then
				SetBoundsVisibility(GetFrame(VisualizerFormType.Center), Me.viewInfoCore(VisualizerFormType.Center))
			End If
			If panel.Options.AllowDockLeft Then
				SetBoundsVisibility(GetFrame(VisualizerFormType.Left), Me.viewInfoCore(VisualizerFormType.Left))
			End If
			If panel.Options.AllowDockRight Then
				SetBoundsVisibility(GetFrame(VisualizerFormType.Right), Me.viewInfoCore(VisualizerFormType.Right))
			End If
			If panel.Options.AllowDockTop Then
				SetBoundsVisibility(GetFrame(VisualizerFormType.Top), Me.viewInfoCore(VisualizerFormType.Top))
			End If
		End Sub
	End Class
End Namespace

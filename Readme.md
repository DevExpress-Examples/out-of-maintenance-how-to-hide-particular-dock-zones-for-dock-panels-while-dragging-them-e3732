<!-- default file list -->
*Files to look at*:

* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [MyDockManager.cs](./CS/WindowsApplication3/MyDockManager.cs) (VB: [MyDockManager.vb](./VB/WindowsApplication3/MyDockManager.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to hide particular dock zones for dock panels while dragging them


<p>When dragging a dock panel, corresponding dock zones are shown to indicate possible places for docking the panel. For instance, if the panel cannot be docked at all ( <strong>DockPanel.Option.AllowDock</strong>~ properties are set to false), it would be useful to hide a default center dock zone while dragging this panel. This example illustrates how to accomplish this task by creating a<strong> custom DockManager</strong>.</p><br />


<br/>



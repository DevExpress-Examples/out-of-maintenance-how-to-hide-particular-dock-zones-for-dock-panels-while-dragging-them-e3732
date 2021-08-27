<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616979/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3732)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [MyDockManager.cs](./CS/WindowsApplication3/MyDockManager.cs) (VB: [MyDockManager.vb](./VB/WindowsApplication3/MyDockManager.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to hide particular dock zones for dock panels while dragging them


<p>When dragging a dock panel, corresponding dock zones are shown to indicate possible places for docking the panel. For instance, if the panel cannot be docked at all ( <strong>DockPanel.Option.AllowDock</strong>~ properties are set to false), it would be useful to hide a default center dock zone while dragging this panel. This example illustrates how to accomplish this task by creating a<strong> custom DockManager</strong>.</p><br />


<br/>



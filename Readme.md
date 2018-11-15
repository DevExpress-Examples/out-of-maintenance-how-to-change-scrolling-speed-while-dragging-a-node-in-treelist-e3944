<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/WindowsApplication3/MainForm.cs) (VB: [MainForm.vb](./VB/WindowsApplication3/MainForm.vb))
* [MyTreeList.cs](./CS/WindowsApplication3/MyTreeList.cs) (VB: [MyTreeList.vb](./VB/WindowsApplication3/MyTreeList.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to change scrolling speed while dragging a node in TreeList


<p>Sometimes, when TreeList contains a lot of data, it is useful to increase the scrolling speed while dragging a node in TreeList. Imagine that you have 1000 nodes and you need to drag the last node to the first node. By default, data is scrolled through 50 ms during the drag operation. To manage this parameter, you need to create a TreeList descendant as shown in this example. </p><p>In this sample, we created the <strong>TreeList.DragScrollInterval pro</strong><strong>perty</strong>, so you can change this option as required. </p>

<br/>



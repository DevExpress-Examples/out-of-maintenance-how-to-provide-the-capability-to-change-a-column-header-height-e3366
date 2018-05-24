# How to provide the capability to change a column header height


<p>This example demonstrates how to create a custom GridView with the capability to change a column header height by dragging its bottom edge. More information about creating a custom GridView can be found at:<br />
<a href="https://www.devexpress.com/Support/Center/p/A859">How to create a GridView descendant class and register it for design-time use</a></p><p><br />
</p>


<h3>Description</h3>

The signature of the GridViewInfo's CalcHitInfo method changed<br><br>public override GridHitInfo CalcHitInfo(Point pt, bool ignoreData = false){<br>//..<br>}

<br/>



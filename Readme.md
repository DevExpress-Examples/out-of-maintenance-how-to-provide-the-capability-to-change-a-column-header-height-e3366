<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630977/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3366)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to provide the capability to change a column header height


<p>This example demonstrates how to create a custom GridView with the capability to change a column header height by dragging its bottom edge. More information about creating a custom GridView can be found at:<br />
<a href="https://www.devexpress.com/Support/Center/p/A859">How to create a GridView descendant class and register it for design-time use</a></p><p><br />
</p>


<h3>Description</h3>

The signature of the GridViewInfo's CalcHitInfo method changed<br><br>public override GridHitInfo CalcHitInfo(Point pt, bool ignoreData = false){<br>//..<br>}

<br/>



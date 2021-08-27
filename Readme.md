<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552950/14.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T152893)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs)
* **[_CallbackPanelPartial.cshtml](./CS/DXWebApplication1/Views/Home/_CallbackPanelPartial.cshtml)**
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)
<!-- default file list end -->
# MVC Splitter - Saving the client layout of the control after every modification by a user
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t152893/)**
<!-- run online end -->


<p>This example demonstrates how to preserve the MVC Splitter layout when an end-user expands, collapses or resizes its panes. <br /><br /></p>
<p>The Splitter extension is placed inside the CallbackPanel extension. In order to save its layout after a modification, you are required to handle corresponding client-side events and pass layout data to the server. This data is retrieved by using the <a href="http://help.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientSplitter_GetLayoutDatatopic">ASPxClientSplitter.GetLayoutData</a> method and passed as a parameter via the <a href="http://help.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientCallbackPanel_PerformCallbacktopic">MVCxClientCallbackPanel.PerformCallback</a> method to the server side to the corresponding Controller Action method. Then the client layout data is applied to Splitter in the <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.SplitterSettings.ClientLayout">SplitterSettings.ClientLayout</a>  event handler.</p>
server event.<br /><br /><strong>See Also:<br /><a href="https://www.devexpress.com/Support/Center/p/E3960">E3960: How to save ASPxSplitter's client-side layout after every modification of the control by an end-user</a><br /></strong>

<br/>



<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))**
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# ASPxGridLookup - How to implement the multiple selection DropDownWindow scenario


<p>This example demonstrates how to use the ASPxGridLookup to select multiple values from a dropdown grid containing lookup items. The ASPxGridLookup is bound with the custom DataItem defined within the "LookUpDataItem" type (contains row field).</p>
<p>The embedded ASPxGridView component is pre-customized as the ASPxListBox:</p>
<p>- The ASPxGridView's Header is hidden;</p>
<p>- The ASPxGridView's Pager is used for splitting DataItems within multiple pages to improve the client-side performance.</p>
<p><br /> The embedded ASPxGridView's sever-side "CustomJSProperties" event is attached by handling the ASPxGridLookup's Init event. To get a reference to the embedded ASPxGridView, use the ASPxGridLookup.GridView property.</p>
<p>The embedded ASPxGridView's client-side "SelectionChanged" event is attached by handling the ASPxGridLookup's Init event, via the ASPxGridLookup.GridView.ClientSideEvents.SelectionChanged property.</p>
<p><br /><strong>UPDATED:</strong><br /><br />Starting with version v2014 vol 1 (v14.1), the "Select All" functionality is available out of the box:<br /><a href="https://www.devexpress.com/Support/Center/p/S173621">S173621: ASPxGridView - Add the built-in SelectAll CheckBox for Command Column</a><br /><br />Simply set the <strong>GridViewCommandColumn.SelectAllCheckboxMode</strong> property to <strong>GridViewSelectAllCheckBoxMode.AllPages</strong> to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/05/28/asp-net-gridview-select-all-rows-updated-coming-soon-in-v14-1.aspx">ASP.NET: GridView Select All Rows Updated</a> blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Selection/AdvancedSelection.aspx">Select All Rows</a> demo for more information.<br /><br /><strong>OBSOLETE:</strong><br /><br /> For the "Select All" functionality, instructions from the <a href="https://www.devexpress.com/Support/Center/p/K18253">ASPxGridView - How to implement SelectRows and SelectAllRowsOnPage CheckBox features</a> KB Article is used.</p>
<p>For the "partial selection" functionality, newly implemented ASPxCheckBox rendering (<a href="http://community.devexpress.com/blogs/aspnet/archive/2011/04/26/asp-net-check-box-new-render-state-for-multiple-controls-coming-soon-in-2011-volume-1.aspx"><u>ASP.NET Check Box - New Render State For Multiple Controls (available now in v2011.1)</u></a>) is used.</p>

<br/>



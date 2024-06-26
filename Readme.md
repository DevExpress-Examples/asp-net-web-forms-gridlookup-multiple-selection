<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128530889/14.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3467)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Grid Lookup for ASP.NET Web Forms - How to enable multiple selection

This example demonstrates how to create a command column and enable multiple selection mode.

![Selection mode](selectionMode.png)

## Overview

Follow the steps below to enable multiple selection in a grid control:

1. Enable a command column's [ShowSelectCheckbox](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewCommandColumn.ShowSelectCheckbox) property and set the [SelectAllCheckboxMode](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewCommandColumn.SelectAllCheckboxMode) property to `AllPages` to select and deselect all records on all grid pages.

2. Set the grid's [SelectionMode](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridLookup.SelectionMode) property to `Miltiple`.

```aspx
<dx:ASPxGridLookup ID="gridLookup" runat="server" SelectionMode="Multiple" ...>
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="AllPages" />
        <!-- ... -->
    </Columns>
    <!-- ... -->
</dx:ASPxGridLookup>
```

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [Grid Selection](https://docs.devexpress.com/AspNet/3737/components/grid-view/concepts/focus-and-navigation/selection)
* [Selection Modes](https://docs.devexpress.com/AspNet/9075/components/grid-view/concepts/aspxgridlookup/selection-modes)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-gridlookup-multiple-selection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-gridlookup-multiple-selection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

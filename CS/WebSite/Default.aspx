<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="mainForm" runat="server">
    <div>
        <dx:ASPxGridLookup ID="gridLookup" runat="server" ClientInstanceName="lookup" KeyFieldName="ID"
            SelectionMode="Multiple" OnInit="gridLookup_Init" Width="183px">
            <Columns>
                <dx:GridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="AllPages" Width="20px">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataColumn FieldName="Text">
                    <HeaderTemplate>(Select All)</HeaderTemplate>
                    <Settings AllowSort="False" />
                </dx:GridViewDataColumn>
            </Columns>
            <GridViewProperties>
                <SettingsPager NumericButtonCount="5">
                    <Summary Visible="false" />
                </SettingsPager>
            </GridViewProperties>
        </dx:ASPxGridLookup>
    </div>
    </form>
</body>
</html>

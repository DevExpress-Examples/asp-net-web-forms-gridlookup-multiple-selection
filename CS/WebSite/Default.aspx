<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridLookup" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function OnCheckedChanged(s, e) {
            var gv = lookup.GetGridView();
            if (s.GetChecked())
                gv.SelectRows();
            else
                gv.UnselectRows();
        }
        function OnGridViewSelectionChanged(s, e) {
            var selectedRowCount = s.GetSelectedRowCount();
            if (selectedRowCount == s.cpVisibleRowCount)
                cb.SetChecked(true);
            else if (selectedRowCount > 0)
                cb.SetCheckState(ASPxClientCheckBoxCheckState.Indeterminate);
            else
                cb.SetChecked(false);
        }
    </script>
</head>
<body>
    <form id="mainForm" runat="server">
    <div>
        <dx:ASPxGridLookup ID="gridLookup" runat="server" ClientInstanceName="lookup" KeyFieldName="ID"
            SelectionMode="Multiple" OnInit="gridLookup_Init" Width="183px">
            <Columns>
                <dx:GridViewCommandColumn ShowSelectCheckbox="True" Width="20px">
                    <HeaderTemplate>
                        <dx:ASPxCheckBox ID="checkBoxSelectAll" runat="server" AllowGrayed="true" AllowGrayedByClick="false"
                            ClientInstanceName="cb" OnInit="checkBoxSelectAll_Init">
                            <ClientSideEvents CheckedChanged="OnCheckedChanged" />
                        </dx:ASPxCheckBox>
                    </HeaderTemplate>
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

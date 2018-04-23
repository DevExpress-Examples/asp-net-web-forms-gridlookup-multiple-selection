using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridLookup;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;

public partial class _Default : System.Web.UI.Page {
    private const int DataItemsCount = 200;

    protected void gridLookup_Init(object sender, EventArgs e) {
        ASPxGridLookup gl = (ASPxGridLookup)sender;

        ASPxGridView gv = gl.GridView;
        gv.CustomJSProperties += new ASPxGridViewClientJSPropertiesEventHandler(gv_CustomJSProperties);
        gv.ClientSideEvents.SelectionChanged = "OnGridViewSelectionChanged";

        gl.DataSource = CreateDataSource();
        gl.DataBind();
    }

    void gv_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        ASPxGridView gv = (ASPxGridView)sender;
        e.Properties["cpVisibleRowCount"] = gv.VisibleRowCount;
    }

    protected void checkBoxSelectAll_Init(object sender, EventArgs e) {
        ASPxCheckBox cb = (ASPxCheckBox)sender;

        ASPxGridView gv = (cb.NamingContainer as GridViewHeaderTemplateContainer).Grid;

        if (gv.Selection.Count == gv.VisibleRowCount)
            cb.Checked = true;
        else if (gv.Selection.Count > 0)
            cb.CheckState = DevExpress.Web.ASPxClasses.CheckState.Indeterminate;
        else
            cb.Checked = false;
    }

    private List<LookUpDataItem> CreateDataSource() {
        List<LookUpDataItem> dataSource = new List<LookUpDataItem>();

        for (int i = 0; i < DataItemsCount; i++) {
            dataSource.Add(new LookUpDataItem() {
                ID = i,
                Text = "Text - " + i.ToString()
            });
        }

        return dataSource;
    }
}
public class LookUpDataItem {
    public int ID { get; set; }
    public string Text { get; set; }
}
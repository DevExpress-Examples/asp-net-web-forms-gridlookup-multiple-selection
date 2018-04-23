using System;
using System.Collections.Generic;
using DevExpress.Web.ASPxGridLookup;

public partial class _Default : System.Web.UI.Page {
    private const int DataItemsCount = 200;

    protected void gridLookup_Init(object sender, EventArgs e) {
        ASPxGridLookup gl = (ASPxGridLookup)sender;

        gl.DataSource = CreateDataSource();
        gl.DataBind();
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
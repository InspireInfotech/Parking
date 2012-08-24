using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ConfirmOrder : System.Web.UI.Page
{
    int OrderID = default(int);
    DataTable dt = null;
    decimal total = default(decimal);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["OrderID"] != null)
            {
                int.TryParse(Request.QueryString["OrderID"], out OrderID);
                lblOrderID.Text = Convert.ToString(OrderID);
                BindParkingDet();
            }
        }
    }
    private void BindParkingDet()
    {
        if (OrderID==0)
            return;
        dt = Constants.sessionVaribles.DtParking;
        rptLevels.DataSource = dt;
        rptLevels.DataBind();
        Session.Abandon();
        Session.Clear();
       
    }
    protected void rptLevels_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblPSlotPrice = e.Item.FindControl("lblPSlotPrice") as Label;
            total += Convert.ToDecimal(lblPSlotPrice.Text);
        }
        if (e.Item.ItemType == ListItemType.Footer)
        {
            Label lblPrice = e.Item.FindControl("lblPrice") as Label;
            lblPrice.Text = Convert.ToString(total);
        }

    }
}

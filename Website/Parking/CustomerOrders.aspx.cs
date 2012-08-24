using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CustomerOrders : System.Web.UI.Page
{
    DataTable dt = null;
    int userID = default(int);
    decimal total = default(decimal);
   
    protected void Page_Load(object sender, EventArgs e)
    {
        userID = Constants.sessionVaribles.UserID;
        if (userID == 0)
            Response.Redirect("registration.aspx", false);
        if (!IsPostBack)
            BindParkingDet();
       
    }
    private void BindParkingDet()
    {
        
        dt = Constants.sessionVaribles.DtParking;
        rptLevels.DataSource = DAL.GetParkingOrderDet(userID);
        rptLevels.DataBind();
        Session.Remove("DtParking");
        

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

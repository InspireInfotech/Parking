using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Orders : System.Web.UI.Page
{
    int userID = default(int);
    DataTable dt = null;
    int AutoID = default(int);
    decimal total = default(int);
    int parkingID = default(int);
    int parkingAvailID = default(int);
    int orderID = default(int);
    int levelID = default(int);
    int buildingID = default(int);
    int towerID = default(int);
    protected void Page_Load(object sender, EventArgs e)
    {
        userID = Constants.sessionVaribles.UserID;
        if (userID == 0)
            Response.Redirect("registration.aspx", false);

        if (!IsPostBack)
        { BindParkingDet(); }
    }
    protected void lnkbDeleteButton_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int.TryParse(e.CommandArgument.ToString(), out AutoID);
            if (AutoID > 0)
            {
                dt = Constants.sessionVaribles.DtParking;
                if (dt.Rows.Contains(AutoID))
                    dt.Rows.Find(AutoID).Delete();
                dt.AcceptChanges();
                Constants.sessionVaribles.DtParking = dt;
                BindParkingDet();
            }
        }
    }
    private void BindParkingDet()
    {
        if (Constants.sessionVaribles.DtParking == null)
            return;
        dt = Constants.sessionVaribles.DtParking;
        rptLevels.DataSource = dt;
        rptLevels.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string parkingIds = string.Empty;
        Label lblDateFrom = new Label();
        Label lblToDate = new Label();
        foreach (RepeaterItem item in rptLevels.Items)
        {
            Label lblBuilding = item.FindControl("lblBuilding") as Label;
            Label lablTower = item.FindControl("lablTower") as Label;
            Label lblLevel = item.FindControl("lblLevel") as Label;
            Label lblParkingID = item.FindControl("lblParkingID") as Label;

            HiddenField hdfBuildingID = item.FindControl("hdfBuildingID") as HiddenField;
            HiddenField hdfTowerID = item.FindControl("hdfTowerID") as HiddenField;
            HiddenField hdfLevelID = item.FindControl("hdfLevelID") as HiddenField;
            int.TryParse(hdfBuildingID.Value, out buildingID);
            int.TryParse(hdfTowerID.Value, out towerID);
            
         
      

            lblDateFrom = item.FindControl("lblDateFrom") as Label;
            lblToDate = item.FindControl("lblToDate") as Label;
            int.TryParse(lblParkingID.Text, out parkingID);
            parkingIds += parkingID + " ,";

        }
        Label lblPrice = rptLevels.Controls[rptLevels.Controls.Count - 1].Controls[0].FindControl("lblPrice") as Label;
        parkingAvailID = DAL.InsertParkingAvailabiltyDet(buildingID,towerID,parkingIds, Convert.ToDateTime(lblDateFrom.Text.Trim()), Convert.ToDateTime(lblToDate.Text.Trim()));
        if (parkingAvailID > 0)
        {
            orderID = DAL.InsertOrderDet(parkingAvailID, userID, Convert.ToDecimal(lblPrice.Text));
            Response.Redirect("ConfirmOrder.aspx?OrderID=" + orderID, false);
        }
     

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

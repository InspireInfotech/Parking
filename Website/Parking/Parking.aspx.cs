using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Parking : System.Web.UI.Page
{
    int userID = default(int);
    int levelID = default(int);
    int buildingID = default(int);
    int towerID = default(int);
    int parkingID = default(int);
    string buildingName = string.Empty;
    string towerName = string.Empty;
    decimal Price = default(decimal);
    DataTable dt = null;
    int parkingAvailID = default(int);
    protected void Page_Load(object sender, EventArgs e)
    {
       
        userID = Constants.sessionVaribles.UserID;

        if (userID == 0)
        {
            Response.Redirect("registration.aspx", false);
        }
        if (Constants.sessionVaribles.BuildingID != null)
            int.TryParse(Constants.sessionVaribles.BuildingID.ToString(), out buildingID);
        if (Constants.sessionVaribles.TowerID != null)
            int.TryParse(Constants.sessionVaribles.TowerID.ToString(), out towerID);
        if (Constants.sessionVaribles.BuildingName != null)
            buildingName = Constants.sessionVaribles.BuildingName;
        if (Constants.sessionVaribles.TowerName != null)
            towerName = Constants.sessionVaribles.TowerName;
        if (Request.QueryString["LevelID"] != null)
        {
            int.TryParse(Request.QueryString["LevelID"], out levelID);
        }
      
        if (!IsPostBack)
        {
            if (levelID > 0)
                BindParkingSlots();
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:s");
            txtDate1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:s");
        }
        CheckParkingAvail();

    }

    private void BindParkingSlots()
    {
        ParkingList lst = DAL.GetParkingSlotsByLevelID(levelID);
        chkParkingSlots.DataTextField = "ParkingName";
        chkParkingSlots.DataValueField = "ParkingID";
        chkParkingSlots.DataSource = lst;
        chkParkingSlots.DataBind();
    }

    public DataTable CreateTable()
    {
        if (Constants.sessionVaribles.DtParking == null)
            dt = new DataTable();
        else
            dt = Constants.sessionVaribles.DtParking;

        DataColumn dc = new DataColumn();
        if (Constants.sessionVaribles.DtParking == null)
        {
            dt.Columns.Add("AutoID", typeof(Int32));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["AutoID"] };
            dt.Columns["AutoID"].AutoIncrement = true;
            dt.Columns["AutoID"].AutoIncrementSeed = 1;
            dt.Columns["AutoID"].AutoIncrementStep = 1;
            dt.Columns["AutoID"].Unique = true;
            dt.Columns.Add("BuildingID", System.Type.GetType("System.String"));
            dt.Columns.Add("BuildName", System.Type.GetType("System.String"));
            dt.Columns.Add("TowerID", System.Type.GetType("System.String"));
            dt.Columns.Add("TowerName", System.Type.GetType("System.String"));
            dt.Columns.Add("LevelID", System.Type.GetType("System.String"));
            dt.Columns.Add("LevelName", System.Type.GetType("System.String"));
            dt.Columns.Add("ParkingID", System.Type.GetType("System.String"));
            dt.Columns.Add("Price", System.Type.GetType("System.String"));
            dt.Columns.Add("FromDate", System.Type.GetType("System.String"));
            dt.Columns.Add("ToDate", System.Type.GetType("System.String"));
        }
        return dt;
    }

    private decimal GetPrice(int towerID)
    {

        switch (towerID)
        {
            case 1:
                Price = 20;
                break;
            case 2:
                Price = 10;
                break;
            case 3:
                Price = 7;
                break;
            case 4:
                Price = 5;
                break;
        }
        return Price;
    }

    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        dt = CreateTable();
        foreach (ListItem lst in chkParkingSlots.Items)
        {
            if (lst.Selected && lst.Enabled)
            {
                DataRow dataRow = dt.NewRow();
                int.TryParse(lst.Text, out parkingID);
                if (dt.Rows.Count > 0)
                {
                    dataRow["BuildingID"] = buildingID;
                    dataRow["BuildName"] = buildingName;
                    dataRow["TowerID"] = towerID;
                    dataRow["TowerName"] = towerName;
                    dataRow["LevelID"] = levelID;
                    dataRow["ParkingID"] = parkingID;
                    dataRow["Price"] = GetPrice(towerID);
                    dataRow["FromDate"] = txtDate.Text.Trim(); ;
                    dataRow["ToDate"] = txtDate1.Text.Trim();

                }
                if (dt.Rows.Count == 0)
                {
                    dataRow["BuildingID"] = buildingID;
                    dataRow["BuildName"] = buildingName;
                    dataRow["TowerID"] = towerID;
                    dataRow["TowerName"] = towerName;
                    dataRow["LevelID"] = levelID;
                    dataRow["ParkingID"] = parkingID;
                    dataRow["Price"] = GetPrice(towerID);
                    dataRow["FromDate"] = txtDate.Text.Trim();
                    dataRow["ToDate"] = txtDate1.Text.Trim();
                }

                dt.Rows.Add(dataRow);
                Constants.sessionVaribles.DtParking = dt;
            }
        }
        Response.Redirect("Orders.aspx", false);
    }

    private void CheckParkingAvail()
    {
        userID = default(int);
        string PRKIDs = string.Empty; ;

        ListOrders lstOrd = DAL.GetParkingOrderDet(userID);
       
            foreach (OrderBO ObjOrd in lstOrd)
            {
                PRKIDs = ObjOrd.ParkingIDs;
                
                    string[] PIDS = PRKIDs.Split(',');
                    foreach (ListItem lst in chkParkingSlots.Items)
                    {

                        foreach (string PID in PIDS)
                        {
                            if (lst.Text == PID.Trim() && DateTime.Now <= ObjOrd.ToDateTime)
                            {
                                lst.Selected = true;
                                lst.Enabled = false;
                            }
                        }
                    }
              
        }
    }
}

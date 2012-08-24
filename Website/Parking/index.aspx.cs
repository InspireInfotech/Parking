using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    int buildingID = default(int);
    int towerID = default(int);
    string buildingName = string.Empty;
    string towerName = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindBuildings();
            BindTowers();
        }
    }

    private void BindBuildings()
    {
        ddlBuildings.DataTextField = "BuildingName";
        ddlBuildings.DataValueField = "BuildingId";
        ddlBuildings.DataSource=DAL.GetBuldings();
        ddlBuildings.DataBind();
    }

    private void BindTowers()
    {
        ddlTowers.DataTextField = "TowerName";
        ddlTowers.DataValueField = "TowerID";
        ddlTowers.DataSource = DAL.GetTowers();
        ddlTowers.DataBind();
    }
    protected void ddlTowers_SelectedIndexChanged(object sender, EventArgs e)
    {
        int.TryParse(ddlBuildings.SelectedValue, out buildingID);
        int.TryParse(ddlTowers.SelectedValue, out towerID);
        buildingName = ddlBuildings.SelectedItem.Text;
        towerName = ddlTowers.SelectedItem.Text;
        Constants.sessionVaribles.BuildingName = buildingName;
        Constants.sessionVaribles.TowerName = towerName;
        Constants.sessionVaribles.BuildingID = buildingID;
        Constants.sessionVaribles.TowerID = towerID;

        rptLevels.DataSource = DAL.GetLevels();
        rptLevels.DataBind();
    }
}

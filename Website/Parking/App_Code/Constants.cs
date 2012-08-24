using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.SessionState;
using System.Data;
/// <summary>
/// Summary description for Constants
/// </summary>
public class Constants
{
    public string DBConn = ConfigurationManager.AppSettings["DBConnection"].ToString();

    public class sessionVaribles
    {
        private int Userid;
        public static int UserID
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["UserID"]); }
            set { HttpContext.Current.Session["UserID"] = value; }
        }

        private string FullName;
        public static string Fullname
        { 
            get { return Convert.ToString(HttpContext.Current.Session["Name"]); }
            set { HttpContext.Current.Session["Name"] = value; }
        }
        private string buildingName;
        public static string BuildingName
        {
            get { return Convert.ToString(HttpContext.Current.Session["BuildingName"]); }
            set { HttpContext.Current.Session["BuildingName"] = value; }
        }
        private int buildingID;
        public static int BuildingID
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["BuildingID"]); }
            set { HttpContext.Current.Session["BuildingID"] = value; }
        }
        private string towerName;
        public static string TowerName
        {
            get { return Convert.ToString(HttpContext.Current.Session["TowerName"]); }
            set { HttpContext.Current.Session["TowerName"] = value; }
        }
        private int towerID;
        public static int TowerID
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["TowerID"]); }
            set { HttpContext.Current.Session["TowerID"] = value; }
        }

        private int prkOrderID;
        public static int PrkOrderID
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["PrkOrderID"]); }
            set { HttpContext.Current.Session["PrkOrderID"] = value; }
        }

        private DataTable dtParking;
        public static DataTable DtParking
        {
            get { return (DataTable)HttpContext.Current.Session["DtParking"]; }
            set { HttpContext.Current.Session["DtParking"] = value; }
        }


    }

    public class Proc
    {
        public const string USP_REG_INSERT_CUSTOMERDET = "usp_Reg_Insert_CustomerDet";
        public const string USP_GET_CATEGORIES = "uspGetCategories";
        public const string USP_GET_LOCATIONS_BY_CATEGORYIDANDAVAILDTTIME = "uspGetLocationsByCategoryIDAndAvailDtTime";
        public const string USP_GET_LOCATIONS_BY_CATEGORYID = "uspGetLocationsByCategoryID";
        public const string USP_CHEK_LOGINDETAIALS = "uspChekLoginDetaials";
        public const string USP_INSERT_ORDERS = "usp_Insert_Orders";
        public const string USP_GET_REGDETAILSBYUSERID = "usp_Get_RegDetailsByUserID";
        public const string USP_REG_UPDATE_CUSTOMERDET = "usp_Reg_Update_CustomerDet";

        public const string USP_GET_BUILDINGS = "usp_Get_Buildings";
        public const string USP_GET_LEVELS = "usp_Get_Levels";
        public const string USP_GET_TOWERS = "usp_Get_Towers";
        public const string USP_GET_PARKINGSLOTSBYLEVELID = "usp_Get_ParkingSlotsByLevelID";
        public const string USP_INS_PARKINGAVAILDET = "usp_Ins_ParkingAvailDet";

        public const string USP_GET_ORDERDETAILS = "usp_Get_OrderDetails";

        public const string USP_INS_PARKINGORDERDET = "usp_Ins_ParkingOrderDet";
    }
}

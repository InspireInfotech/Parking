using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    public static int InsertCustomerDet(CustomerBO ObjCus)
    {
        int CusID = default(int);
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_REG_INSERT_CUSTOMERDET, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = ObjCus.FirstName;
                Cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = ObjCus.LastName;
                Cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = ObjCus.Email;
                Cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = ObjCus.Password;
                Cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = ObjCus.Phone;
                Cmd.Parameters.AddWithValue("@Fax", SqlDbType.VarChar).Value = ObjCus.Fax;
                Cmd.Parameters.AddWithValue("@BillingAddress1", SqlDbType.VarChar).Value = ObjCus.BillingAddress1;
                if (!string.IsNullOrEmpty(ObjCus.BillingAddress2))
                    Cmd.Parameters.AddWithValue("@BillingAddress2", SqlDbType.VarChar).Value = ObjCus.BillingAddress2;
                Cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = ObjCus.Country;
                Cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = ObjCus.City;
                Cmd.Parameters.AddWithValue("@State", SqlDbType.VarChar).Value = ObjCus.State;
                Cmd.Parameters.AddWithValue("@ZipCode", SqlDbType.VarChar).Value = ObjCus.ZipCode;
                Cmd.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;
                Conn.Open();

                Cmd.ExecuteNonQuery();
                CusID = Convert.ToInt32(Cmd.Parameters["@CustomerID"].Value);
            }
        }
        return CusID;
    }

    public static void UpdateCustomerRegDet(CustomerBO ObjCus)
    {
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_REG_UPDATE_CUSTOMERDET, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = ObjCus.CustomerID;
                Cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = ObjCus.FirstName;
                Cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = ObjCus.LastName;
                Cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = ObjCus.Email;
                Cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = ObjCus.Password;
                Cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = ObjCus.Phone;
                Cmd.Parameters.AddWithValue("@Fax", SqlDbType.VarChar).Value = ObjCus.Fax;
                Cmd.Parameters.AddWithValue("@BillingAddress1", SqlDbType.VarChar).Value = ObjCus.BillingAddress1;
                if (!string.IsNullOrEmpty(ObjCus.BillingAddress2))
                    Cmd.Parameters.AddWithValue("@BillingAddress2", SqlDbType.VarChar).Value = ObjCus.BillingAddress2;
                Cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = ObjCus.Country;
                Cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = ObjCus.City;
                Cmd.Parameters.AddWithValue("@State", SqlDbType.VarChar).Value = ObjCus.State;
                Cmd.Parameters.AddWithValue("@ZipCode", SqlDbType.VarChar).Value = ObjCus.ZipCode;

                Conn.Open();

                Cmd.ExecuteNonQuery();

            }
        }
    }

    public static LocationList GetCategories()
    {
        LocationList lstCat = new LocationList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_CATEGORIES, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        LocationsBO ObjCat = new LocationsBO();
                        ObjCat.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        ObjCat.CategoryName = Convert.ToString(dr["CategoryName"]);
                        lstCat.Add(ObjCat);
                    }

                }
            }
        }
        return lstCat;

    }

    public static LocationList GetLocationsByCatID(int CategoryID)
    {
        LocationList lstCat = new LocationList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_LOCATIONS_BY_CATEGORYID, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        LocationsBO ObjCat = new LocationsBO();
                        ObjCat.LocationID = Convert.ToInt32(dr["LocationID"]);
                        ObjCat.LocationName = Convert.ToString(dr["LocationName"]);
                        lstCat.Add(ObjCat);
                    }

                }
            }
        }
        return lstCat;

    }

    public static LocationList GetLocations(int LocationID, DateTime AvailabiltyDateTime)
    {
        LocationList lstCat = new LocationList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_LOCATIONS_BY_CATEGORYIDANDAVAILDTTIME, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@LocationID", SqlDbType.Int).Value = LocationID;
                // Cmd.Parameters.Add("@AvailabilityDate", SqlDbType.DateTime).Value = AvailabiltyDateTime;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        LocationsBO ObjCat = new LocationsBO();

                        ObjCat.CatLocationID = Convert.ToInt32(dr["CatLocationID"]);
                        ObjCat.LocationID = Convert.ToInt32(dr["LocationID"]);
                        ObjCat.LocationName = Convert.ToString(dr["LocationName"]);
                        ObjCat.Price = Convert.ToDecimal(dr["Price"]);
                        ObjCat.Tax = Convert.ToDecimal(dr["tax"]);
                        ObjCat.ParkType = Convert.ToString(dr["ParkType"]);
                        ObjCat.ParkTypeID = Convert.ToInt32(dr["ParkTypeID"]);
                        ObjCat.Description = Convert.ToString(dr["Description"]);
                        lstCat.Add(ObjCat);
                    }

                }
            }
        }
        return lstCat;

    }

    public static CustomerBO CheckUserCredentials(CustomerBO ObjCus)
    {
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_CHEK_LOGINDETAIALS, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = ObjCus.Email;
                Cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = ObjCus.Password;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ObjCus.CustomerID = Convert.ToInt32(dr["UserID"]);
                        ObjCus.FirstName = Convert.ToString(dr["FullName"]);
                        ObjCus.Password = Convert.ToString(dr["Password"]);
                    }
                }
            }
        }
        return ObjCus;
    }

    //public static void InsertOrders(OrderBO ObjOrd)
    //{

    //    using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
    //    {
    //        using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_INSERT_ORDERS, Conn))
    //        {
    //            Cmd.CommandType = CommandType.StoredProcedure;
    //            Cmd.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = ObjOrd.UserID;
    //            Cmd.Parameters.AddWithValue("@CatLocationID", SqlDbType.Int).Value = ObjOrd.CatLocationID;
    //            Cmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = ObjOrd.Price;
    //            Conn.Open();
    //            Cmd.ExecuteNonQuery();

    //        }
    //    }

    //}

    public static CustomerBO GetUserDetailsByUserID(int UserID)
    {
        CustomerBO ObjCus = null;
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_REGDETAILSBYUSERID, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ObjCus = new CustomerBO();
                        ObjCus.FirstName = Convert.ToString(dr["FirstName"]);
                        ObjCus.LastName = Convert.ToString(dr["LastName"]);
                        ObjCus.Email = Convert.ToString(dr["Email"]);
                        ObjCus.Password = Convert.ToString(dr["Password"]);
                        ObjCus.Phone = Convert.ToString(dr["Phone"]);
                        ObjCus.Fax = Convert.ToString(dr["Fax"]);
                        ObjCus.BillingAddress1 = Convert.ToString(dr["BillingAddress1"]);
                        ObjCus.BillingAddress2 = dr["BillingAddress2"] == DBNull.Value ? string.Empty : Convert.ToString(dr["BillingAddress2"]);
                        ObjCus.Country = Convert.ToString(dr["Country"]);
                        ObjCus.City = Convert.ToString(dr["City"]);
                        ObjCus.State = Convert.ToString(dr["State"]);
                        ObjCus.ZipCode = Convert.ToString(dr["ZipCode"]);

                    }

                }
            }
        }
        return ObjCus;

    }

    public static ParkingList GetBuldings()
    {
        ParkingList lst = new ParkingList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_BUILDINGS, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ParkingBO Obj = new ParkingBO();
                        Obj.BuildingId = Convert.ToInt32(dr["BuildingID"]);
                        Obj.BuildingName = Convert.ToString(dr["BuildingName"]);
                        lst.Add(Obj);
                    }

                }
            }
        }
        return lst;

    }

    public static ParkingList GetTowers()
    {
        ParkingList lst = new ParkingList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_TOWERS, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ParkingBO Obj = new ParkingBO();
                        Obj.TowerID = Convert.ToInt32(dr["TowerID"]);
                        Obj.TowerName = Convert.ToString(dr["TowerName"]);
                        lst.Add(Obj);
                    }

                }
            }
        }
        return lst;

    }

    public static ParkingList GetLevels()
    {
        ParkingList lst = new ParkingList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_LEVELS, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ParkingBO Obj = new ParkingBO();
                        Obj.LevelID = Convert.ToInt32(dr["LevelID"]);
                        Obj.LevelName = Convert.ToString(dr["LevelName"]);
                        Obj.LevelDesc = Convert.ToString(dr["LevelDesc"]);
                        lst.Add(Obj);
                    }

                }
            }
        }
        return lst;

    }

    public static ParkingList GetParkingSlotsByLevelID(int levelID)
    {
        ParkingList lst = new ParkingList();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_PARKINGSLOTSBYLEVELID, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@LevelID", SqlDbType.Int).Value = levelID;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ParkingBO Obj = new ParkingBO();
                        Obj.ParkingID = Convert.ToInt32(dr["ParkingID"]);
                        Obj.ParkingName = Convert.ToString(dr["ParkingName"]);
                        Obj.LevelID = Convert.ToInt32(dr["LevelID"]);
                        lst.Add(Obj);
                    }

                }
            }
        }
        return lst;

    }

    public static int InsertParkingAvailabiltyDet(int buildingID,int towerID,string parkingIDs, DateTime DateFrm, DateTime DateTo)
    {
        int prkAvailabilityID = default(int);
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_INS_PARKINGAVAILDET, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@BuildingID", SqlDbType.Int).Value = buildingID;
                Cmd.Parameters.Add("@TowerID", SqlDbType.Int).Value = towerID;
                //Cmd.Parameters.Add("@LevelID", SqlDbType.Int).Value = levelID;
                Cmd.Parameters.Add("@ParkingIDs", SqlDbType.VarChar).Value = parkingIDs;
                Cmd.Parameters.Add("@DateTimeFrom", SqlDbType.DateTime).Value = DateFrm;
                Cmd.Parameters.Add("@DateTimeTo", SqlDbType.DateTime).Value = DateTo;
                Cmd.Parameters.Add("@ParkingAvailID", SqlDbType.Int).Direction= ParameterDirection.Output;
                Conn.Open();
                Cmd.ExecuteReader();
                prkAvailabilityID = Convert.ToInt32(Cmd.Parameters["@ParkingAvailID"].Value);

            }
        }
        return prkAvailabilityID;
    }

    public static int InsertOrderDet(int parkingAvailID, int UserID, decimal TotalPrice)
    {
        int OrderID = default(int);
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_INS_PARKINGORDERDET, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@ParkingAvailID", SqlDbType.Int).Value = parkingAvailID;
                Cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                Cmd.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = TotalPrice;
                Cmd.Parameters.Add("@OrderID", SqlDbType.Int).Direction = ParameterDirection.Output;
                Conn.Open();
                Cmd.ExecuteReader();
                OrderID = Convert.ToInt32(Cmd.Parameters["@OrderID"].Value);

            }
        }
        return OrderID;
    }

    public static ListOrders GetParkingOrderDet(int userID)
    {
        ListOrders lst = new ListOrders();
        using (SqlConnection Conn = new SqlConnection("server=SURESHJALAJA-PC;database=Parking;uid=sa;password=suresh;"))
        {
            using (SqlCommand Cmd = new SqlCommand(Constants.Proc.USP_GET_ORDERDETAILS, Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                Conn.Open();
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        OrderBO Obj = new OrderBO();
                        Obj.OrderID = Convert.ToInt32(dr["OrderID"]);
                        Obj.FullName = Convert.ToString(dr["FullName"]);
                        Obj.ParkingAvalabilityID = Convert.ToInt32(dr["ParkingAvalabilityID"]);
                        Obj.UserID = Convert.ToInt32(dr["UserID"]);
                        Obj.Price = Convert.ToDecimal(dr["Price"]);
                        Obj.ParkingIDs = Convert.ToString(dr["ParkingIDs"]);
                        Obj.FromDateTime = dr["DateTimeFrom"]!=DBNull.Value? Convert.ToDateTime(dr["DateTimeFrom"]):DateTime.MinValue;
                        Obj.ToDateTime = dr["DateTimeTo"] != DBNull.Value ? Convert.ToDateTime(dr["DateTimeTo"]) : DateTime.MinValue;
                        Obj.BuildingName = Convert.ToString(dr["BuildingName"]);
                        Obj.TowerName = Convert.ToString(dr["TowerName"]);
                       
                        lst.Add(Obj);
                    }

                }
            }
        }
        return lst;

    }
}


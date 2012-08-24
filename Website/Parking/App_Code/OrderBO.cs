using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderBO
/// </summary>
public class OrderBO
{
    public int OrderID { get; set; }

    public int UserID { get; set; }

    public int ParkingAvalabilityID { get; set; }

    public decimal Price { get; set; }

    public string FullName { get; set; }

    public string ParkingIDs { get; set; }

    public DateTime ToDateTime { get; set; }

    public DateTime FromDateTime { get; set; }

    public string BuildingName { get; set; }

    public string TowerName { get; set; }

    public string LevelName { get; set; }
}

public class ListOrders : List<OrderBO>
{ 

}

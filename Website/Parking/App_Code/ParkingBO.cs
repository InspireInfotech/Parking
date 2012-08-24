using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ParkingBO
/// </summary>
public class ParkingBO
{
    public int BuildingId { get; set; }

    public string BuildingName { get; set; }

    public int LevelID { get; set; }

    public string LevelName{ get; set; }

    public string LevelDesc { get; set; }

    public int TowerID { get; set; }

    public string TowerName { get; set; }

    public int ParkingID { get; set; }

    public string ParkingName { get; set; }

}
public class ParkingList : List<ParkingBO>
{

}

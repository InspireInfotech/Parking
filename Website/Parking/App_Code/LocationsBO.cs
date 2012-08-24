using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LocationsBO
/// </summary>
public class LocationsBO
{
    public int CategoryID { get; set; }

    public int LocationID { get; set; }

    public string CategoryName { get; set; }

    public string LocationName { get; set; }

    public DateTime AvalabilityDateTime { get; set; }

    public Decimal Price { get; set; }

    public Decimal Tax { get; set; }
    
    public string ParkType { get; set; }

    public int ParkTypeID { get; set; }

    public string Description { get; set; }

    public int CatLocationID { get; set; }

}
public class LocationList : List<LocationsBO>
{

}
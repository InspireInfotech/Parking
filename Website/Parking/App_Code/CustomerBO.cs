using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerBO
/// </summary>
public class CustomerBO
{
    public int CustomerID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string BillingAddress1 { get; set; }

    public string BillingAddress2 { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }
}
public class CustomerList : List<CustomerBO>
{ 

}


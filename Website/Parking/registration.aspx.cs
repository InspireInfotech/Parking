using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration : System.Web.UI.Page
{
    private int cusID = default(int);


    protected void Page_Load(object sender, EventArgs e)
    {
        cusID = Constants.sessionVaribles.UserID;
        ltHeading.Text = "Create Account";
        if (cusID > 0)
        {
            ltHeading.Text = "Update Account";
            btnSubmit.Text = "Update";
        }
        if (!IsPostBack)
        {
            BindRegDeatils();
        }
    }

    private void BindRegDeatils()
    {
        CustomerBO ObjCus = DAL.GetUserDetailsByUserID(cusID);
        if (ObjCus != null)
        {
            txtFirstName.Text = ObjCus.FirstName;
            txtLastName.Text = ObjCus.LastName;
            txtEmailID.Text = ObjCus.Email;
            txtPSW.Text = ObjCus.Password;
            if (txtPSW.TextMode == TextBoxMode.Password)
            {
                txtPSW.Attributes.Add("value", txtPSW.Text);
            }
            txtConfirmfPSW.Text = ObjCus.Password;
            if (txtConfirmfPSW.TextMode == TextBoxMode.Password)
            {
                txtConfirmfPSW.Attributes.Add("value", txtConfirmfPSW.Text);
            }
            txtPhone.Text = ObjCus.Phone;
            txtFax.Text = ObjCus.Fax;
            txtBillAdd1.Text = ObjCus.BillingAddress1;
            if (!string.IsNullOrEmpty(ObjCus.BillingAddress2))
                txtBillAdd2.Text = ObjCus.BillingAddress2;
            txtCountry.Text = ObjCus.Country;
            txtCity.Text = ObjCus.City;
            txtState.Text = ObjCus.State;
            txtZipCode.Text = ObjCus.ZipCode;
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CustomerBO ObjCus = new CustomerBO();
        ObjCus.FirstName = txtFirstName.Text.Trim();
        ObjCus.LastName = txtLastName.Text.Trim();
        ObjCus.Email = txtEmailID.Text.Trim();
        ObjCus.Password = txtPSW.Text;
        ObjCus.Phone = txtPhone.Text.Trim();
        ObjCus.Fax = txtFax.Text.Trim();
        ObjCus.BillingAddress1 = txtBillAdd1.Text.Trim();
        if (!string.IsNullOrEmpty(txtBillAdd2.Text))
            ObjCus.BillingAddress2 = txtBillAdd2.Text.Trim();
        ObjCus.Country = txtCountry.Text.Trim();
        ObjCus.City = txtCity.Text.Trim();
        ObjCus.State = txtState.Text.Trim();
        ObjCus.ZipCode = txtZipCode.Text.Trim();
        if (cusID > 0)
        {
            ObjCus.CustomerID = cusID;
            DAL.UpdateCustomerRegDet(ObjCus);
            ltMess.Text = "Updated Sunccessfully";
        }
        else
        {
            cusID = DAL.InsertCustomerDet(ObjCus);
            ltMess.Text = "Inserted Sunccessfully";
            Constants.sessionVaribles.UserID = cusID;
        }
        ClearHistory();
    }

    private void ClearHistory()
    {
        txtFirstName.Text = txtLastName.Text = txtEmailID.Text = txtPSW.Text = txtConfirmfPSW.Text = txtPhone.Text = txtFax.Text = txtBillAdd1.Text = txtBillAdd2.Text = txtCountry.Text = txtCity.Text = txtState.Text = txtZipCode.Text = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Common : System.Web.UI.MasterPage
{
    int userID = default(int);
    protected void Page_Load(object sender, EventArgs e)
    {
        userID = Constants.sessionVaribles.UserID;
        ltUserName.Text = Constants.sessionVaribles.Fullname;
        if (userID > 0)
        {
            liEditAcc.Visible = true;
            liCreateAcc.Visible = false;
        }
        else
        {
            liEditAcc.Visible = false;
            liCreateAcc.Visible = true;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        CustomerBO ObjCus = new CustomerBO();
        ObjCus.Email = txtUsername.Text.Trim();
        ObjCus.Password = txtPassword.Text.Trim();
        ObjCus = DAL.CheckUserCredentials(ObjCus);
        if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
        {
            if (ObjCus != null&& ObjCus.CustomerID>0)
            {
                Constants.sessionVaribles.UserID = ObjCus.CustomerID;
                txtUsername.Text = string.Empty;
                ltUserName.Text = string.Empty;
                Constants.sessionVaribles.Fullname = ObjCus.FirstName;
                ltUserName.Text = ObjCus.FirstName;
                liEditAcc.Visible = true;
                liCreateAcc.Visible = false;
                ltMsg.Text=string.Empty;
            }
            else
            {

                ltMsg.Text = "Invalied Username";
            }
        }
        else
        { ltMsg.Text = "Enter Username and password"; }

    }
}

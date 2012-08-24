<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="registration.aspx.cs" Inherits="registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function Validations() {

            var objFName = $('#<%=txtFirstName.ClientID %>')
            if (objFName.val() == "") {
                alert("Please Enter First Name");
                objFName.focus();
                return false
            }
            var objLName = $('#<%=txtLastName.ClientID %>')
            if (objLName.val() == "") {
                alert("Please Enter Last Name");
                objLName.focus()
                return false
            }

            var objEmailID = $('#<%=txtEmailID.ClientID %>')
            if (objEmailID.val() == "") {
                alert("Please Enter EmailID");
                objEmailID.focus();
                return false
            }
            var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
            if (!filter.test(objEmailID.val())) {
                alert("Please Enter Valied EmailID");
                objEmailID.focus();
                return false;
            }

            var objPSW = $('#<%=txtPSW.ClientID %>')
            var objConfirmfPSW = $('#<%=txtConfirmfPSW.ClientID %>')

            if (objPSW.val() == "") {
                alert("Please Enter Password");
                objPSW.focus();
                return false
            }
            if (objConfirmfPSW.val() == "") {
                alert("Please Enter Confirm Password");
                objConfirmfPSW.focus();
                return false
            }
            if (objPSW.val() != objConfirmfPSW.val()) {
                alert("Please enter the same password as above");
                objConfirmfPSW.focus();
                return false
            }
            var objPhone = $('#<%=txtPhone.ClientID %>')
            if (objPhone.val() == "") {
                alert("Please provide phone number");
                objPhone.focus();
                return false
            }
            var objFax = $('#<%=txtFax.ClientID %>')
            if (objFax.val() == "") {
                alert("Please provide fax number");
                objFax.focus();
                return false
            }
            var objZipCode = $('#<%=txtZipCode.ClientID %>')
            if (objZipCode.val() == "") {
                alert("Please provide zip code");
                objZipCode.focus();
                return false
            }
            var objBillAdd1 = $('#<%=txtBillAdd1.ClientID %>')
            if (objBillAdd1.val() == "") {
                alert("Please provide billing address 1 ");
                objBillAdd1.focus();
                return false
            }
            var objCountry = $('#<%=txtCountry.ClientID %>')
            if (objCountry.val() == "") {
                alert("Please Enter Country");
                objCountry.focus();
                return false
            }
            var objCity = $('#<%=txtCity.ClientID %>')
            if (objCity.val() == "") {
                alert("Please Enter City");
                objCity.focus();
                return false
            }
            var objState = $('#<%=txtState.ClientID %>')
            if (objState.val() == "") {
                alert("Please Enter State");
                objState.focus();
                return false
            }
            return true;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <table width="80%" border="0" cellspacing="4" cellpadding="0">
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Literal ID="ltHeading" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td  colspan="3">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Literal ID="ltMess" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td width="42%" align="right">
                            *&nbsp;&nbsp; First Name
                        </td>
                        <td width="4%" align="center">
                        </td>
                        <td width="54%" align="left">
                            <asp:TextBox ID="txtFirstName" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *&nbsp;&nbsp;&nbsp; Last Name
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *&nbsp; Email ID
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtEmailID" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            * Password
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtPSW" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            * Confirm Password
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtConfirmfPSW" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            * Phone
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtPhone" runat="server" MaxLength="15"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *Fax
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtFax" runat="server" MaxLength="15"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            * Billing Address 1
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtBillAdd1" runat="server" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            Billing Address 2
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtBillAdd2" MaxLength="200" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *Country
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCountry" MaxLength="20" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *City
                        </td>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCity" MaxLength="20" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *State
                        </td>
                        <td align="center">
                            &nbsp;
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtState" MaxLength="20" runat="server"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            *Zip Code
                        </td>
                        <td align="center">
                            &nbsp;
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtZipCode" MaxLength="20" runat="server"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td align="center">
                            &nbsp;
                        </td>
                        <td align="left">
                            &nbsp;
                            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" OnClientClick="return Validations();"
                                Text="Submit" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 149px;
        }
        .style3
        {
            width: 418px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td width="100">
            </td>
            <td width="80%">
                <asp:Repeater ID="rptLevels" runat="server" OnItemDataBound="rptLevels_ItemDataBound">
                    <HeaderTemplate>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <%-- <td width="23%" valign="top">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td align="center">
                                            <asp:Image ID="imgLocation" runat="server" Width="150px" Height="100px" ImageUrl="~/images/images.jpg" />
                                        </td>
                                    </tr>e
                                </table>
                            </td>--%>
                            <td width="77%" valign="top">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="66%" valign="top">
                                            <table>
                                                <tr>
                                                    <td width="374" align="left">
                                                        Building :
                                                        <asp:Label ID="lblBuilding" runat="server" Text='<%#Eval("BuildName")%>'></asp:Label>
                                                        <asp:HiddenField ID="hdfBuildingID" runat="server" Value='<%#Eval("BuildingID")%>' />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                        Tower
                                                        <asp:Label ID="lablTower" runat="server" Text='<%#Eval("TowerName")%>'></asp:Label>
                                                        <asp:HiddenField ID="hdfTowerID" runat="server" Value='<%#Eval("TowerID")%>' />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                        Level:
                                                        <asp:Label ID="lblLevel" runat="server" Text='<%#Convert.ToString(Eval("LevelID"))=="1"?"Level 1":"Level 2"%>'></asp:Label>
                                                                       <asp:HiddenField ID="hdfLevelID" runat="server" Value='<%#Eval("LevelID")%>' />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                        Parking Slot:
                                                        <asp:Label ID="lblParkingID" runat="server" Text='<%#Eval("ParkingID")%>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                        Parking Slot Booked from :
                                                        <asp:Label ID="lblDateFrom" runat="server" Text='<%#Eval("FromDate")%>'></asp:Label>
                                                        To :
                                                        <asp:Label ID="lblToDate" runat="server" Text='<%#Eval("ToDate")%>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td width="34%" rowspan="3">
                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                <tr>
                                                    <td>
                                                        $
                                                        <asp:Label ID="lblPSlotPrice" runat="server" Text='<%#Eval("Price") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="20px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:LinkButton ID="lnkbDeleteButton" runat="server" CausesValidation="False" CommandName="delete"
                                                            Text="Delete" OnCommand="lnkbDeleteButton_Command" CommandArgument='<%#Eval("AutoID") %>'
                                                            OnClientClick="return confirm('Are you certain you want to delete this parking slot?');"></asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="20px" colspan="2">
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr>
                            <td align="right" style="padding-right: 40px;">
                                Total : $
                                <asp:Label ID="lblPrice" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
            <td width="100">
            </td>
        </tr>
        <tr>
            <td height="20px" colspan="3">
                <asp:Button ID="btnSubmit" runat="server" Text="Confirm Checkout" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

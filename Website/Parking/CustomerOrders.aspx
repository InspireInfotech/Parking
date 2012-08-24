<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="CustomerOrders.aspx.cs" Inherits="CustomerOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" cellspacing="0" cellpadding="0">
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td width="50%" align="center">
                <table>
                    <tr>
                        <td>
                            <table width="100%" cellpadding="0" cellspacing="0" border="1">
                                <tr>
                                    <td>
                                        <asp:Repeater ID="rptLevels" runat="server" OnItemDataBound="rptLevels_ItemDataBound">
                                            <HeaderTemplate>
                                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td width="77%" valign="top">
                                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                            <tr>
                                                                <td width="66%" valign="top">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="374" align="left">
                                                                                Building :
                                                                                <asp:Label ID="lblBuilding" runat="server" Text='<%#Eval("BuildingName")%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left">
                                                                                Tower
                                                                                <asp:Label ID="lablTower" runat="server" Text='<%#Eval("TowerName")%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left">
                                                                                Level:
                                                                                <asp:Label ID="lblLevel" runat="server" Text='<%#Convert.ToString(Eval("LevelName"))=="1"?"Level 1":"Level 2"%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left">
                                                                                Parking Slot:
                                                                                <asp:Label ID="lblParkingID" runat="server" Text='<%#Eval("ParkingIDs")%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left">
                                                                                Parking Slot Booked from :
                                                                                <asp:Label ID="lblDateFrom" runat="server" Text='<%#Eval("FromDateTime")%>'></asp:Label>
                                                                                To :
                                                                                <asp:Label ID="lblToDate" runat="server" Text='<%#Eval("ToDateTime")%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                                <td width="34%" rowspan="3">
                                                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                                        <tr>
                                                                            <td width="374" align="left">
                                                                                OrderID :
                                                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("OrderID")%>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                &nbsp;
                                                                            </td>
                                                                        </tr>
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
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

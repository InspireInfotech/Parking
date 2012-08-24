<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" dir="ltr" lang="en-EN">
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />

	<title>DateTimePicker</title>
</head>
<body>
	 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                            <tr>
                                                                <td width="66%" valign="top">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="374" align="left">
                                                                                Building :
                                                                                <asp:Label ID="lblBuilding" runat="server" Text='<%#Eval("BuildName")%>'></asp:Label>
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
                                                                                <asp:Label ID="lblLevel" runat="server" Text='<%#Convert.ToString(Eval("LevelID"))=="1"?"Level 1":"Level 2"%>'></asp:Label>
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
</body>
</html>

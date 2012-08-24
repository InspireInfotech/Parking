<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="Parking.aspx.cs" Inherits="Parking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">



    <script src="DateTimePicker/jquery_ui_datepicker.js" type="text/javascript"></script>
    <script type="text/javascript">
        /* <![CDATA[ */
        $(function() {
        $('#<%=txtDate.ClientID %>').datetime({
                userLang: 'en',
                americanMode: true
            });
        });
        $(function() {
            $('#<%=txtDate1.ClientID %>').datetime({
                userLang: 'en',
                americanMode: true
            });
        });
       
        
        /* ]]> */
    </script>

    <script src="DateTimePicker/ui.datepicker-de.js" type="text/javascript"></script>

    <script src="DateTimePicker/timepicker.js" type="text/javascript"></script>

    <script src="DateTimePicker/ui.datepicker-de.js" type="text/javascript"></script>

    <script src="DateTimePicker/timepicker.js" type="text/javascript"></script>

    <link rel="stylesheet" type="text/css" href="DateTimePicker/style.css" />
    <link rel="stylesheet" type="text/css" href="DateTimePicker/jquery_ui_datepicker.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" cellpadding="0" cellspacing="0">
        <tr>
            <td height="20">
            </td>
        </tr>
        <tr>
            <td height="20">
                <asp:TextBox ID="txtDate" runat="server" Text="2012-08-17 12:05:00"></asp:TextBox>
                <br />
                 <asp:TextBox ID="txtDate1" runat="server" Text="2012-08-17 12:05:00"></asp:TextBox>
                
            </td>
           
            
        </tr>
        <tr>
            <td align="center">
                <table width="100%">
                    <tr>
                        <td width="50%" align="center">
                            <asp:CheckBoxList ID="chkParkingSlots" runat="server" Width="725px" RepeatDirection="Horizontal"
                                RepeatColumns="2" RepeatLayout="Flow" CellSpacing="4">
                            </asp:CheckBoxList>
                            <%--<tr>
                                <td>
                                    <asp:CheckBox ID="chk1271" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1272" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1273" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1274" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1275" runat="server" Visible="false" />                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1276" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1277" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1278" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1279" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1280" runat="server" Visible="false" />
                                </td>
                            </tr>--%>
                            <%--<tr>
                                <td>
                                    <asp:CheckBox ID="chk1281" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1282" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1283" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1284" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1285" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1286" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1287" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1288" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1289" runat="server" Visible="false" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="chk1290" runat="server" Visible="false" />
                                </td>
                            </tr>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnCheckOut" runat="server" Text="CheckOut" OnClick="btnCheckOut_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

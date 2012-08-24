<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 171px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td valign="top">
                <table>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlBuildings" runat="server" AppendDataBoundItems="True" Width="150px">
                                <asp:ListItem Value="0">Buildings</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td height="10">
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:DropDownList ID="ddlTowers" runat="server" AppendDataBoundItems="True" Width="150px"
                                AutoPostBack="True" OnSelectedIndexChanged="ddlTowers_SelectedIndexChanged">
                                <asp:ListItem Value="0">Towers</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Repeater ID="rptLevels" runat="server">
                    <HeaderTemplate>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td width="23%" valign="top">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td align="center">
                                            <asp:Image ID="imgLocation" runat="server" Width="150px" Height="100px" ImageUrl="~/images/images.jpg" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="lblLocationName" runat="server" Text='<%#Eval("LevelName")%>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="77%" valign="top">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="66%" valign="top">
                                            <table>
                                                <tr>
                                                    <td width="374" align="left">
                                                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("LevelDesc")%>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                        <a href="#">More..</a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left">
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td width="34%" rowspan="3">
                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                <tr>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="20px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
<a href='Parking.aspx?LevelID=<%# Eval("LevelID")%>'>select</a>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</asp:Content>

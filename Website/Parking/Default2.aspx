<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="JavaScripts/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="DateTimePicker/jquery_ui_datepicker.js" type="text/javascript"></script>

    <script type="text/javascript">
        /* <![CDATA[ */
        $(function() {
            $('#<%=pickerfield.ClientID %>').datetime({
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
    <asp:TextBox ID="pickerfield" runat="server" Text="2012-08-17 12:05:00" ></asp:TextBox>
</asp:Content>

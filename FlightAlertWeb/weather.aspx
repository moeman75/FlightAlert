<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weather.aspx.cs" Inherits="FlightAlertWeb.weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 387px;
        }
        .auto-style3 {
            width: 386px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Addplane.aspx">Add a Plane</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Start.aspx">Home</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="View Weather"></asp:Label>
                    </td>
                </tr>
            </table>
        <div>
        </div>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

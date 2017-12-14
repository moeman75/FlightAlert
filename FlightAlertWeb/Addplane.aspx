<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addplane.aspx.cs" Inherits="FlightAlertWeb.Addplane" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 387px;
        }
        .auto-style3 {
            width: 361px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
            width: 282px;
        }
        .auto-style7 {
            width: 282px;
        }
        .auto-style8 {
            height: 6px;
            width: 282px;
        }
        .auto-style9 {
            height: 6px;
        }
        .auto-style10 {
            width: 282px;
            height: 30px;
        }
        .auto-style11 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Add a Plane"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/weather.aspx">View Weather</asp:HyperLink>
                    </td>
                </tr>
            </table>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Name of Plane"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                        <asp:Label ID="warningLabel1" runat="server" Font-Bold="True" ForeColor="Red" Text="warning1"></asp:Label>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Delayed?"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True" Value="0">No</asp:ListItem>
                            <asp:ListItem Value="1">Yes</asp:ListItem>
                        </asp:DropDownList>
&nbsp;
                        <asp:Label ID="warningLabel2" runat="server" Font-Bold="True" ForeColor="Red" Text="warning2"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Arrival or Destination"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Incoming Planes"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="16px">
                            <asp:ListItem Value="0" Selected="True">Arrival</asp:ListItem>
                            <asp:ListItem Value="1">Departure</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;
                        <asp:Label ID="warningLabel3" runat="server" Font-Bold="True" ForeColor="Red" Text="warning3"></asp:Label>
                                &nbsp;<table style="width:100%;">
                            <tr>
                                <td class="auto-style4">
                        <asp:Label ID="ArriveDepartLabel" runat="server" Font-Bold="True" Text="Arrival/Destination"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name">
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Label ID="warningLabel4" runat="server" Font-Bold="True" ForeColor="Red" Text="warning4"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                        <asp:Label ID="DateLabel" runat="server" Font-Bold="True" Text="Arrival/Destination Date"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <asp:GridView ID="IncomingGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="Plane ID" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical" Height="244px" AllowSorting="True">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:BoundField DataField="Plane ID" HeaderText="Plane ID" InsertVisible="False" ReadOnly="True" SortExpression="Plane ID" />
                                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                <asp:BoundField DataField="Delayed" HeaderText="Delayed" SortExpression="Delayed" />
                                <asp:BoundField DataField="Arrival Date" HeaderText="Arrival Date" SortExpression="Arrival Date" />
                                <asp:BoundField DataField="Arriving From" HeaderText="Arriving From" SortExpression="Arriving From" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [IncomingPlanes]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="warningLabel5" runat="server" Font-Bold="True" ForeColor="Red" Text="warning5"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Outgoing Planes"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style7"><asp:Label ID="TimeLabel" runat="server" Font-Bold="True" Text="Time:"></asp:Label>
                                &nbsp;<table style="width:100%;">
                            <tr>
                                <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Hour"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Minutes"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">&nbsp;<asp:DropDownList ID="HourDropDownList" runat="server" OnSelectedIndexChanged="HourDropDownList_SelectedIndexChanged">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="MinDropDownList" runat="server">
                            <asp:ListItem>00</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>45</asp:ListItem>
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="AMPMDropDownList" runat="server">
                            <asp:ListItem Value="0">AM</asp:ListItem>
                            <asp:ListItem Value="1">PM</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Plane" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style4"></td>
                            </tr>
                        </table>
                            
                    </td>
                    <td>
                        <asp:GridView ID="OutgoingGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="Plane ID" DataSourceID="SqlDataSource3" ForeColor="Black" GridLines="Vertical" Height="253px" AllowSorting="True">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:BoundField DataField="Plane ID" HeaderText="Plane ID" InsertVisible="False" ReadOnly="True" SortExpression="Plane ID" />
                                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                <asp:BoundField DataField="Delayed" HeaderText="Delayed" SortExpression="Delayed" />
                                <asp:BoundField DataField="Departure Date" HeaderText="Departure Date" SortExpression="Departure Date" />
                                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [OutGoingPlanes]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Airports]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

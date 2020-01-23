<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebFormsEmpty.Index" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Src="~/TopMenu.ascx" TagName="Top" TagPrefix="MyMenu" %>
<%@ Register Src="~/Footer.ascx" TagName="Foot" TagPrefix="MyMenu" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <MyMenu:Top runat="server" ID="MyMenu" />
            <asp:GridView ID="GV" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AllowPaging="True" OnPageIndexChanging="GV_PageIndexChanging" PageSize="20" DataKeyNames="Id,Name,Capital" OnSelectedIndexChanged="GV_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:CommandField SelectText="Выбрать" ShowSelectButton="True">
                                <HeaderStyle Wrap="True" />
                                <ControlStyle Width="50px" />
                            <ItemStyle Width="200px" />
                            </asp:CommandField>
                    <asp:BoundField DataField="Id" HeaderText="Код страны" />
                    <asp:BoundField DataField="Name" HeaderText="Страна" />
                    <asp:BoundField DataField="Capital" HeaderText="Столица" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <asp:HiddenField ID="hfCountryId" runat="server" />
            <table>
                <tr>
                    <td><asp:TextBox ID="tbCountryName" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="tbCountryCapital" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:Button ID="btAdd" runat="server" Text="Добавить" OnClick="btAdd_Click" />
            <asp:Button ID="btUpd" runat="server" Text="Изменить" OnClick="btUpd_Click" />
        </div>
               <MyMenu:Foot runat="server" ID="Foot1" />
    </form>
</body>
</html>

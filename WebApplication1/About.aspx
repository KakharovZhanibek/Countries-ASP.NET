<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>
<%@ Register Src="~/TopMenu.ascx" TagName="Top" TagPrefix="MyMenu" %>
<%@ Register Src="~/Footer.ascx" TagName="Foot" TagPrefix="MyMenu" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <MyMenu:Top runat="server" ID="MyMenu" />
               <MyMenu:Foot runat="server" ID="Foot1" />
        </div>
    </form>
</body>
</html>

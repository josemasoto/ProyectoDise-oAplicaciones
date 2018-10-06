<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalWebFormCliente.aspx.cs" Inherits="WebPage.PrincipalWebFormCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblIdCliente" runat="server" Text="Label">Id Cliente: </asp:Label>
            <br/>
            <asp:Label ID="lblNombreCliente" runat="server" Text="Label">Nombre Cliente: </asp:Label>
            <br/>
            <asp:Label ID="lblTelefonoCliente" runat="server" Text="Label">Telefono Cliente: </asp:Label>
            <br/>
            <asp:Label ID="lblDireccionCliente" runat="server" Text="Label">Direccion Cliente: </asp:Label>
            <br/>
        </div>
    </form>
</body>
</html>

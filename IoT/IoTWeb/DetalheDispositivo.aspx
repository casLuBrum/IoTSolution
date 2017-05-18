<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalheDispositivo.aspx.cs" Inherits="IoTWeb.DetalheDispositivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema IDIoT</title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h5><asp:Label ID="LabelResultadoMsg" runat="server" Text="Label"></asp:Label></h5>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Label">Id:</asp:Label>
            <asp:TextBox ID="TextId" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Label">Nome:</asp:Label>
            <asp:TextBox ID="TextNome" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Label ID="tipoLabel" runat="server" Text="Label">Tipo:</asp:Label>
        <asp:RadioButtonList ID="RadioButtonTipo" runat="server" Enabled="false">
            <asp:ListItem Value="0">Sensor</asp:ListItem>
            <asp:ListItem Value="1">Atuador</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>

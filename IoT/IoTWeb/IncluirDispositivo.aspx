<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncluirDispositivo.aspx.cs" Inherits="IoTWeb.IncluirDispositivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema IDIoT</title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        .floatRight{
            float: right;
        }
    </style>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
    <h5><asp:Label ID="LabelResultadoMsg" runat="server" Text="Label"></asp:Label></h5>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Label">Nome:</asp:Label>
        <asp:TextBox ID="TextNome" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="O nome deve ser preenchido." ControlToValidate="TextNome" BorderColor="Red" BorderStyle="Dashed"></asp:RequiredFieldValidator>
    </div>
    <asp:Label ID="tipoLabel" runat="server" Text="Label">Tipo:</asp:Label>
    <asp:RadioButtonList ID="RadioButtonTipo" runat="server">
        <asp:ListItem Value="0">Sensor</asp:ListItem>
        <asp:ListItem Value="1">Atuador</asp:ListItem>
    </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="RadioButtonTipo" BorderColor="Red" BorderStyle="Dashed"></asp:RequiredFieldValidator>
    <asp:Button ID="ButtonIncluir" runat="server" OnClick="ButtonIncluir_Click" Text="Incluir" CssClass="btn btn-primary floatRight"/>
    </form>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncluirDispositivo.aspx.cs" Inherits="IoTWeb.IncluirDispositivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 276px;
            height: 245px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Nome:<asp:TextBox ID="Text_Nome" runat="server" Width="144px"></asp:TextBox>
        <p style="height: 177px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            :<asp:RadioButtonList ID="RadioButton_Tipo" runat="server" Height="36px" Width="98px">
                <asp:ListItem Value="0">Atuador</asp:ListItem>
                <asp:ListItem Value="1">Sensor</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btn_incluir" runat="server" Text="Salvar" OnClick="btn_incluir_Click" />
        </p>
    </form>
</body>
</html>

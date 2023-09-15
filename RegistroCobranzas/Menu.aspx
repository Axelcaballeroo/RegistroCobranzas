<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="RegistroCobranzas.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong><em><span class="auto-style1">AGENCIA DE COBRANZAS</span></em></strong><br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CargarDatos.aspx">Cargar Datos</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultar.aspx">Consultar Datos</asp:HyperLink>
        </div>
    </form>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebApplication4.inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CALCULADORA</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculadora Web</h1>
            <br />

            <label>Ingrese el primer número: </label>
            <asp:TextBox ID="tn1" runat="server"></asp:TextBox>
            <br /><br />

            Ingrese el segundo número:
            <asp:TextBox ID="tn2" runat="server"></asp:TextBox>
            <br /><br />

            Resultado:
            <asp:Label ID="lresultado" runat="server" Text="0"></asp:Label>
            <br /><br />

            <h3>Menú desplegable</h3>

            <asp:DropDownList ID="doperacion" runat="server">
                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
                <asp:ListItem>Potencia 2</asp:ListItem>
                <asp:ListItem>Exponencial</asp:ListItem>
            </asp:DropDownList>

            <br /><br />

            <h3>Operaciones con CheckBox</h3>

            <asp:CheckBox ID="csuma" runat="server" Text="Suma" />
            <br />
            <asp:CheckBox ID="cresta" runat="server" Text="Resta" />
            <br />
            <asp:CheckBox ID="cmultiplicacion" runat="server" Text="Multiplicacion" />
            <br />
            <asp:CheckBox ID="cdivision" runat="server" Text="Division" />
            <br />
            <asp:CheckBox ID="cpotencia" runat="server" Text="Potencia 2" />
            <br />
            <asp:CheckBox ID="cexponencial" runat="server" Text="Exponencial" />

            <br /><br />

            <asp:Button ID="bresultado" runat="server"
                Height="30px"
                Text="Aceptar"
                Width="100px"
                OnClick="bresultado_Click" />

            <br />
        </div>
    </form>
</body>
</html>

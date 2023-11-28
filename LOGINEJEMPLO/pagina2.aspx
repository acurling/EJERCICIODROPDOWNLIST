<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagina2.aspx.cs" Inherits="LOGINEJEMPLO.pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bienvenido a la pagina  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
           <asp:GridView ID="GridView1" AllowPaging="True" PageSize="5" runat="server">
            </asp:GridView>  
            <br />
            <br />
            Estados<br />
            <asp:RadioButton ID="RadioButton1" Text="Inactivo" runat="server" />
&nbsp;<asp:RadioButton ID="RadioButton2" Text ="Activo" runat="server" />
&nbsp;&nbsp;  
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="54px" OnClick="Button1_Click" Text="Button" Width="154px" />
        </div>
    </form>
</body>
</html>

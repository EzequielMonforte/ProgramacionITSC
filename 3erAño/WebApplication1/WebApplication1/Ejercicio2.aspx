<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="WebApplication1.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label Text="Usuarios que accedieron a la aplicacion:" runat="server" />
                <asp:Label ID="UsersCount" Text="0" runat="server" />
            </div>            
            <div>
                <asp:Label Text="La pagina se recargo:" runat="server" />
                <asp:Label ID="ReloadCount" Text="0" runat="server" />
            </div>
            <asp:Button  Text="reload" runat="server" />
            
        </div>
    </form>
</body>
</html>

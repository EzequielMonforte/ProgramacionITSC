<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="WebApplication1.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label>Login</label>
                <asp:TextBox ID="login" runat="server" />
            </div>            
            <div>
                <label>Password</label>
               
                <asp:TextBox TextMode="Password"  ID="password" runat="server" />
            </div>
        </div>
        <asp:Button OnClick="Unnamed_Click" Text="Autenticar" runat="server" />
    </form>
    <asp:Label ID="result" Text="" runat="server" />
</body>
</html>

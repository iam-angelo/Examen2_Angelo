<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Examen2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:TextBox ID="tusuario" placeholder="Ingrese correo"  class="form-control" runat="server"></asp:TextBox>

<div class="form-group">
    <asp:TextBox ID="tclave" class="form-control" TextMode="Password" placeholder="Digit la clave" runat="server"></asp:TextBox>
    <span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
</div>
<div class="form-group">
    <asp:Button ID="Button1" class="form-control btn btn-dark submit px-3"  runat="server" Text="Button" OnClick="Button1_Click" />
</div>
        <div>
        </div>
    </form>
</body>
</html>

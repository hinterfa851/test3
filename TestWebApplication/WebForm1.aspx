<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method ="post">
         <div>
        <label for="email">введите логин</label>
        <input name="email" id="email" value="">
    </div>
    <div>
        <label for="password">введите пароль</label>
        <input name="password" id="password" value="">
    </div>
    <div>
        <button onclick="ButtonEnter">войти</button>

    </div>
    <div>
        <button onclick="ButtonRegister">зарегестрироваться</button>

    </div>
    </form>
</body>
</html>



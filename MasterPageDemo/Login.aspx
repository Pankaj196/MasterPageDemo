<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPageDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>

    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        table{
            margin-left:40%;
            margin-top:10%;
            background-color:antiquewhite;
            border:1px solid black;
             box-shadow: 5px 10px;
            
        }
       #txtUser,#txtPwd{
            border: 2px solid red;
            
       }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        
        <table>        
         <tr>
             <td><asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td><td></td>
             <td><asp:TextBox ID="txtUser" runat="server" Width="195px"></asp:TextBox></td>
         </tr>
            <br />
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td><td></td>
            <td><asp:TextBox ID="txtPwd" runat="server" Width="197px"></asp:TextBox></td>
        </tr>
           <br />
            <tr>
            <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="61px" /></td><td></td>
        </tr>
            <br />
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td><asp:Label ID="Label3" runat="server" Visible="False" ForeColor="Red" ></asp:Label></td>
        </tr>
        
        </table>
        
    </form>
</body>
</html>

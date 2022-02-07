<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Insert_Product.aspx.cs" Inherits="MasterPageDemo.More" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Product Id"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
</div>
</asp:Content>


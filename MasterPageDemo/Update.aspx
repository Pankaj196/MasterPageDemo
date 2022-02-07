<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="MasterPageDemo.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    This is Contact Page
</div>
    <div>
        <h2>Update Deatails</h2>
        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br><br>

        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtPname" runat="server"></asp:TextBox><br><br>

        <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuant" runat="server"></asp:TextBox><br>

        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
    </div>

</asp:Content>

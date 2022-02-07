<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Retrive.aspx.cs" Inherits="MasterPageDemo.About" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="422px">
    <Columns>
        <asp:BoundField DataField="pid" HeaderText="Id" />
        <asp:BoundField DataField="pname" HeaderText="Name" />
        <asp:BoundField DataField="quant" HeaderText="Quantity" />                    
        <asp:BoundField DataField="price" HeaderText="Cost" />
        <%--add other data fields here--%>
        <%--<asp:HyperLinkField Text="View"DataNavigateUrlFields="ID"DataNavigateUrlFormatString="~/View.aspx?id={​​​​​​0}​​​​​​" />--%>
        <asp:HyperLinkField DataNavigateUrlFields="pid,pname,quant,price"
                    DataNavigateUrlFormatString="Retrive.aspx?pid={0}&pname={1}&quant={2}&price={3}" 
                    />
    </Columns>
</asp:GridView>

</div>
    </asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        BUDGET - MIKE
    </h2>
    <p>
    <asp:Label ID="Label1" runat="server" Text="Label" Width = "229px">Customer</asp:Label>
            <asp:TextBox ID="customer" runat="server" Width="219px" Height="17px"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Label" >City</asp:Label><br />
        <asp:TextBox ID="city" runat="server" Width="219px" Height="17px"></asp:TextBox>
        
    </p>
    <p>
    <asp:Label ID="Label2" runat="server" Text="Label">Type of the service</asp:Label><br />
        <asp:TextBox ID="typeservice" runat="server" Width="218px" Height="16px"></asp:TextBox>
    </p>
    <asp:Label ID="Label4" runat="server" Text="Label">Service Scope</asp:Label>
        <p>
            <asp:TextBox ID="comments" TextMode = "MultiLine" runat="server"  Width="396px" 
                Height="131px"></asp:TextBox>
        </p>
       <p>
    <asp:Label ID="Label3" runat="server" Text="Label">Total</asp:Label><br />
        <asp:TextBox ID="total" runat="server" Width="113px" Height="22px"></asp:TextBox>
    </p>
  
    
  
    <asp:Label ID="Label5" runat="server" Text="Label">Payment Detail</asp:Label><br />
    
          <asp:TextBox ID="payment" runat="server"></asp:TextBox>
        <div style="margin-left: 300px; height: 30px; width: 123px;"> 
        <asp:Button ID="Send" runat="server" onclick="Button1_Click" Text="Send Email" 
                UseSubmitBehavior="False" />
&nbsp;</div>
  
    
</asp:Content>

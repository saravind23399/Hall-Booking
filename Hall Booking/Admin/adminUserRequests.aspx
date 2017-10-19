<%@ Page Title="User Requests - Admin" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminUserRequests.aspx.vb" Inherits="Hall_Booking.adminUserRequests" %>
<%@ mastertype VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        <div class="container">
            <h2><b class="glyphicon glyphicon-user "></b>&nbsp; Account Requests </h2>
            <hr />
            <div id="alrtStyle" runat="server" role="alert">
                <asp:Label Text="" ID="alertLabel" runat="server"></asp:Label>
            </div>
            <br /><br /><br />
            <asp:PlaceHolder ID="Requests" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>

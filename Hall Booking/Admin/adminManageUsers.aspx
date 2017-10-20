<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminManageUsers.aspx.vb" Inherits="Hall_Booking.adminManageUsers" %>
<%@ MasterType VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
<div class="container">
        <div class="container">
            <h2><b class="glyphicon glyphicon-user "></b>&nbsp; Manage Users </h2>
            <hr />
            <div id="alrtStyle" runat="server" role="alert">
                <asp:Label Text="" ID="alertLabel" runat="server"></asp:Label>
            </div>
            <br /><br /><br />
            <asp:PlaceHolder ID="Users" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>

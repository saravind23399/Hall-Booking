<%@ Page Title="Manage Halls" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminManageHalls.aspx.vb" Inherits="Hall_Booking.adminManageHalls" %>
<%@ mastertype VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        <div class="container">
            <h2>
            <asp:label ID="titleText" runat="server" Text=""></asp:label></h2>
            <asp:PlaceHolder ID="Halls" runat="server">
        <asp:table runat="server" id="HallTable" class="table table-hover table-responsive">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Sl.No</asp:TableHeaderCell>
            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Hall ID</asp:TableHeaderCell>
            <asp:TableHeaderCell>Type</asp:TableHeaderCell>
            <asp:TableHeaderCell>Capacity</asp:TableHeaderCell>
            <asp:TableHeaderCell>Availablity</asp:TableHeaderCell>
            <asp:TableHeaderCell>Action</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:table>
            </asp:PlaceHolder>
        </div>
    </div>
</asp:Content>

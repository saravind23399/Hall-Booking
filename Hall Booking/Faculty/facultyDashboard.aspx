<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Faculty/facultyMaster.Master" CodeBehind="facultyDashboard.aspx.vb" Inherits="Hall_Booking.facultyDashboard" %>
<%@ MasterType VirtualPath="~/Faculty/facultyMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="page-header">
        <h2>
            <b class="glyphicon glyphicon-home"></b>
            <asp:Label ID="lblWelcome" runat="server" Text="">
            </asp:Label>
        </h2>
    </div>
</asp:Content>

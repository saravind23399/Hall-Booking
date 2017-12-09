﻿<%@ Page Title="Seminar Hall Booking - MSEC" Language="vb" AutoEventWireup="false" MasterPageFile="~/HomeMaster.Master" CodeBehind="Home.aspx.vb" Inherits="Hall_Booking.WebForm1" %>
<%@ MasterType VirtualPath="HomeMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <img src="Resources/mepcologo.png" height="190" class="pull-right">

        <h1>Welcome to </h1>
        <h1>Seminar Halls Portal</h1>
            <hr />
        <p>Login below to book a hall</p>
            <span>
  <a class="btn btn-success btn-lg" href="Login.aspx" role="button">Login </a>
</span>
</div>
    </div>
    <div class="container center">
        </div>
</asp:Content>

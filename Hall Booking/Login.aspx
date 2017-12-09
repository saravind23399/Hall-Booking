<%@ Page Title="Login - Seminar Hall Booking - MSEC" Language="vb" AutoEventWireup="false" MasterPageFile="~/HomeMaster.Master" CodeBehind="Login.aspx.vb" Inherits="Hall_Booking.WebForm3" %>
<%@ MasterType VirtualPath="HomeMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group-lg col-lg-11">
            <h2>Login</h2>
            <hr />
                <asp:label ID="lblLoginErrors" runat="server"  ForeColor="Red" ></asp:label>
        </div>
        <div class="form-group-lg">
            <label class="col-lg-11 ">Username </label>
            <div class="col-lg-11">
                <asp:TextBox ID="TxtUsername" runat="server" CssClass="form-control" placeholder="Username" ></asp:TextBox>
                <asp:label ID="usernameError" runat="server" ForeColor="Red" ></asp:label>
            </div>
            <label class="col-lg-11 pad">Password </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" ></asp:TextBox>
                <asp:label ID="passwordError" runat="server"  ForeColor="Red" Text="" ></asp:label>
            </div>
            <div class="col-xs-11 space-verticall">
                <asp:button ID="butSignIn" Cssclass="btn btn-lg btn-success btn-default" runat="server" text="Login" />
                <br />
                <br />
                <asp:Label ID="errors" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

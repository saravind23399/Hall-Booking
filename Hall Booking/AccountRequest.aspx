<%@ Page Title="Account Request" Language="vb" AutoEventWireup="false" MasterPageFile="~/HomeMaster.Master" CodeBehind="AccountRequest.aspx.vb" Inherits="Hall_Booking.WebForm4" %>
<%@ MasterType VirtualPath="HomeMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group-lg">
            <h2>Request an Account</h2>
            <hr />
            <asp:label ID="lblLoginErrors" runat="server"  ForeColor="Red" ></asp:label>
            <label class="col-lg-11 ">Username </label>
            <div class="col-lg-11">
                <asp:TextBox ID="TxtUsername" runat="server" Class="form-control" placeholder="Username"></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Faculty ID </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtFacultyID" runat="server" Class="form-control" placeholder="Faculty ID"></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">E-Mail ID </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtEmail" runat="server" Class="form-control" placeholder="yourid@example.com" TextMode="Email"></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Department </label>
            <div class="col-lg-11">
                <asp:DropDownList CssClass="form-control" runat="server" ID="drpDepartment">
                    <asp:ListItem Text=" "></asp:ListItem>
                    <asp:ListItem Text="CSE"></asp:ListItem>
                    <asp:ListItem Text="CIVIL"></asp:ListItem>
                    <asp:ListItem Text="EEE"></asp:ListItem>
                    <asp:ListItem Text="ECE"></asp:ListItem>
                    <asp:ListItem Text="IT"></asp:ListItem>
                    <asp:ListItem Text="MECH"></asp:ListItem>
                    <asp:ListItem Text="MCA"></asp:ListItem>
                    <asp:ListItem Text="MBA"></asp:ListItem>
                    <asp:ListItem Text="BIOTECH"></asp:ListItem>
                    <asp:ListItem Text="NANOTECH"></asp:ListItem>
                    <asp:ListItem Text="PHYSICS"></asp:ListItem>
                    <asp:ListItem Text="MATHEMATICS"></asp:ListItem>
                    <asp:ListItem Text="CHEMISTRY"></asp:ListItem>
                    <asp:ListItem Text="ENGLISH"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-xs-11 space-verticall">
                <asp:Button ID="butRequest" class="btn btn-lg btn-success btn-default" runat="server" Text="Place Request" />
                <br /><br /><asp:label runat="server" text="Already have an account? "></asp:label><a href="Login.aspx">Login</a>

                <br />
                <br />
                <asp:Label ID="errors" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="Admin - Register Users" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="addUsers.aspx.vb" Inherits="Hall_Booking.addUsers" %>
<%@ MasterType VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        <div class="form-group">
            <h2>Register Users</h2>
            <hr />
        </div>
        <div class="form-group-lg">
            <label class="col-lg-11 ">Username </label>
            <div class="col-lg-11">
                <asp:TextBox ID="TxtUsername" runat="server" Class="form-control" placeholder="Username" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Password </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtPassword" runat="server" Class="form-control" placeholder="Password" TextMode="Password" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Confirm Password </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtCPassword" runat="server" Class="form-control" Textmode="Password" placeholder="Confirm Password" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Confirm Password </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtEmail" runat="server" Class="form-control" Textmode="Email" placeholder="Email ID" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Department</label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtDepartment" runat="server" Class="form-control" ReadOnly="true" ></asp:TextBox>                
            </div>
            <div class="col-xs-11 space-verticall">
                <asp:button ID="butSignUp" class="btn btn-lg btn-success btn-default" runat="server" text="Sign Up" />
                <br />
                <br />
                <asp:Label ID="errors" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
    
<%@ Page Title="Admin Panel" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminHome.aspx.vb" Inherits="Hall_Booking.adminHome" %>
<%@ MasterType VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        <div class="page-header">
            <h2>
                <b class ="glyphicon glyphicon-home "></b>
                <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
            </h2>
        </div>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-8 pull-left">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h4>Today</h4>
                        </div>
                        <div class="panel-body">
                        <p>Heres whats happeing in your department</p><br />
                        <div id="todayEvents ">

                        </div>
                            </div>
                    </div>
                </div>
                <div class="col-lg-4 pull-right ">
                    <div class="col-lg-12">
                        <div class="panel panel-warning">
                            <div class="panel-heading">
                                <h4>Halls</h4>
                            </div>
                            <div class="panel-body">
                                <a href="#" class="btn btn-block btn-success"><b class ="glyphicon glyphicon-plus pull-left"></b>  Add a hall</a>
                                <a href="#" class="btn btn-block btn-danger"><b class ="glyphicon glyphicon-trash pull-left"></b>  Remove a hall</a>
                                <a href="#" class="btn btn-block btn-primary"><b class ="glyphicon glyphicon-inbox pull-left"></b>  Request a hall - Other Departments</a>
                                <a href="#" class="btn btn-block btn-primary"><b class ="glyphicon glyphicon-calendar pull-left"></b>  Hall availablity</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div class="panel panel-danger">
                            <div class="panel-heading">
                                <h4>Users</h4>
                            </div>
                            <div class="panel-body">
                                <a href="adminManageUsers.aspx" class="btn btn-block btn-success"><b class="glyphicon glyphicon-cog pull-left"></b>  Manage</a>
                                <a href="addUsers.aspx" class="btn btn-primary btn-block"><b class="glyphicon glyphicon-ok pull-left"></b>  Add users</a>
                                <a href="adminUserRequests.aspx" class="btn btn-primary btn-block"><b class ="glyphicon glyphicon-user pull-left"></b>  Account Requests</a>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

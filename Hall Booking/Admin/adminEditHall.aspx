<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminEditHall.aspx.vb" Inherits="Hall_Booking.adminEditHall" %>
<%@ mastertype VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        <div class="container">
            <h2>
            <asp:label ID="titleText" runat="server" Text="Department of "></asp:label></h2>
            <hr />
            <asp:Label ID="lblAlert" CssClass="col-lg-11" Forecolor="Red" runat="server" Text="" ></asp:Label>
            <label class="col-lg-11 ">Name </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtHallName" runat="server" Class="form-control" placeholder="Hall Name" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Hall Number </label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtHallID" runat="server" Class="form-control" placeholder="Hall ID" ></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Hall Type </label>
            <div class="col-lg-11">
                <asp:DropDownList ID="drpDownHallType" CssClass="form-control dropdown" runat="server" >
                    <asp:ListItem Text="----" Value="----"></asp:ListItem>
                    <asp:ListItem Text="Classroom" Value="Classroom"></asp:ListItem>
                    <asp:ListItem Text="Seminar Hall" Value="Seminar Hall"></asp:ListItem>
                    <asp:ListItem Text="Lab" Value="Lab"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <label class="col-lg-11 pad">Seating Capacity</label>
            <div class="col-lg-11">
                <asp:TextBox ID="TxtSeatingCapacity" runat="server" Class="form-control" placeholder="Number of Seats"></asp:TextBox>
            </div>
            <label class="col-lg-11 pad">Department</label>
            <div class="col-lg-11">
                <asp:TextBox ID="txtDepartment" runat="server" Class="form-control" ReadOnly="true" ></asp:TextBox>                
            </div>
            <label class="col-lg-11 pad">Availablity</label>
            <div class="col-lg-11">
                     <label class=" form-control radio-inline"><input type="radio" id="radYES" runat="server">YES</label>
                     <label class="form-control radio-inline"><input type="radio" id="radNO" runat="server">No</label>
            </div>
            <div class="col-xs-11 space-verticall">
                <asp:button ID="butSaveHall" class="btn btn-lg btn-success btn-default" runat="server" text="Confirm Changes" />
                &nbsp;&nbsp;
                <asp:button ID="butDiscard" class="btn btn-lg btn-success btn-danger" runat="server" text="Discard Changes" />
                <br />
                <br />
                <asp:Label ID="errors" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

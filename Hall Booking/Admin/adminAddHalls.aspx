<%@ Page Title="Add a Hall" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/adminMaster.Master" CodeBehind="adminAddHalls.aspx.vb" Inherits="Hall_Booking.adminAddHalls" %>
<%@ MasterType VirtualPath="~/Admin/adminMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contents" runat="server">
    <div class="container">
        
        <div class="form-group-lg">
            <h3>Add a Hall </h3><hr />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblAlert" Forecolor="Red" runat="server" Text="" ></asp:Label>
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
                     <label class="radio-inline"><input type="radio" id="radYES" runat="server">YES</label>
                     <label class="radio-inline"><input type="radio" id="radNO" runat="server">No</label>
            </div>
            <div class="col-xs-11 space-verticall">
                <asp:button ID="butAddHall" class="btn btn-lg btn-success btn-default" runat="server" text="Add Hall" />
                <br />
                <br />
                <asp:Label ID="errors" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

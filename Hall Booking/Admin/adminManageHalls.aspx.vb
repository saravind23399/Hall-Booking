Imports System.Data.SqlClient

Public Class adminManageHalls
    Inherits System.Web.UI.Page
    Private Shared deletedHall = ""
    Private Shared alert = ""
    Private Shared alertEnable As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = "active"
        If Session.Item("TYPE") = "ADMIN" Then
            titleText.Text = "Halls Listed - Department of " + Session.Item("DEPARTMENT")
            Dim cs As String = My.Settings.UsersConnection
            Dim conn As New SqlConnection(cs)
            Dim cmd As New SqlCommand("Select * from HallData where department='" + Session.Item("DEPARTMENT") + "'", conn)
            conn.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt = New DataTable
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows()
                createHall(dr)
            Next
        Else
            Response.Redirect("~/Home.aspx")
        End If
        If deletedHall <> "" Then
            alertLabel.Text = deletedHall + " was removed"
        End If
        alertStyle.Visible = alertEnable
        alertStyle.CssClass += "alert alert-dismissable " + alert
    End Sub
    Private Sub createHall(ByVal dr As DataRow)
#Region "Panel Declarations"
        Dim primaryPanel As New Panel
        Dim panelHead As New Panel
        Dim buttonPanel As New Panel
        Dim detailsPanel As New Panel
#End Region
#Region "Class definitions"
        Dim ListingStatus As String = ""
        Dim btnChange As New Button

        If dr(6) = "TRUE" Then
            primaryPanel.Attributes.Add("class", "panel panel-info ")
            ListingStatus = "Make Unavailable"
            btnChange.CssClass = "btn btn-warning col-lg-2 col-lg-offset-1"

        Else
            primaryPanel.Attributes.Add("class", "panel panel-warning ")
            ListingStatus = "Make available"
            btnChange.CssClass += "btn col-lg-2 col-lg-offset-1 btn-success"

        End If
        panelHead.Attributes.Add("class", "panel-heading ")
        detailsPanel.Attributes.Add("class", "panel-body")
        buttonPanel.Attributes.Add("class", "form-actions")
#End Region
#Region "Details Panel"
        Dim isAvailable As String = "YES"
        If dr(6).ToString() = "FALSE" Then
            isAvailable = "NO"
        End If
        panelHead.Controls.Add(New LiteralControl("<h4>" + dr(1) + "</h4>"))
        detailsPanel.Controls.Add(New LiteralControl("<br><strong> Hall ID </strong> : " + dr(2).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Hall Type </strong> : " + dr(3).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Seating Capacity </strong> : " + dr(4).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Availablity </strong> : " + isAvailable + "<br>"))

#End Region
#Region "Button Panel"
        Dim btnEdit As New Button
        btnEdit.Text = "Change Details"
        'AddHandler btnEdit.Click, AddressOf EditUser
        btnEdit.CssClass = "btn btn-primary col-lg-4 col-lg-offset-1 "
        btnEdit.Attributes.Add("TAG", dr(1))
        btnChange.Text = ListingStatus
        btnChange.Attributes.Add("TAG", dr(1))
        Dim btnDelete As New Button
        'AddHandler btnDelete.Click, AddressOf DeleteUser
        btnDelete.Text = "Remove from Listing"
        btnDelete.Attributes.Add("TAG", dr(1))
        btnDelete.CssClass = "btn btn-danger col-lg-2 col-lg-offset-1"
        buttonPanel.Controls.Add(New LiteralControl("<hr>"))
        buttonPanel.Controls.Add(btnEdit)
        buttonPanel.Controls.Add(btnChange)
        buttonPanel.Controls.Add(btnDelete)
        buttonPanel.Controls.Add(New LiteralControl("<br><br><br>"))
#End Region
#Region "Panel Insertion"
        primaryPanel.Controls.Add(panelHead)
        primaryPanel.Controls.Add(detailsPanel)
        primaryPanel.Controls.Add(buttonPanel)
        Users.Controls.Add(primaryPanel)
        Users.Controls.Add(New LiteralControl("<br>"))
#End Region
    End Sub

End Class
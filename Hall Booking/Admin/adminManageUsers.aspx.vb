Imports System.Data.SqlClient
Public Class adminManageUsers
    Inherits System.Web.UI.Page
    Private Shared deletedUser = ""
    Private Shared alert = ""
    Private Shared alertEnable As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("TYPE") = "ADMIN" Then
            Dim cs As String = My.Settings.UsersConnection
            Dim conn As New SqlConnection(cs)
            Dim cmd As New SqlCommand("Select * from Users where department='" + Session.Item("DEPARTMENT") + "' and type='FACULTY'", conn)
            conn.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt = New DataTable
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows()
                createUser(dr)
            Next
        Else
            Response.Redirect("~/Home.aspx")
        End If
        If deletedUser <> "" Then
            alertLabel.Text = "User, " + deletedUser + " was removed"
        End If
        alertStyle.Visible = alertEnable
        alertStyle.CssClass += "alert alert-dismissable " + alert
    End Sub
    Private Sub createUser(ByVal dr As DataRow)
#Region "Panel Declarations"
        Dim primaryPanel As New Panel
        Dim detailsPanel As New Panel
        Dim buttonPanel As New Panel
#End Region
#Region "Class definitions"
        primaryPanel.Controls.Add(New LiteralControl("<br>"))
        primaryPanel.Attributes.Add("class", "container ")
        detailsPanel.Attributes.Add("class", "container ")
        primaryPanel.BorderWidth = 1
        primaryPanel.BorderStyle = BorderStyle.Groove
        primaryPanel.BorderColor = Drawing.Color.Black
#End Region
#Region "Details Panel"
        detailsPanel.Controls.Add(New LiteralControl("<strong> Faculty ID </strong> :" + dr(6).ToString()))
        detailsPanel.Controls.Add(New LiteralControl("<br><strong> Username </strong> : " + dr(1).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Email </strong> : " + dr(3).ToString() + "<br>"))
#End Region
#Region "Button Panel"
        Dim btnEdit As New Button
        btnEdit.Text = "Edit"
        AddHandler btnEdit.Click, AddressOf EditUser
        btnEdit.CssClass = "btn btn-success col-lg-6"
        btnEdit.Attributes.Add("TAG", dr(1))
        Dim btnDelete As New Button
        AddHandler btnDelete.Click, AddressOf DeleteUser
        btnDelete.Text = "Delete"
        btnDelete.Attributes.Add("TAG", dr(1))
        btnDelete.CssClass = "btn btn-danger col-lg-6"
        buttonPanel.Controls.Add(New LiteralControl("<hr>"))
        buttonPanel.Controls.Add(btnEdit)
        buttonPanel.Controls.Add(btnDelete)
        buttonPanel.Controls.Add(New LiteralControl("<br><br><br>"))
#End Region
#Region "Panel Insertion"
        primaryPanel.Controls.Add(detailsPanel)
        primaryPanel.Controls.Add(buttonPanel)
        Users.Controls.Add(primaryPanel)
        Users.Controls.Add(New LiteralControl("<br>"))
#End Region
    End Sub
    Private Sub EditUser(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Private Sub DeleteUser(ByVal sender As Object, ByVal e As EventArgs)
        Dim facid As String = CType(sender, Button).Attributes("TAG")
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("delete from Users where username='" + facid + "'", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        deletedUser = facid
        alertEnable = True
        alert = "alert-danger"
        Response.Redirect("adminManageUsers.aspx")
    End Sub

    Private Sub adminManageUsers_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        alertEnable = False
    End Sub
End Class
Imports System.Data.SqlClient

Public Class adminHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session.Item("TYPE") = "ADMIN" Then
            Master.AdminPanelSelected = "active"
            lblWelcome.Text = "Department of " + Session.Item("DEPARTMENT") + " - Admin Panel"
            Dim cs As String = My.Settings.UsersConnection
            Dim conn As New SqlConnection(cs)
            Dim cmd As New SqlCommand("SELECT count(*) from newUserRequests", conn)
            conn.Open()
            Dim count As Integer = cmd.ExecuteScalar()
            If count <> 0 Then
                userRequestButton.Controls.Add(New LiteralControl("<span class=""badge badge-light pull-right"">" + count.ToString + "</span>"))
            End If
            userRequestButton.Controls.Add(New LiteralControl("<b class=""glyphicon glyphicon-user pull-left""></b>Account Requests"))
        Else
            Response.Redirect("~/Home.aspx")
        End If
    End Sub
End Class
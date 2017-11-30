Imports System.Data
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient

Public Class adminUserRequests
    Inherits System.Web.UI.Page

    Private Sub adminUserRequests_Load(sender As Object, e As EventArgs) Handles Me.Load
        Master.UserRequestsSelected = "active"
        If Session.Item("ADMIN_OP") = "REJECT" Then
            alertLabel.Text = "Request from " + Session.Item("ADMIN_OP_FACID") + " was rejected. "
            alrtStyle.Attributes.Add("Class", "alert alert-danger col-lg-6")

        ElseIf Session.Item("ADMIN_OP") <> "" Then
            alertLabel.Text = "Request from " + Session.Item("ADMIN_OP_FACID") + " was accepted. "
            alrtStyle.Attributes.Add("Class", "alert alert-success col-lg-6")
        End If
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("Select * from newUserRequests where department='" + Session.Item("DEPARTMENT") + "'", conn)
        conn.Open()
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt = New DataTable
        sda.Fill(dt)
        For Each dr As DataRow In dt.Rows()
            createUserRequest(dr)
        Next
        conn.Close()
    End Sub
    Private Sub createUserRequest(ByVal dr As DataRow)
#Region "Panel Declarations"
        Dim primaryPanel As New Panel
        Dim detailsPanel As New Panel
        Dim buttonPanel As New Panel
#End Region
#Region "Class definitions"
        primaryPanel.Attributes.Add("class", "container ")
        detailsPanel.Attributes.Add("class", "container ")
        primaryPanel.BorderWidth = 1
        primaryPanel.BorderStyle = BorderStyle.Groove
        primaryPanel.BorderColor = Drawing.Color.Black
#End Region
#Region "Details Panel"
        detailsPanel.Controls.Add(New LiteralControl("<h3> Faculty #" + dr(2) + " </h3><hr>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Username </strong> : " + dr(1).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Email </strong> : " + dr(2).ToString() + "<br>"))
        detailsPanel.Controls.Add(New LiteralControl("<strong> Requested on </strong> : " + dr(4).ToString() + "<hr>"))
#End Region
#Region "Button Panel"
        Dim btnGrant As New Button
        btnGrant.Text = "Accept"
        AddHandler btnGrant.Click, AddressOf acceptRequest
        btnGrant.CssClass = "btn btn-success col-lg-6"
        btnGrant.Attributes.Add("TAG", dr(2))
        Dim btnDismiss As New Button
        AddHandler btnDismiss.Click, AddressOf rejectRequest
        btnDismiss.Text = "Reject"
        btnDismiss.Attributes.Add("TAG", dr(2))
        btnDismiss.CssClass = "btn btn-danger col-lg-6"
        buttonPanel.Controls.Add(btnGrant)
        buttonPanel.Controls.Add(btnDismiss)
        buttonPanel.Controls.Add(New LiteralControl("<br><br><br>"))
#End Region
#Region "Panel Insertion"
        primaryPanel.Controls.Add(detailsPanel)
        primaryPanel.Controls.Add(buttonPanel)
        Requests.Controls.Add(primaryPanel)
        Requests.Controls.Add(New LiteralControl("<br>"))
#End Region
    End Sub
    Private Sub acceptRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facid As String = CType(sender, Button).Attributes("TAG")
        Session.Add("ADMIN_OP", "ACCEPT")
        Session.Add("ADMIN_OP_FACID", facid)
        Response.Redirect("addUserFromRequest.aspx")
    End Sub
    Private Sub rejectRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facid As String = CType(sender, Button).Attributes("TAG")
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("delete from newUserRequests where facultyID='" + facid + "'", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        Session.Add("ADMIN_OP", "REJECT")
        Session.Add("ADMIN_OP_FACID", facid)
        Response.Redirect("adminUserRequests.aspx")
    End Sub
End Class
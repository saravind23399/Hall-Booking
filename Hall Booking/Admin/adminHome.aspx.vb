Public Class adminHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session.Item("TYPE") = "ADMIN" Then
            Master.AdminPanelSelected = "active"
            lblWelcome.Text = "Department of " + Session.Item("DEPARTMENT") + " - Admin Panel"
        Else
            Response.Redirect("~/Home.aspx")
        End If
    End Sub
End Class
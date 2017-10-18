Public Class adminHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = "active"
        Master.AddUsersSelected = ""
    End Sub

End Class
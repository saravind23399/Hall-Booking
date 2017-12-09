Public Class facultyMaster
    Inherits System.Web.UI.MasterPage
    Public WriteOnly Property DashboardSelected As String
        Set(ByVal value As String)
            lnkDashboard.Attributes.Add("class", value)
        End Set
    End Property
    Public WriteOnly Property HallAvailablitySelected As String
        Set(ByVal value As String)
            lnkHallAvailablity.Attributes.Add("class", value)
        End Set
    End Property
    Public WriteOnly Property BookSelected As String
        Set(ByVal value As String)
            lnkBook.Attributes.Add("class", value)
        End Set
    End Property
    Private Sub signout_Click(sender As Object, e As EventArgs) Handles signout.Click
        Session.Clear()
        Response.Redirect("~/Login.aspx")
    End Sub
End Class
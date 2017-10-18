Public Class adminMaster
    Inherits System.Web.UI.MasterPage
    Public WriteOnly Property AdminPanelSelected As String
        Set(ByVal value As String)
            lnkAdminPanel.Attributes.Add("class", value)
        End Set
    End Property
    Public WriteOnly Property AddUsersSelected As String
        Set(ByVal value As String)
            lnkAddUsers.Attributes.Add("class", value)
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class
Public Class HomeMaster
    Inherits System.Web.UI.MasterPage
    Public WriteOnly Property HomeSelected As String
        Set(ByVal value As String)
            lnkHome.Attributes.Add("class", value)
        End Set
    End Property
    Public WriteOnly Property LoginSelected As String
        Set(ByVal value As String)
            lnkLogin.Attributes.Add("class", value)
        End Set
    End Property
    Public WriteOnly Property AboutSelected As String
        Set(ByVal value As String)
            lnkAbout.Attributes.Add("class", value)
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class
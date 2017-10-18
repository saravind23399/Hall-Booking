Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AboutSelected = ""
        Master.HomeSelected = "active"
    End Sub

End Class
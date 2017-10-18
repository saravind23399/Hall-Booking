Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("USERNAME") <> "" Then
            If Session.Item("TYPE") = "ADMIN" Then
                Response.Redirect("~/Admin/adminHome.aspx")
            Else
                Response.Redirect("~/Home.aspx")
            End If
        End If
        Master.AboutSelected = ""
        Master.HomeSelected = "active"
    End Sub

End Class
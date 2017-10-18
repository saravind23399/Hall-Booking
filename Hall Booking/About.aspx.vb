Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.HomeSelected = ""
        Master.AboutSelected = "active"
        If Session.Item("TYPE") = "ADMIN" Then
            Master.HomeText = "Return to Admin Panel"
            Master.LoginVisible = False
        ElseIf Session.Item("TYPE") = "FACULTY" Then
            Master.HomeText = "Return to Booking Panel"
            Master.LoginVisible  = False
        End If
    End Sub

End Class
Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.LoginSelected = "active"
    End Sub

    Private Sub butSignIn_Click(sender As Object, e As EventArgs) Handles butSignIn.Click
        If TxtUsername.Text = "" Then
            usernameError.Text = "*Username empty"
            GoTo last
        Else
            usernameError.Text = ""
        End If
        If txtPassword.Text = "" Then
            passwordError.Text = "*Password empty"
            GoTo last
        Else
            passwordError.Text = ""
        End If
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("Select * from users where username='" + TxtUsername.Text + "' and password = '" + HashPassword(txtPassword.Text) + "'", conn)
        conn.Open()
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt = New DataTable
        sda.Fill(dt)
        If dt.Rows.Count <> 0 Then
            Session.Add("USERNAME", TxtUsername.Text)
            Session.Add("TYPE", dt.Rows(0)(5))
            Session.Add("DEPARTMENT", dt.Rows(0)(4))
            If Session.Item("TYPE") = "ADMIN" Then
                Response.Redirect("~/Admin/adminHome.aspx")
            Else
                Response.Redirect("~/Home.aspx")
            End If
        Else
            cmd.Connection = conn
            cmd.CommandText = "Select * from users where username='" + TxtUsername.Text + "'"
            sda.SelectCommand = cmd
            dt.Clear()
            sda.Fill(dt)
            If dt.Rows.Count <> 0 Then
                lblLoginErrors.Text = "*Username/Password does not match."
            Else
                lblLoginErrors.Text = "Your username is not found. Please request for an account."
            End If

        End If
last:
    End Sub
    Public Function HashPassword(ByVal ClearString As String) As String
        Dim uEncode As New UnicodeEncoding()
        Dim bytClearString() As Byte = uEncode.GetBytes(ClearString)
        Dim sha As New _
        System.Security.Cryptography.SHA256Managed()
        Dim hash() As Byte = sha.ComputeHash(bytClearString)
        Return Convert.ToBase64String(hash)
    End Function
End Class
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class addUsers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = ""
        Master.AddUsersSelected = "active"
        txtDepartment.Text = "CSE"
    End Sub

    Private Sub butSignUp_Click(sender As Object, e As EventArgs) Handles butSignUp.Click
        If TxtUsername.Text = "" Or txtPassword.Text = "" Or txtCPassword.Text = "" Or txtEmail.Text = "" Or txtDepartment.Text = "" Then
            errors.Text = "*All Fields are mandatory"
            errors.ForeColor = Drawing.Color.Red
        Else
            If txtPassword.Text <> txtCPassword.Text Then
                errors.Text = "Passwords dont match."
                errors.ForeColor = Drawing.Color.Red
                txtCPassword.Text = ""
                txtPassword.Text = ""
            Else
                Dim cs As String = My.Settings.UsersConnection
                Dim con As New SqlConnection(cs)
                con.Open()
                Dim username As String = TxtUsername.Text
                Dim password As String = HashPassword(txtPassword.Text)
                Dim dept As String = txtDepartment.Text
                Dim email As String = txtEmail.Text
                Dim cmd As New SqlCommand("insert into users values ('" + username + "','" + password + "','" + email + "','" + dept + "','faculty')", con)
                cmd.ExecuteNonQuery()
                errors.Text = "User Registered."
                errors.Font.Size = 12
                errors.ForeColor = Drawing.Color.Green
            End If
        End If
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
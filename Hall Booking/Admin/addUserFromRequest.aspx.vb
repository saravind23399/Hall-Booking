Imports System.Data.SqlClient
Public Class addUserFromRequest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.UserRequestsSelected = "active"
        If Not IsPostBack Then
            If Session.Item("ADMIN_OP_FACID") <> "" And Session.Item("ADMIN_OP") = "ACCEPT" Then
                Dim cs As String = My.Settings.UsersConnection
                Dim conn As New SqlConnection(cs)
                Dim cmd As New SqlCommand("Select * from newUserRequests where facultyID='" + Session.Item("ADMIN_OP_FACID") + "'", conn)
                conn.Open()
                Dim sda As New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                sda.Fill(dt)
                conn.Close()
                TxtUsername.Text = dt(0)(1)
                txtEmail.Text = dt(0)(3)
                txtDepartment.Text = dt(0)(4)
                txtPassword.Focus()
            Else
                Response.Redirect("adminHome.aspx")
            End If
        End If
    End Sub

    Private Sub butCreateUser_Click(sender As Object, e As EventArgs) Handles butCreateUser.Click
        If txtPassword.Text = "" Then
            errors.Text = "*Password field is empty"
            errors.ForeColor = Drawing.Color.Red
            GoTo Last
        Else
            If txtPassword.Text <> txtCPassword.Text Then
                errors.Text = "*Passwords dont match."
                errors.ForeColor = Drawing.Color.Red
                GoTo Last
            End If
        End If
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("Insert into users values('" + TxtUsername.Text + "','" + HashPassword(txtCPassword.Text) + "','" + txtEmail.Text + "','" + txtDepartment.Text + "','FACULTY')", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        errors.Text = "User has successfully been created."
        errors.ForeColor = Drawing.Color.Green
        conn.Close()
Last:
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
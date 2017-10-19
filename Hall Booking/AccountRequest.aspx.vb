Imports System.Data.SqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.LoginSelected = "active"
    End Sub

    Private Sub butRequest_Click(sender As Object, e As EventArgs) Handles butRequest.Click
        If txtEmail.Text = "" Or txtFacultyID.Text = "" Or TxtUsername.Text = "" Or drpDepartment.SelectedItem.Text = " " Then
            errors.ForeColor = Drawing.Color.Red
            errors.Text = "*All fields are mandatory."
        Else
            Dim cs As String = My.Settings.UsersConnection
            Dim conn As New SqlConnection(cs)
            Dim cmd As New SqlCommand("Select * from users where username='" + TxtUsername.Text + "'", conn)
            conn.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt = New DataTable
            sda.Fill(dt)
            If dt.Rows.Count <> 0 Then
                errors.ForeColor = Drawing.Color.Red
                errors.Text = "Username exists. Please Login"
            Else
                cmd.CommandText = "Select * from newUserRequests where facultyID='" + txtFacultyID.Text + "' or username = '" + TxtUsername.Text + "'"
                sda.SelectCommand = cmd
                dt.Clear()
                sda.Fill(dt)
                If dt.Rows.Count <> 0 Then
                    errors.ForeColor = Drawing.Color.Red
                    errors.Text = "*Cannot request an account. Username/Faculty ID already exists in requests list"
                Else
                    cmd.CommandText = "Insert into newUserRequests values ('" + TxtUsername.Text + "','" + txtFacultyID.Text + "','" + txtEmail.Text + "','" + drpDepartment.Text + "',getdate())"
                    cmd.ExecuteNonQuery()
                    errors.Text = "Your request has been placed successfully. Kindly contact your department admin for activation."
                    errors.ForeColor = Drawing.Color.Green
                    errors.Font.Size = 12
                End If
            End If
            End If
    End Sub
End Class
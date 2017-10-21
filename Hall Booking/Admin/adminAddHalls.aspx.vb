Imports System.Data.SqlClient
Public Class adminAddHalls
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = "active"
        If Session.Item("TYPE") <> "ADMIN" Then
            Response.Redirect("~/Home.aspx")
        End If
        radYES.Checked = True
        txtDepartment.Text = Session.Item("DEPARTMENT")
    End Sub

    Private Sub butAddHall_Click(sender As Object, e As EventArgs) Handles butAddHall.Click
        If txtHallName.Text = "" Or txtHallID.Text = "" Or TxtSeatingCapacity.Text = "" Or drpDownHallType.Text = "----" Then
            lblAlert.Text = "All fields are mandatory"
            lblAlert.ForeColor = Drawing.Color.Red
        Else
            If Not Integer.TryParse(TxtSeatingCapacity.Text, New Integer) Then
                lblAlert.Text = "Seating Capacity invalid."
                lblAlert.ForeColor = Drawing.Color.Red
                GoTo last
            End If
            Dim conn As New SqlConnection(My.Settings.UsersConnection)
            Dim cmd As New SqlCommand("Select * from HallData where hallid='" + txtHallID.Text + "'", conn)
            conn.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            conn.Close()
            If dt.Rows.Count = 0 Then
                conn.Open()
                Dim checked As String = "TRUE"
                If radNO.Checked Then
                    checked = "FALSE"
                End If
                cmd.CommandText = "Insert into HallData values('" + txtHallName.Text + "','" + txtHallID.Text + "','" + drpDownHallType.SelectedValue + "','" + TxtSeatingCapacity.Text + "','" + txtDepartment.Text + "','" + checked + "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                lblAlert.Text = txtHallName.Text + " was Successfully added"
                lblAlert.ForeColor = Drawing.Color.Green
            Else
                lblAlert.Text = txtHallName.Text + " already Added"
                lblAlert.ForeColor = Drawing.Color.Red
            End If
        End If
last:
    End Sub
End Class
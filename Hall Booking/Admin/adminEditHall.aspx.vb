
Imports System.Data.SqlClient

Public Class adminEditHall
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = True
        If Not IsPostBack Then
            If Session("TYPE") = "ADMIN" Then
                If Session("HALLEDITID") <> "" Then
                    Dim cs As String = My.Settings.UsersConnection
                    Dim conn As New SqlConnection(cs)
                    Dim cmd As New SqlCommand("Select * from HallData where hallid='" + Session("HALLEDITID") + "'", conn)
                    conn.Open()
                    Dim sda As New SqlDataAdapter(cmd)
                    Dim dt = New DataTable
                    sda.Fill(dt)
                    titleText.Text = "Edit Hall - Department of " & Session.Item("DEPARTMENT") & " - " & dt(0)(1).ToString
                    txtHallName.Text = dt(0)(1)
                    txtHallID.Text = dt(0)(2)
                    txtDepartment.Text = dt(0)(5)
                    TxtSeatingCapacity.Text = dt(0)(4)
                    drpDownHallType.SelectedValue = dt(0)(3)
                    If dt(0)(6) = "TRUE" Then
                        radYES.Checked = True
                    Else
                        radNO.Checked = False
                    End If
                Else
                    Response.Redirect("~/Admin/adminHome.aspx")
                End If
            Else
                Response.Redirect("~/home.aspx")
            End If
        End If
    End Sub

    Private Sub butSaveHall_Click(sender As Object, e As EventArgs) Handles butSaveHall.Click
        MsgBox(TxtSeatingCapacity.Text)
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
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            conn.Open()
            Dim checked As String = "TRUE"
            If radNO.Checked Then
                checked = "FALSE"
            End If
            cmd.CommandText = "Update HallData set hallname = '" + txtHallName.Text + "'," + "hallid = '" + txtHallID.Text + "'," + "halltype = '" + drpDownHallType.SelectedValue + "'," + "capacity = '" + TxtSeatingCapacity.Text + "'," + "department = '" + Session("DEPARTMENT") + "',available = '" + checked + "' where hallid='" + Session("HALLEDITID") + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            lblAlert.Text = txtHallName.Text + " was Successfully Updated"
            lblAlert.ForeColor = Drawing.Color.Green
        End If
last:
    End Sub

    Private Sub butDiscard_Click(sender As Object, e As EventArgs) Handles butDiscard.Click
        Response.Redirect("~/Admin/adminManageHalls.aspx")
    End Sub
End Class
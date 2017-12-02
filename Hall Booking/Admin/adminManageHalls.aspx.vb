Imports System.Data.SqlClient

Public Class adminManageHalls
    Inherits System.Web.UI.Page
    Dim slno As Integer = 1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Master.AdminPanelSelected = "active"
        If Session.Item("TYPE") = "ADMIN" Then
            titleText.Text = "Halls Listed - Department of " + Session.Item("DEPARTMENT")
            Dim cs As String = My.Settings.UsersConnection
            Dim conn As New SqlConnection(cs)
            Dim cmd As New SqlCommand("Select * from HallData where department='" + Session.Item("DEPARTMENT") + "'", conn)
            conn.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt = New DataTable
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows()
                CreateTableRow(dr)
            Next
            slno = 1
            conn.Close()
        Else
            Response.Redirect("~/Home.aspx")
        End If

    End Sub
    Private Sub CreateTableRow(ByVal dr As DataRow)
        Dim tabRow As New TableRow
        Dim slnoCell As New TableCell
        slnoCell.Text = slno
        slno += 1
        tabRow.Cells.Add(slnoCell)
        For i As Integer = 1 To 4
            Dim tabCell As New TableCell
            tabCell.Text = dr(i)
            tabRow.Cells.Add(tabCell)
        Next
        Dim newCell As New TableCell
        If dr(6) = "TRUE" Then
            tabRow.CssClass = "success"
            newCell.Text = "YES"
        Else
            tabRow.CssClass = "danger"
            newCell.Text = "NO"
        End If
        tabRow.Cells.Add(newCell)
        Dim controlsCell As New TableCell
        Dim btnEdit As New Button
        AddHandler btnEdit.Click, AddressOf EditHall
        btnEdit.Text = "Edit"
        btnEdit.Attributes.Add("TAG", dr(2))
        btnEdit.Attributes.Add("SLNO", slno - 1)
        btnEdit.CssClass = "btn btn-warning btn-sm"
        btnEdit.CausesValidation = False
        controlsCell.Controls.Add(btnEdit)
        Dim btnDelete As New Button
        AddHandler btnDelete.Click, AddressOf DeleteHall
        btnDelete.Text = "Remove Hall"
        btnDelete.Attributes.Add("TAG", dr(2))
        btnDelete.CssClass = "btn btn-danger btn-sm"
        controlsCell.Controls.Add(btnDelete)
        tabRow.Cells.Add(controlsCell)
        HallTable.Rows.Add(tabRow)
    End Sub
    Private Sub DeleteHall(ByVal sender As Object, ByVal e As EventArgs)
        Dim hallid As String = CType(sender, Button).Attributes("TAG")
        Dim cs As String = My.Settings.UsersConnection
        Dim conn As New SqlConnection(cs)
        Dim cmd As New SqlCommand("delete from HallData where hallid='" + hallid + "'", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        Response.Redirect("adminManageHalls.aspx")
    End Sub
    Private Sub EditHall(ByVal sender As Object, ByVal e As EventArgs)
        Session.Add("HALLEDITID", CType(sender, Button).Attributes("TAG"))
        Response.Redirect("~/Admin/adminEditHall.aspx")
    End Sub
End Class
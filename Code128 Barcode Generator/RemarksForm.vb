Imports System.Data.OleDb
Public Class RemarksForm
    Public identifier As Integer
    Private Sub RemarksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateRemarks()
    End Sub

    Private Sub populateRemarks()
        sql = "SELECT * FROM REMARKS ORDER BY MARK_ID DESC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.RemarksDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CountMarkID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS REMARK_ID FROM REMARKS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("REMARK_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.RemarksItemNoTextBox.Text = cmid + 1
        identifier = cmid + 1
    End Sub

    Private Sub RemarksAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksAddButton.Click
        CountMarkID()
        Me.RemarksItemNameTextBox.Clear()
        Me.RemarksConditionTextBox.Clear()
        Me.DateExamineDateTimePicker = Nothing
        Me.RemarksItemNameTextBox.Focus()
        Me.ReceiptnoTextBox.Text = "RECEIPT" & ReceiptnoTextBox.Text & Today.Day & Today.Month & Today.Year
    End Sub

    Private Sub RemarksSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksSaveButton.Click
        sql = "INSERT INTO REMARKS (MARK_ID, I_ID, ITEM_NAME, CONDITION, MARK_DATE, RECEIPTNO)VALUES(" & CInt(Me.RemarksItemNoTextBox.Text) & ", " & identifier & ", '" & RemarksItemNameTextBox.Text & "', '" & RemarksConditionTextBox.Text & "', '" & DateExamineDateTimePicker.Text & "', '" & ReceiptnoTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("An has been remarked!")
            populateRemarks()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub RemarksUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksUpdateButton.Click
        sql = "UPDATE REMARKS SET ITEM_NAME='" & RemarksItemNameTextBox.Text & "', CONDITION='" & RemarksConditionTextBox.Text & "', MARK_DATE='" & DateExamineDateTimePicker.Text & "', RECEIPTNO='" & ReceiptnoTextBox.Text & "' WHERE I_ID=" & CInt(RemarksItemNoTextBox.Text) & ""
    End Sub

    Private Sub RemarksConditionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksConditionButton.Click
        conditionForm.Show()
    End Sub
End Class
Imports System.Data.OleDb
Public Class SearchType

    Private Sub SearchType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populatecat()
    End Sub
    Private Sub populatecat()
        sql = "SELECT CAT_NAME FROM CATEGORY"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            Do While dr.Read
                Me.SearchComboBox.Items.Add(dr("CAT_NAME"))
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchComboBox.SelectedIndexChanged
        sql = "SELECT CAT_NO FROM CATEGORY WHERE CAT_NAME= '" & Me.SearchComboBox.SelectedItem & "'"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            mainForm.CategoryTextBox.Text = dr("CAT_NO")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        mainForm.type = SearchComboBox.SelectedItem
        Me.Close()
    End Sub

End Class
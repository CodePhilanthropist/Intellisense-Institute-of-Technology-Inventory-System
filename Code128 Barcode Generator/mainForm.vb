Imports System.Data.OleDb
Public Class mainForm
    Public type As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        SaveFileDialog1.FileName = "Barcode" & Today.Day & Today.Month & Today.Year
        SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        SaveFileDialog1.Filter = "All files (*.*)|*.*|PNG files (*.png)|*.png"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName <> "" Then
            PictureBox1.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)

        End If
    End Sub


    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateItems()
    End Sub

    Private Sub CountBorrowID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS ITEM_ID FROM ITEMS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("ITEM_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.ItemNoTextBox.Text = cmid + 1
    End Sub

    Private Sub SerialNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialNumberTextBox.TextChanged
        PictureBox1.BackgroundImage = Code128(SerialNumberTextBox.Text, "B")
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        End
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub ShowItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowItems.Show()
    End Sub

    Private Sub populateItems()
        sql = "SELECT * FROM ITEMS ORDER BY I_ID DESC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.ItemsDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


    Private Sub RemarksButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksButton.Click
        RemarksForm.Show()
    End Sub

    Private Sub AddButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        CountBorrowID()

        Me.DescriptionTextBox.Clear()
        Me.QuanityTextBox.Clear()
        Me.ValueTextBox.Clear()
        Me.SerialNumberTextBox.Clear()
        Me.ItemNameTextBox.Focus()

    End Sub

    Private Sub SaveCurrentButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCurrentButton.Click
        sql = "INSERT INTO ITEMS(I_ID, ITEM_NAME, DESCRIPTION, QUANTITY, CATEGORY, WORTH, SERIAL_NO)VALUES(" & CInt(Me.ItemNoTextBox.Text) & ", '" & Me.ItemNameTextBox.Text & "', '" & Me.DescriptionTextBox.Text & "', " & CInt(Me.QuanityTextBox.Text) & ", '" & CInt(Me.CategoryTextBox.Text) & "', " & CDbl(Me.ValueTextBox.Text) & ", '" & Me.SerialNumberTextBox.Text & "' )"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("New item has been added!")
            populateItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub UpdateButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        sql = "UPDATE ITEMS SET ITEM_NAME='" & ItemNameTextBox.Text & "', DESCRIPTION='" & DescriptionTextBox.Text & "', QUANTITY=" & CInt(QuanityTextBox.Text) & ", CATEGORY=" & CInt(CategoryTextBox.Text) & ", WORTH=" & CDbl(ValueTextBox.Text) & ", SERIAL_NO='" & SerialNumberTextBox.Text & "' WHERE I_ID=" & CInt(ItemNoTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("The item has been updated!")
            populateItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchTypeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTypeButton.Click
        SearchType.Show()
    End Sub
End Class

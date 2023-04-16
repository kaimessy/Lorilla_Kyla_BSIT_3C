Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form2

    Private Sub LoadCsvData(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim csvData As List(Of String()) = DirectCast(e.Result, List(Of String()))
        Dim header As String() = csvData(0)

        'Create new table and add columns for each field in the header row
        Dim dt As New DataTable()
        For Each colName As String In header
            dt.Columns.Add(New DataColumn(colName, GetType(String)))
        Next

        'Add the row/s to the table
        For i As Integer = 1 To csvData.Count - 1
            Dim fields As String() = csvData(i)
            Dim row As DataRow = dt.NewRow()
            row.ItemArray = fields
            dt.Rows.Add(row)
        Next

        'Set Data source property of DataGridView to the table
        DataGridView1.DataSource = dt
    End Sub

    Private Sub UploadCsvButton_Click(sender As Object, e As EventArgs) Handles UploadCsvButton.Click
        'Allow user to upload a CSV file
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        'Once the file is uploaded, it will parse in the background
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName
            Dim bgWorker As New BackgroundWorker()
            AddHandler bgWorker.DoWork, AddressOf ParseCsvFile
            AddHandler bgWorker.RunWorkerCompleted, AddressOf LoadCsvData
            bgWorker.RunWorkerAsync(fileName)
        End If
    End Sub

    Private Sub ParseCsvFile(sender As Object, e As DoWorkEventArgs)
        'This method is run on a background thread and parses the CSV file
        Dim fileName As String = DirectCast(e.Argument, String)
        Dim csvData As New List(Of String())
        Using reader As New StreamReader(fileName)
            While Not reader.EndOfStream
                'Read every line in the CSV file and split it into fields
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(","c)
                'Adds the fields to the csvData list
                csvData.Add(fields)
            End While
        End Using
        e.Result = csvData
    End Sub

    Private Sub BackupCsvButton_Click(sender As Object, e As EventArgs) Handles BackupCsvButton.Click
        'Check if there are rows in the DataGridView
        If DataGridView1.Rows.Count = 0 Then
            'Ask user if they still want to create a backup
            Dim result As DialogResult = MessageBox.Show("Error: DataGridView is empty. Do you still want to create a backup?", "Backup Empty DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
        End If

        'Create new SaveFileDialog instance
        Dim saveFileDialog1 As New SaveFileDialog()
        'Set the filter for the file dialog to CSV files
        saveFileDialog1.Filter = "CSV Files (.csv)|.csv|All Files (.)|."
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'Get selected file name
            Dim fileName As String = saveFileDialog1.FileName
            Using writer As New StreamWriter(fileName)
                'Create a list to hold the header names
                Dim headers As New List(Of String)

                For Each column As DataGridViewColumn In DataGridView1.Columns
                    headers.Add(column.HeaderText)
                Next
                'Write the header names to the CSV file
                writer.WriteLine(String.Join(",", headers))

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim fields As New StringBuilder()
                    For Each cell As DataGridViewCell In row.Cells
                        'Check if the cell has value or not
                        If Not String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                            fields.Append(cell.Value.ToString())
                        End If
                        'Adds a comma after each cell value
                        fields.Append(",")
                    Next
                    'Write the row values to the CSV file and trim the last comma
                    writer.WriteLine(fields.ToString().TrimEnd(","))
                Next
            End Using
            MessageBox.Show("Your Backup was successfully created!")
        End If
    End Sub

    'Declare a new instance of the OpenFileDialog class
    Private openFileDialog1 As New OpenFileDialog()

    'Define constants for the file filter and title of the file selection dialog
    Private Const FILE_FILTER As String = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
    Private Const FILE_SELECT_TITLE As String = "Select a CSV file to delete"

    'Event handler for the Delete CSV button click event
    Private Sub DeleteCsvButton_Click(sender As Object, e As EventArgs) Handles DeleteCsvButton.Click
        'Set the filter and title for the file selection dialog
        openFileDialog1.Filter = FILE_FILTER
        openFileDialog1.Title = FILE_SELECT_TITLE
        openFileDialog1.Multiselect = False

        'Show file dialog and return if the user wants to cancel
        If openFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        'Get path and file name of the chosen file
        Dim filePath As String = openFileDialog1.FileName
        Dim fileName As String = Path.GetFileName(filePath)

        'Display a confirmation message box to ensure the user wants to delete the selected file
        Dim confirmResult = MessageBox.Show($"Are you sure you want to delete the file {fileName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'Return if user cancel the operation
        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        'This method attempts to delete the chosen file and handle any error or exceptions that may occur
        Try
            File.Delete(filePath)
            MessageBox.Show("File was Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show($"Error: A problem occurred while deleting the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show($"Error: Permission Denied: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        'Get current cell 
        Dim currentCell As DataGridViewCell = DataGridView1.CurrentCell

        'Check if the current cell, rows, and columns has value 
        If currentCell?.RowIndex IsNot Nothing AndAlso currentCell?.ColumnIndex IsNot Nothing Then
            'Get the values and format them into 2 digits
            Dim row As String = (currentCell.RowIndex + 1).ToString("D2")
            Dim column As String = (currentCell.ColumnIndex + 1).ToString("D2")

            'The location of the focused cell is displayed dynamically as text
            CurrentCellTextBox.Text = $"Column {column}     Row {row}"
        Else
            'Clear the text of the CurrentCellTextBox
            CurrentCellTextBox.Text = ""
        End If
    End Sub

    'Once the "ClearGridButton" is clicked, it triggers this event handler
    Private Sub ClearGridButton_Click(sender As Object, e As EventArgs) Handles ClearGridButton.Click

        'Check if the DataGridView is empty
        If DataGridView1.Rows.Count = 0 AndAlso DataGridView1.Columns.Count = 0 Then
            'Show a message that the DataGridView is already empty
            MessageBox.Show("Data Grid View is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Store the rows and columns in the Data Grid View
        Dim rowCount As Integer = DataGridView1.Rows.Count
        Dim columnCount As Integer = DataGridView1.Columns.Count

        'Ask user if they want to delete the DataGridView
        Dim message As String = $"Are you sure you want to clear the DataGridView?{vbCrLf}This will delete {rowCount} rows and {columnCount} columns."

        'Display again a message to confirm the deletion
        Dim result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Once deleted, it set the DataGridView's data source to an empty values
        If result = DialogResult.Yes Then
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub GoToCellButton_Click(sender As Object, e As EventArgs) Handles GoToCellButton.Click
        'Checks if the DataGridView is empty or row/column numbers are not specified
        If DataGridView1.RowCount = 0 OrElse DataGridView1.ColumnCount = 0 OrElse String.IsNullOrEmpty(RowTextBox.Text) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) Then
            'Set the default values to 1 for row and column numbers
            RowTextBox.Text = " "
            ColumnTextBox.Text = " "
            Return
        End If

        'Get the specific number of row and column
        Dim row As Integer = CInt(RowTextBox.Text)
        Dim column As Integer = CInt(ColumnTextBox.Text)

        'Check if it is valid or not
        If row > 0 AndAlso row <= DataGridView1.RowCount AndAlso column > 0 AndAlso column <= DataGridView1.ColumnCount Then
            'Set the current cell and scroll to it
            DataGridView1.CurrentCell = DataGridView1(column - 1, row - 1)
            DataGridView1.FirstDisplayedScrollingRowIndex = row - 1
        Else
            MessageBox.Show("Invalid row or column number.")
        End If
    End Sub

    Private Function IsIndexSpecified(indexTextBox As TextBox) As Boolean
        'Check if the index number is specified in the given text box
        If String.IsNullOrEmpty(indexTextBox.Text) Then
            MessageBox.Show("Oops Incorrect index number.")
            Return False
        End If
        Return True
    End Function

    Private Sub RemoveRowButton_Click(sender As Object, e As EventArgs) Handles RemoveRowButton.Click
        'Check user input
        Dim rowNumber As Integer
        If String.IsNullOrEmpty(RowTextBox.Text) OrElse Not Integer.TryParse(RowTextBox.Text, rowNumber) Then
            MessageBox.Show("Invalid Row number")
            Return
        End If
        'Adjust row number if the column headers are visible
        If DataGridView1.ColumnHeadersVisible Then
            rowNumber -= 1
        End If

        'Check if the row number is within the range of the number of rows in DataGridView1
        If rowNumber < 0 OrElse rowNumber >= DataGridView1.Rows.Count Then
            MessageBox.Show($"Row number {rowNumber + 1} does not exist")
            Return
        End If

        'Ask user before removing the row
        Dim result = MessageBox.Show($"Are you sure you want to remove row number {rowNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Finally remove the row
            DataGridView1.Rows.RemoveAt(rowNumber)
        End If
    End Sub

    Private Sub RemoveColumnButton_Click(sender As Object, e As EventArgs) Handles RemoveColumnButton.Click
        'Check user input
        Dim columnNumber As Integer
        If Not IsIndexSpecified(ColumnTextBox) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) OrElse Not Integer.TryParse(ColumnTextBox.Text, columnNumber) Then
            MessageBox.Show("Invalid Column number")
            Return
        End If
        columnNumber -= 1

        'Check if the column number is within the range of the number of columns
        If columnNumber < 0 OrElse columnNumber >= DataGridView1.Columns.Count Then
            MessageBox.Show($"Column number {columnNumber + 1} does not exist")
            Return
        End If

        'Confirm the user before removing the column
        Dim result = MessageBox.Show($"Are you sure you want to remove column number {columnNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Finally remove the column
            DataGridView1.Columns.RemoveAt(columnNumber)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            'Convert the row and column index to a string and display it in RowTextBox
            RowTextBox.Text = $"{e.RowIndex + 1}"
            ColumnTextBox.Text = $"{e.ColumnIndex + 1}"
        Else
            'Clear row and column text 
            RowTextBox.Clear()
            ColumnTextBox.Clear()
        End If
    End Sub

End Class

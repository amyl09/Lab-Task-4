'AMYLIANA DARA BT MOHAMMAD
'20DDT21F2006
Imports System.Data.SqlClient

Public Class author
    Dim connection As New SqlConnection("Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;")
    Public Sub DataGridView()
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM author " 'query table author from db
        Dim command As New SqlCommand(query, connection)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = command
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridViewAuthor.DataSource = dt
    End Sub
    Private Sub LoadInfo()
        Try
            Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM author"
                Dim command As New SqlCommand(query, connection)

                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Create a new DataTable
                    Dim dt As New DataTable()
                    dt.Load(reader)

                    ' Bind the DataTable to the DataGridView
                    DataGridViewAuthor.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO author VALUES (@author_id,@author_name)" 'query insert new data to db author
        Dim command As New SqlCommand(query, connection)
        'parameter for values
        command.Parameters.AddWithValue("@author_id", txtAuthorId.Text)
        command.Parameters.AddWithValue("@author_name", txtAuthorName.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        'msgbox if user click yes then new data inserted
        Dim confirmsg = MessageBox.Show("Do you want to add new data?", "Insert Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmsg = DialogResult.Yes Then
            MsgBox("New data has been Inserted!", MessageBoxIcon.Information)
            LoadInfo()
            'clear the textbox
            txtAuthorId.Clear()
            txtAuthorName.Clear()
        End If


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT author_name  FROM author WHERE author_id= '" & txtAuthorId.Text & "'"
        Dim command As New SqlCommand(query, connection)

        connection.Open()
        Using dr As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read() Then
                'read the value and insert to textbox
                txtAuthorName.Text = dr("author_name").ToString
                DataGridView()
            Else
                MsgBox("Data is not existed!", MessageBoxIcon.Error)
                txtAuthorId.Clear()
                txtAuthorName.Clear()

            End If

        End Using
    End Sub

    Private Sub btnInnerJoin_Click(sender As Object, e As EventArgs) Handles btnInnerJoin.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT author.author_id , author.author_name, software.software_name  FROM  author 
                                    INNER JOIN  software ON author.author_id =software.author_id" 'mesti type int PK
        Dim command As New SqlCommand(query, connection)
        Dim da As New SqlDataAdapter
        da.SelectCommand = command
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridViewAuthor.DataSource = dt
    End Sub

    Private Sub CRUDSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDSoftwareToolStripMenuItem.Click
        'will go to software form
        software.Show()
        Me.Hide()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        'will go to about form
        about.Show()
        Me.Hide()

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        'will go to home form
        homee.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the app
        Application.Exit()

    End Sub

    Private Sub author_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "Server=localhost;Database=SRS;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM author ORDER BY author_id" 'query software from db
            Dim command As New SqlCommand(query, connection)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridViewAuthor.DataSource = dt
            DataGridViewAuthor.AllowUserToAddRows = False

            'add update btn column
            Dim updatebtncolumn As New DataGridViewButtonColumn
            updatebtncolumn.UseColumnTextForButtonValue = True
            updatebtncolumn.HeaderText = "Update Data"
            updatebtncolumn.Width = 100
            updatebtncolumn.Text = "Update"
            'update btn style
            updatebtncolumn.DefaultCellStyle.BackColor = Color.Green
            updatebtncolumn.DefaultCellStyle.ForeColor = Color.White
            updatebtncolumn.FlatStyle = FlatStyle.Flat
            DataGridViewAuthor.Columns.Insert(2, updatebtncolumn)

            'add delete btn column
            Dim deletebtncolumn As New DataGridViewButtonColumn
            deletebtncolumn.UseColumnTextForButtonValue = True
            deletebtncolumn.HeaderText = "Delete Row"
            deletebtncolumn.Width = 100
            deletebtncolumn.Text = "Delete"
            'delete btn style
            deletebtncolumn.DefaultCellStyle.BackColor = Color.Red
            deletebtncolumn.DefaultCellStyle.ForeColor = Color.White
            deletebtncolumn.FlatStyle = FlatStyle.Flat
            DataGridViewAuthor.Columns.Insert(3, deletebtncolumn)
        Catch
        End Try
    End Sub

    Private Sub DataGridViewAuthor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAuthor.CellContentClick
        'update button is selected
        If e.ColumnIndex = 2 Then
            Dim confirmsg = MessageBox.Show("Are you sure to update the data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewAuthor.Rows(e.RowIndex)
                'update query
                Dim cmd2 As New SqlCommand("UPDATE author SET author_name=@author_name WHERE author_id=@author_id", connection)
                cmd2.Parameters.AddWithValue("@author_name", r1.Cells("author_name").Value)
                cmd2.Parameters.AddWithValue("@author_id", r1.Cells("author_id").Value)

                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

                'refresh the data gridview
                DataGridViewAuthor.Refresh()

            End If
            'delete button selected
        ElseIf e.ColumnIndex = 3 Then
            Dim confirmsg = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewAuthor.Rows(e.RowIndex)

                'delete from db
                Dim cmd2 As New SqlCommand("DELETE FROM author WHERE author_id=@author_id", connection)
                cmd2.Parameters.AddWithValue("@author_id", r1.Cells("author_id").Value)
                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

                'refresh the datagridview to reflect the updated data
                DataGridViewAuthor.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class
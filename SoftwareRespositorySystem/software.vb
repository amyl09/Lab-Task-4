'AMYLIANA DARA BT MOHAMMAD
'20DDT21F2006

Imports System.Data.SqlClient

Public Class software
    Dim connection As New SqlConnection("Server=localhost;Database=SRS;User ID=mell;Password=passw0rd")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO software VALUES (@id_software,@author_id,@software_name)" 'query insert new data to db software
        Dim command As New SqlCommand(query, connection)
        'parameter for values
        command.Parameters.AddWithValue("@id_software", txtId.Text)
        command.Parameters.AddWithValue("@author_id", txtAuthorId.Text)
        command.Parameters.AddWithValue("@software_name", txtSoftName.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        'msgbox if user click yes then new data inserted
        Dim confirmsg = MessageBox.Show("Do you want to add new data?", "Insert Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmsg = DialogResult.Yes Then
            MsgBox("New data has been inserted!", MessageBoxIcon.Information)
            DataGridView()
            'clear the textbox
            txtId.Clear()
            txtAuthorId.Clear()
            txtSoftName.Clear()
        End If

    End Sub

    'to display in data grid view
    Public Sub DataGridView()
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM software " 'query from table software
        Dim command As New SqlCommand(query, connection)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = command
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridViewSoftware.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT author_id,software_name  FROM software WHERE id_software= '" & txtId.Text & "'"
        Dim command As New SqlCommand(query, connection)

        connection.Open()
        Using dr As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
            'read the value and insert to textbox
            If dr.Read() Then
                txtAuthorId.Text = dr("author_id").ToString
                txtSoftName.Text = dr("software_name").ToString
                DataGridView()
            Else
                MsgBox("Data is not existed!", MessageBoxIcon.Error)
                txtAuthorId.Clear()
                txtSoftName.Clear()
            End If
        End Using
    End Sub

    Private Sub btnInnerJoin_Click(sender As Object, e As EventArgs) Handles btnInnerJoin.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT software.id_software, software.software_name , author.author_name FROM  software 
                                    INNER JOIN  author ON software.author_id = author.author_id" 'mesti type int PK
        Dim command As New SqlCommand(query, connection)
        Dim da As New SqlDataAdapter
        da.SelectCommand = command
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridViewSoftware.DataSource = dt

    End Sub

    Private Sub AboutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub CRUDAuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDAuthorToolStripMenuItem.Click
        'will go to author form
        author.Show()
        Me.Hide()

    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        'will go to home form
        homee.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the app
        Application.Exit()

    End Sub

    Private Sub software_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "Server=localhost;Database=SRS;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM software ORDER BY id_software" 'query software from db
            Dim command As New SqlCommand(query, connection)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridViewSoftware.DataSource = dt
            DataGridViewSoftware.AllowUserToAddRows = False

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
            DataGridViewSoftware.Columns.Insert(3, updatebtncolumn)

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
            DataGridViewSoftware.Columns.Insert(4, deletebtncolumn)
        Catch
        End Try
    End Sub

    Private Sub DataGridViewSoftware_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSoftware.CellContentClick
        'update button is selected
        If e.ColumnIndex = 3 Then
            Dim confirmsg = MessageBox.Show("Are you sure to update the data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewSoftware.Rows(e.RowIndex)
                'update query
                Dim cmd2 As New SqlCommand("UPDATE software SET author_id=@author_id, software_name=@software_name WHERE id_software=@id_software", connection)
                cmd2.Parameters.AddWithValue("@author_id", r1.Cells("author_id").Value)
                cmd2.Parameters.AddWithValue("@software_name", r1.Cells("software_name").Value)
                cmd2.Parameters.AddWithValue("@id_software", r1.Cells("id_software").Value)

                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()
                'refresh the data gridview
                DataGridViewSoftware.Refresh()
            End If
            'delete button selected
        ElseIf e.ColumnIndex = 4 Then
            Dim confirmsg = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewSoftware.Rows(e.RowIndex)

                'delete from db
                Dim cmd2 As New SqlCommand("DELETE FROM software WHERE id_software=@id_software", connection)
                cmd2.Parameters.AddWithValue("@id_software", r1.Cells("id_software").Value)
                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

                'refresh the datagridview to reflect the updated data
                DataGridViewSoftware.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class
'AMYLIANA DARA
'20DDT21F2006

Imports System.Data.SqlClient
Public Class homee

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM login WHERE username=@nama AND password=@katalaluan" 'query for select user and password from db
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@nama", txtUser.Text) 'parameter for username
        command.Parameters.AddWithValue("@katalaluan", txtPass.Text) 'parameter for password
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'logged on the system if pass & user is exist in db
            MsgBox("You're logged on the system", MessageBoxIcon.Information)
            Me.Hide()
            software.Show()
        Else
            'display msgbox if pass & user is not exist in db
            MsgBox("Unauthorized User !!", MessageBoxIcon.Warning)
        End If
        'clear textbox
        txtUser.Clear()
        txtPass.Clear()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset textbox
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub LinkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignUp.LinkClicked
        'will go to register form
        AddAccount.Show()
        Me.Hide()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'will go to about form
        about.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the app
        Application.Exit()
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        'if checkbox is click then the password will be displayed
        If CheckBoxPass.Checked = True Then
            txtPass.UseSystemPasswordChar = True
        Else
            'if checkbox is unclick then the password will not be displayed
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class
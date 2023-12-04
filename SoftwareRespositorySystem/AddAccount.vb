
'AMYLIANA DARA BT MOHAMMAD
'20DDT21F2006
Imports System.Data.SqlClient

Public Class AddAccount
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'will go to home form
        homee.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim connectionString As String = "Server=localhost;Database=SRS;User Id=mell;Password=passw0rd;"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO login (username,password) VALUES (@nama,@katalaluan)" 'query for insert new user and password to db
        connection.Open()
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@nama", txtUser.Text) 'parameter for username
        command.Parameters.AddWithValue("@katalaluan", txtPass.Text) 'parameter for password
        command.ExecuteNonQuery()
        'msgbox
        MsgBox("New User Successfully Added!", MessageBoxIcon.Information)
        'clear the text after new user is added
        txtPass.Clear()
        txtUser.Clear()

    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        'if checkbox is click then the password will be displayed
        If CheckBoxPass.Checked = True Then
            txtPass.UseSystemPasswordChar = True
        Else
            'if checkbox is click then the password will be displayed
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub


End Class
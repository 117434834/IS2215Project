Public Class frmLogIn
#Region "Placeholders"

    Private Sub txtUsername_OnFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        'Clear the placeholder
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtUsername_OffFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        'Insert Placeholder
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_OnFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        'Clear the placeholder
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_OffFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        'Insert Placeholder
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

#End Region

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Insert Placeholder for Username
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray

        'Insert Placeholder for Password
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        For i As Integer = 0 To gintNumberOfUsers
            If userArray(i).checkPassword(txtPassword.Text) Then
                'Show next form and hide this form
            End If
        Next
    End Sub
End Class

Public Class frmSplashScreen
    Private gintCounter As Integer


#Region "Instantiate User objects"
    Dim objConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = UserData.accdb")
    Dim objUserDA As New OleDb.OleDbDataAdapter("Select * from Users", objConnection)
    Dim objUserCB As New OleDb.OleDbCommandBuilder(objUserDA)
    Dim objDataSet As New DataSet()



    Private Sub frmSplashScreen_LoadInstantiate(sender As Object, e As EventArgs) Handles MyBase.Load
        objDataSet.Clear()
        objUserDA.FillSchema(objDataSet, SchemaType.Source, "Users")
        objUserDA.Fill(objDataSet, "Users")
        gintNumberOfUsers = objDataSet.Tables("Users").Rows.Count

        ReDim userArray(gintNumberOfUsers)


        'Instantiate Class and create all objects
        For i = 0 To gintNumberOfUsers - 1
            userArray(i).Username = objDataSet.Tables("Users").Rows(i).Item("Username")
            userArray(i).Password = objDataSet.Tables("Users").Rows(i).Item("Password")
            userArray(i).ID = i + 1
        Next
    End Sub


#End Region
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        'Increase progress bar every tick
        prgSplash.Increment(1)
        gintCounter += 1
        'Open new form on 120 (allows time for progress bar to actually fill
        If gintCounter = 120 Then
            tmrSplash.Enabled = False
            frmLogIn.Show()
            Me.Close()

        End If
    End Sub

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset Counter and progress bar
        gintCounter = 0
        prgSplash.Value = 0
    End Sub
End Class
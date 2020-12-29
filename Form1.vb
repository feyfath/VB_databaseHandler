Imports System.Data.SqlClient
Public Class Form1
    Private cnx As SqlConnection
    Private cmd As SqlCommand
    Private reader As SqlDataReader
    Private results As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx = New SqlConnection("Initial Catalog=db_planification;" &
 "Data Source=fath-device;Integrated Security=SSPI;")
        cmd = cnx.CreateCommand
        cmd.CommandText = "SELECT * FROM test"
        cnx.Open()



        reader = cmd.ExecuteReader()
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            results = results & reader.GetString(0) & vbTab &
            reader.GetString(1) & vbLf
        Loop
        'Display results.
        MsgBox(results)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For Each Archivo As String In My.Computer.FileSystem.GetFiles(
            "C:\Windows\System32",
            FileIO.SearchOption.SearchTopLevelOnly,
            "*.dll")
            ListBox1.Items.Add(Archivo)
        Next
        Label1.Text = ListBox1.Items.Count

    End Sub
End Class

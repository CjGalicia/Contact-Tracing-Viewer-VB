Imports System.IO
Public Class Form1
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("D:\Program Files (x86)\Microsoft Visual Studio\source\repos-1\Contact-tracing-viewer-VB\Contact-tracing-viewer-VB\bin\Debug\ContactTracingForm.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        displayBox.Text = fileReader.ReadToEnd
        fileReader.Close()
    End Sub

    Private Sub importBtn_Click(sender As Object, e As EventArgs) Handles importBtn.Click
        Dim formReader As StreamReader
        Dim fileOpener As DialogResult
        fileOpener = OpenFileDialog1.ShowDialog

        If fileOpener Then
            formReader = New StreamReader(OpenFileDialog1.FileName)
            displayBox.Text = formReader.ReadToEnd
            formReader.Close()
        End If

    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        displayBox.Clear()
    End Sub
End Class

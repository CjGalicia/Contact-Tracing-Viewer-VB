Imports System.IO
Public Class Form1
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("D:\Program Files (x86)\Microsoft Visual Studio\source\repos-1\Contact-tracing-viewer-VB\Contact-tracing-viewer-VB\bin\Debug\ContactTracingForm.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        displayBox.Text = fileReader.ReadToEnd
    End Sub
End Class

Imports System.Text
Public Class MainForm1
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private rand As New Random()
    Private Sub MainForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateBox.Clear()
        For i As Integer = 1 To 100
            GenerateBox.AppendText("https://discord.gift/" & GenerateCodes(16) & Environment.NewLine)
        Next
    End Sub
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub
    Private Function GenerateCodes(length As Integer) As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder()
        For i As Integer = 1 To length
            sb.Append(chars(rand.Next(chars.Length)))
        Next
        Return sb.ToString()
    End Function

    Private Sub MainForm1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub MainForm1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub MainForm1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
    End Sub
End Class

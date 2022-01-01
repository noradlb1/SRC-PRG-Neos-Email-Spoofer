Imports System.Net
Imports System.Net.Mail
Public Class Form1

    ' Credit : Neos07
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try
            Dim client As New SmtpClient
            Dim message As New MailMessage
            client.UseDefaultCredentials = False
            client.Credentials = New NetworkCredential(Me.TextBox1.Text, Me.TextBox2.Text)
            client.Port = &H24B
            client.EnableSsl = True
            client.Host = "smtp.gmail.com"
            message = New MailMessage
            message.From = New MailAddress(Me.TextBox1.Text, Me.TextBox3.Text)
            message.To.Add(Me.TextBox4.Text)
            message.Subject = Me.TextBox5.Text
            message.IsBodyHtml = False
            message.Body = Me.TextBox6.Text
            client.Send(message)
            MsgBox("Mail Sent", MsgBoxStyle.ApplicationModal, Nothing)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FlatComboBox1.Text = "smtp.gmail.com"
    End Sub
End Class

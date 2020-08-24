Imports System.Net.Mail
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mail As New MailMessage()
        Dim smtp As New SmtpClient()

        'mail.To.Add("dclausen@tpg-partners.com")
        mail.To.Add("david@EmphasisTech.net")
        mail.From = New MailAddress("nick.smith@argentglobal.com")
        'mail.From = New MailAddress("dclausen777@gmail.com")

        mail.Subject = "report attached: "
        mail.Body = "Proudly delivered to you, by The Roadrunner Express and The Coyote!  Powered by Acme Inc."

        smtp.Host = "smtp.fusemail.net"
        'smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New System.Net.NetworkCredential("nick.smith@argentglobal.com", "all5fusion")
        'smtp.Credentials = New System.Net.NetworkCredential("dclausen777@gmail.com", "#PraiseH1m!")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.Send(mail)

        'Try
        '        smtp.Send(mail)
        '    Catch ex As Exception
        '        MsgBox("Error")
        '    End Try

        MsgBox("Message Sent")
    End Sub
End Class

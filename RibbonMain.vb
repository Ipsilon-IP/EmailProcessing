Imports Microsoft.Office.Tools.Ribbon

Public Class RibbonMain
    Private Sub RibbonEmail_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load


    End Sub

    Private Sub EmailInstruction_Click(sender As Object, e As RibbonControlEventArgs) Handles EmailInstruction.Click
        Dim cur_mail As Outlook.MailItem
        MsgBox(cur_mail.Subject)
    End Sub


    Function LoadMail(e As RibbonControlEventArgs)
        If (MyBase.RibbonType = "Microsoft.Outlook.Explorer") Then
            LoadMail = e.Control.Context
        ElseIf (MyBase.RibbonType = "Microsoft.Outlook.Mail.Read") Then   
            LoadMail = e.Control.Context
        End If
    End Function

    Private Sub Options_Click(sender As Object, e As RibbonControlEventArgs) Handles Options.Click
        Dim Form_Opt As New FormOptions

        ' Show Forms (Wait closing for continue script)
        Form_Opt.ShowDialog()
    End Sub
End Class

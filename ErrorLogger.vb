Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms


Public Class ErrorLogger

    ''' <summary>
    ''' Log error on bdd if connected else do nothing
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="stacktrace"></param> 
    ''' <param name="email"></param>
    ''' <param name="SQLRequest"></param>
    ''' <param name="level"></param>  
    '''     
    Public Shared Sub WriteToErrorLog(ByVal message As String, ByVal stacktrace As String, ByVal function_name As String, Optional ByVal email As Outlook.MailItem = Nothing, Optional ByVal SQLRequest As String = Nothing, Optional ByVal level As Enums.ErrorLvL = Enums.ErrorLvL.Medium)
        Try
            Dim user As String
            Try
                user = Globals.EmailProcessing.cur_user.username
            Catch ex As Exception
                user = "not loaded"
            End Try

            Dim Requete As String = "INSERT INTO [dbo].[error] " _
                            & "([user] " _
                            & ",[stacktrace] " _
                            & ",[message] " _
                            & ",[level] " _
                            & ",[date] " _
                            & "VALUES " _
                            & "(" _
                            & ",'" & Functions.ReplaceQuote(user) & "' " _
                            & ",'" & Functions.ReplaceQuote(stacktrace) & "' " _
                            & ",'" & Functions.ReplaceQuote(message) & "' " _
                            & "," & level & " " _
                            & ",GETDATE()" _
                            & ")"
            Dim Commande As New SqlCommand(Requete, ORM.db_connect)
            Try
                Commande.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(message)
            End Try
        Catch ex As Exception
            'do nothing
        End Try
    End Sub
End Class


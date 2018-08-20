Imports EmailProcessing.Structures
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class EmailProcessing
    ' Load ressource file (to customize)
    Public RM = New Resources.ResourceManager("EmailProcessing.ResourceMain", Reflection.Assembly.GetExecutingAssembly)

    ' Current user
    Public cur_user As New Structures.User

    ''' <summary>
    ''' On startup Add-in
    ''' </summary>
    Private Sub EmailProcessing_Startup() Handles Me.Startup
        Try
            ' Load user
            cur_user = UserLoad()
        Catch ex As Exception
            ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, System.Reflection.MethodInfo.GetCurrentMethod.Name)
        End Try
    End Sub


    ''' <summary>
    ''' Load user from AD or current login username
    ''' </summary>
    ''' <returns></returns>
    Function UserLoad() As Structures.User
        'Load from AD
        Dim currentADUser As DirectoryServices.AccountManagement.UserPrincipal
        UserLoad = New Structures.User
        UserLoad.enabled = True
        Try
            currentADUser = System.DirectoryServices.AccountManagement.UserPrincipal.Current
            UserLoad.name = currentADUser.Name
            UserLoad.first_name = currentADUser.GivenName
            UserLoad.email_address = currentADUser.EmailAddress
            UserLoad.username = currentADUser.Surname
        Catch
            Try
                UserLoad.username = Environment.UserName
            Catch ex As Exception
                UserLoad.enabled = False
                ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, System.Reflection.MethodInfo.GetCurrentMethod.Name)
            End Try
        End Try
    End Function



    ''' <summary>
    ''' On shutdown Add-in
    ''' </summary>
    Private Sub EmailProcessing_Shutdown() Handles Me.Shutdown

    End Sub


    ''' <summary>
    ''' Get current selected mailitem
    ''' </summary>
    ''' <param name="Explorer"></param>
    ''' <returns></returns>
    Function MailSelectedGet(Explorer As Outlook.Explorer) As Outlook.MailItem
        Try
            If Explorer.Selection.Count > 1 Then
                MsgBox("forbid_multiple_select_msg", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "forbid_multiple_select_title")
                MailSelectedGet = Nothing
            Else
                If TypeOf Explorer.Selection.Item(1) Is Outlook.MailItem Then
                    MailSelectedGet = Explorer.Selection.Item(1)
                Else
                    MailSelectedGet = Nothing
                End If
            End If
        Catch ex As Exception
            MailSelectedGet = Nothing
            ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, System.Reflection.MethodInfo.GetCurrentMethod.Name, level:=Enums.ErrorLvL.VeryLow)
        End Try
    End Function
End Class

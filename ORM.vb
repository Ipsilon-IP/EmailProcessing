Imports System.Data.SqlClient

Public Class ORM
    ''' <summary>
    ''' Connect to database
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function db_connect() As SqlConnection
        Try
            db_connect = New SqlConnection()
            db_connect.ConnectionString = Globals.EmailProcessing.RM.GetString("db_connect")
            db_connect.Open()
        Catch ex As Exception
            db_connect = Nothing
            ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, "Erreur", level:=Enums.ErrorLvL.VeryHigh)
        End Try
    End Function

    ''' <summary>
    ''' Disconnect from database
    ''' </summary>
    ''' <param name="db_co"></param>
    ''' <returns></returns>
    Public Shared Function db_disconnect(db_co As SqlConnection) As Boolean
        Try
            db_co.Close()
            db_disconnect = True
        Catch ex As Exception
            db_disconnect = False
            ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, "Erreur", level:=Enums.ErrorLvL.VeryHigh)
        End Try
    End Function
End Class

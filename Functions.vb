Public Class Functions

    ''' <summary>
    ''' Replace Single Quote by double quote
    ''' </summary>
    ''' <param name="Text"></param>
    ''' <returns></returns>
    Public Shared Function ReplaceQuote(Text As String) As String
        Try
            If Text <> "" Then
                ReplaceQuote = Text.Replace("'", "''")
            Else
                ReplaceQuote = Text
            End If
        Catch ex As Exception
            ErrorLogger.WriteToErrorLog(ex.Message, ex.StackTrace, System.Reflection.MethodInfo.GetCurrentMethod.Name)
            ReplaceQuote = Text
        End Try
    End Function
End Class

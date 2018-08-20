Public Class Structures
    ''' <summary>
    ''' Entity
    ''' </summary>
    Public Structure Entity
        Dim name As String
        Dim sql_server As String
        Dim sql_instance As String
        Dim shared_folder_path As String
    End Structure

    ''' <summary>
    ''' User
    ''' </summary>
    Public Structure User
        Dim user_id As Integer
        Dim username As String
        Dim initial As String
        Dim name As String
        Dim first_name As String
        Dim email_address As String
        Dim print_page As String
        Dim enabled As Boolean
    End Structure

    ''' <summary>
    ''' Group
    ''' </summary>
    Public Structure Group
        Dim group_id As Integer
        Dim name As String
        Dim users() As User
    End Structure

    ''' <summary>
    ''' GiveInstruction
    ''' </summary>
    Public Structure GiveInstruction
        Dim give_instruction_id As Integer
        Dim give_user As User
        Dim execute_user As User
        Dim email As Email
        Dim instruction As Instruction
    End Structure

    ''' <summary>
    ''' ExecuteInstruction
    ''' </summary>
    Public Structure ExecuteInstruction
        Dim execute_instruction_id As Integer
        Dim give_instruction As GiveInstruction
        Dim instruction As Instruction
    End Structure

    ''' <summary>
    ''' Instruction
    ''' </summary>
    Public Structure Instruction
        Dim instruction_id As Integer
    End Structure

    ''' <summary>
    ''' Email
    ''' </summary>
    Public Structure Email
        Dim email_id As Integer
        Dim subject As String
        Dim dossiers() As Dossier
    End Structure

    ''' <summary>
    ''' Dossier
    ''' </summary>
    Public Structure Dossier
        Dim dossier_id As Integer
        Dim title As String
        Dim reference As String
        Dim country As String
        Dim ref_for_client As String
        Dim status As String
        Dim client As Client
    End Structure

    ''' <summary>
    ''' Client
    ''' </summary>
    Public Structure Client
        Dim name As String
    End Structure
End Class

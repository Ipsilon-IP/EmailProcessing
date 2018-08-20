<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.StatusBlock = New System.Windows.Forms.GroupBox()
        Me.UserActivity = New System.Windows.Forms.ComboBox()
        Me.UserActivityLabel = New System.Windows.Forms.Label()
        Me.UserTypeLabel = New System.Windows.Forms.Label()
        Me.UserType = New System.Windows.Forms.ComboBox()
        Me.UserTypeHelp = New System.Windows.Forms.Label()
        Me.PrintBlock = New System.Windows.Forms.GroupBox()
        Me.PrintPage = New System.Windows.Forms.TextBox()
        Me.PrintPageLabel = New System.Windows.Forms.Label()
        Me.PrintPageHelp = New System.Windows.Forms.Label()
        Me.UserInfoBlock = New System.Windows.Forms.GroupBox()
        Me.Initial = New System.Windows.Forms.TextBox()
        Me.EmailAddress = New System.Windows.Forms.ComboBox()
        Me.InitialLabel = New System.Windows.Forms.Label()
        Me.EmailAddressLabel = New System.Windows.Forms.Label()
        Me.EntityBlock = New System.Windows.Forms.GroupBox()
        Me.Entity = New System.Windows.Forms.ComboBox()
        Me.EntityLabel = New System.Windows.Forms.Label()
        Me.Validate = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.StatusBlock.SuspendLayout()
        Me.PrintBlock.SuspendLayout()
        Me.UserInfoBlock.SuspendLayout()
        Me.EntityBlock.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBlock
        '
        Me.StatusBlock.Controls.Add(Me.UserActivity)
        Me.StatusBlock.Controls.Add(Me.UserActivityLabel)
        Me.StatusBlock.Controls.Add(Me.UserTypeLabel)
        Me.StatusBlock.Controls.Add(Me.UserType)
        Me.StatusBlock.Controls.Add(Me.UserTypeHelp)
        resources.ApplyResources(Me.StatusBlock, "StatusBlock")
        Me.StatusBlock.Name = "StatusBlock"
        Me.StatusBlock.TabStop = False
        '
        'UserActivity
        '
        Me.UserActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserActivity.FormattingEnabled = True
        Me.UserActivity.Items.AddRange(New Object() {resources.GetString("UserActivity.Items"), resources.GetString("UserActivity.Items1"), resources.GetString("UserActivity.Items2"), resources.GetString("UserActivity.Items3")})
        resources.ApplyResources(Me.UserActivity, "UserActivity")
        Me.UserActivity.Name = "UserActivity"
        '
        'UserActivityLabel
        '
        Me.UserActivityLabel.BackColor = System.Drawing.SystemColors.Control
        Me.UserActivityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.UserActivityLabel, "UserActivityLabel")
        Me.UserActivityLabel.Name = "UserActivityLabel"
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.UserTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.UserTypeLabel, "UserTypeLabel")
        Me.UserTypeLabel.Name = "UserTypeLabel"
        '
        'UserType
        '
        Me.UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserType.FormattingEnabled = True
        Me.UserType.Items.AddRange(New Object() {resources.GetString("UserType.Items"), resources.GetString("UserType.Items1")})
        resources.ApplyResources(Me.UserType, "UserType")
        Me.UserType.Name = "UserType"
        '
        'UserTypeHelp
        '
        Me.UserTypeHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.UserTypeHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.UserTypeHelp, "UserTypeHelp")
        Me.UserTypeHelp.Name = "UserTypeHelp"
        '
        'PrintBlock
        '
        Me.PrintBlock.Controls.Add(Me.PrintPage)
        Me.PrintBlock.Controls.Add(Me.PrintPageLabel)
        Me.PrintBlock.Controls.Add(Me.PrintPageHelp)
        resources.ApplyResources(Me.PrintBlock, "PrintBlock")
        Me.PrintBlock.Name = "PrintBlock"
        Me.PrintBlock.TabStop = False
        '
        'PrintPage
        '
        resources.ApplyResources(Me.PrintPage, "PrintPage")
        Me.PrintPage.Name = "PrintPage"
        '
        'PrintPageLabel
        '
        Me.PrintPageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PrintPageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.PrintPageLabel, "PrintPageLabel")
        Me.PrintPageLabel.Name = "PrintPageLabel"
        '
        'PrintPageHelp
        '
        Me.PrintPageHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PrintPageHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.PrintPageHelp, "PrintPageHelp")
        Me.PrintPageHelp.Name = "PrintPageHelp"
        '
        'UserInfoBlock
        '
        Me.UserInfoBlock.Controls.Add(Me.Initial)
        Me.UserInfoBlock.Controls.Add(Me.EmailAddress)
        Me.UserInfoBlock.Controls.Add(Me.InitialLabel)
        Me.UserInfoBlock.Controls.Add(Me.EmailAddressLabel)
        resources.ApplyResources(Me.UserInfoBlock, "UserInfoBlock")
        Me.UserInfoBlock.Name = "UserInfoBlock"
        Me.UserInfoBlock.TabStop = False
        '
        'Initial
        '
        resources.ApplyResources(Me.Initial, "Initial")
        Me.Initial.Name = "Initial"
        '
        'EmailAddress
        '
        Me.EmailAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmailAddress.FormattingEnabled = True
        resources.ApplyResources(Me.EmailAddress, "EmailAddress")
        Me.EmailAddress.Name = "EmailAddress"
        '
        'InitialLabel
        '
        Me.InitialLabel.BackColor = System.Drawing.SystemColors.Control
        Me.InitialLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.InitialLabel, "InitialLabel")
        Me.InitialLabel.Name = "InitialLabel"
        '
        'EmailAddressLabel
        '
        Me.EmailAddressLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EmailAddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.EmailAddressLabel, "EmailAddressLabel")
        Me.EmailAddressLabel.Name = "EmailAddressLabel"
        '
        'EntityBlock
        '
        Me.EntityBlock.Controls.Add(Me.Entity)
        Me.EntityBlock.Controls.Add(Me.EntityLabel)
        resources.ApplyResources(Me.EntityBlock, "EntityBlock")
        Me.EntityBlock.Name = "EntityBlock"
        Me.EntityBlock.TabStop = False
        '
        'Entity
        '
        Me.Entity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Entity.FormattingEnabled = True
        resources.ApplyResources(Me.Entity, "Entity")
        Me.Entity.Name = "Entity"
        '
        'EntityLabel
        '
        Me.EntityLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EntityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.EntityLabel, "EntityLabel")
        Me.EntityLabel.Name = "EntityLabel"
        '
        'Validate
        '
        resources.ApplyResources(Me.Validate, "Validate")
        Me.Validate.Name = "Validate"
        Me.Validate.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.Name = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'FormOptions
        '
        Me.AcceptButton = Me.Validate
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Validate)
        Me.Controls.Add(Me.EntityBlock)
        Me.Controls.Add(Me.PrintBlock)
        Me.Controls.Add(Me.UserInfoBlock)
        Me.Controls.Add(Me.StatusBlock)
        Me.Name = "FormOptions"
        Me.StatusBlock.ResumeLayout(False)
        Me.PrintBlock.ResumeLayout(False)
        Me.PrintBlock.PerformLayout()
        Me.UserInfoBlock.ResumeLayout(False)
        Me.UserInfoBlock.PerformLayout()
        Me.EntityBlock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusBlock As Windows.Forms.GroupBox
    Friend WithEvents UserTypeHelp As Windows.Forms.Label
    Friend WithEvents UserTypeLabel As Windows.Forms.Label
    Friend WithEvents UserType As Windows.Forms.ComboBox
    Friend WithEvents PrintBlock As Windows.Forms.GroupBox
    Friend WithEvents PrintPageLabel As Windows.Forms.Label
    Friend WithEvents PrintPageHelp As Windows.Forms.Label
    Friend WithEvents UserActivity As Windows.Forms.ComboBox
    Friend WithEvents UserActivityLabel As Windows.Forms.Label
    Friend WithEvents UserInfoBlock As Windows.Forms.GroupBox
    Friend WithEvents EmailAddressLabel As Windows.Forms.Label
    Friend WithEvents PrintPage As Windows.Forms.TextBox
    Friend WithEvents EmailAddress As Windows.Forms.ComboBox
    Friend WithEvents InitialLabel As Windows.Forms.Label
    Friend WithEvents Initial As Windows.Forms.TextBox
    Friend WithEvents EntityBlock As Windows.Forms.GroupBox
    Friend WithEvents Entity As Windows.Forms.ComboBox
    Friend WithEvents EntityLabel As Windows.Forms.Label
    Friend WithEvents Validate As Windows.Forms.Button
    Friend WithEvents Cancel As Windows.Forms.Button
End Class

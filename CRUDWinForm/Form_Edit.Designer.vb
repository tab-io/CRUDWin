<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Label_FirstName = New System.Windows.Forms.Label()
        Me.Label_PhoneNumber = New System.Windows.Forms.Label()
        Me.Label_LastName = New System.Windows.Forms.Label()
        Me.Label_EmailAddress = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_FirstName = New System.Windows.Forms.TextBox()
        Me.TextBox_LastName = New System.Windows.Forms.TextBox()
        Me.TextBox_PhoneNumber = New System.Windows.Forms.TextBox()
        Me.TextBox_EmailAddress = New System.Windows.Forms.TextBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox_Edit = New System.Windows.Forms.GroupBox()
        Me.Label_EditHeader = New System.Windows.Forms.Label()
        Me.GroupBox_Edit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(16, 28)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(73, 17)
        Me.Label_Username.TabIndex = 0
        Me.Label_Username.Text = "Username"
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.Location = New System.Drawing.Point(16, 84)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(69, 17)
        Me.Label_Password.TabIndex = 1
        Me.Label_Password.Text = "Password"
        '
        'Label_FirstName
        '
        Me.Label_FirstName.AutoSize = True
        Me.Label_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FirstName.Location = New System.Drawing.Point(201, 26)
        Me.Label_FirstName.Name = "Label_FirstName"
        Me.Label_FirstName.Size = New System.Drawing.Size(76, 17)
        Me.Label_FirstName.TabIndex = 2
        Me.Label_FirstName.Text = "First Name"
        '
        'Label_PhoneNumber
        '
        Me.Label_PhoneNumber.AutoSize = True
        Me.Label_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PhoneNumber.Location = New System.Drawing.Point(201, 141)
        Me.Label_PhoneNumber.Name = "Label_PhoneNumber"
        Me.Label_PhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.Label_PhoneNumber.TabIndex = 3
        Me.Label_PhoneNumber.Text = "Phone Number"
        '
        'Label_LastName
        '
        Me.Label_LastName.AutoSize = True
        Me.Label_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LastName.Location = New System.Drawing.Point(201, 84)
        Me.Label_LastName.Name = "Label_LastName"
        Me.Label_LastName.Size = New System.Drawing.Size(76, 17)
        Me.Label_LastName.TabIndex = 4
        Me.Label_LastName.Text = "Last Name"
        '
        'Label_EmailAddress
        '
        Me.Label_EmailAddress.AutoSize = True
        Me.Label_EmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_EmailAddress.Location = New System.Drawing.Point(16, 141)
        Me.Label_EmailAddress.Name = "Label_EmailAddress"
        Me.Label_EmailAddress.Size = New System.Drawing.Size(98, 17)
        Me.Label_EmailAddress.TabIndex = 5
        Me.Label_EmailAddress.Text = "Email Address"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(19, 48)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_Username.TabIndex = 6
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(19, 104)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_Password.TabIndex = 7
        '
        'TextBox_FirstName
        '
        Me.TextBox_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_FirstName.Location = New System.Drawing.Point(204, 46)
        Me.TextBox_FirstName.Name = "TextBox_FirstName"
        Me.TextBox_FirstName.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_FirstName.TabIndex = 8
        '
        'TextBox_LastName
        '
        Me.TextBox_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LastName.Location = New System.Drawing.Point(204, 104)
        Me.TextBox_LastName.Name = "TextBox_LastName"
        Me.TextBox_LastName.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_LastName.TabIndex = 9
        '
        'TextBox_PhoneNumber
        '
        Me.TextBox_PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PhoneNumber.Location = New System.Drawing.Point(204, 161)
        Me.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber"
        Me.TextBox_PhoneNumber.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_PhoneNumber.TabIndex = 10
        '
        'TextBox_EmailAddress
        '
        Me.TextBox_EmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_EmailAddress.Location = New System.Drawing.Point(19, 161)
        Me.TextBox_EmailAddress.Name = "TextBox_EmailAddress"
        Me.TextBox_EmailAddress.Size = New System.Drawing.Size(167, 23)
        Me.TextBox_EmailAddress.TabIndex = 11
        '
        'Button_Save
        '
        Me.Button_Save.AutoSize = True
        Me.Button_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(19, 195)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(72, 36)
        Me.Button_Save.TabIndex = 12
        Me.Button_Save.Text = "Save"
        Me.Button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.AutoSize = True
        Me.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(97, 195)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(90, 36)
        Me.Button_Cancel.TabIndex = 13
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'GroupBox_Edit
        '
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_EmailAddress)
        Me.GroupBox_Edit.Controls.Add(Me.Button_Cancel)
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_PhoneNumber)
        Me.GroupBox_Edit.Controls.Add(Me.Button_Save)
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_LastName)
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_FirstName)
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_Password)
        Me.GroupBox_Edit.Controls.Add(Me.TextBox_Username)
        Me.GroupBox_Edit.Controls.Add(Me.Label_EmailAddress)
        Me.GroupBox_Edit.Controls.Add(Me.Label_LastName)
        Me.GroupBox_Edit.Controls.Add(Me.Label_PhoneNumber)
        Me.GroupBox_Edit.Controls.Add(Me.Label_FirstName)
        Me.GroupBox_Edit.Controls.Add(Me.Label_Password)
        Me.GroupBox_Edit.Controls.Add(Me.Label_Username)
        Me.GroupBox_Edit.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox_Edit.Name = "GroupBox_Edit"
        Me.GroupBox_Edit.Size = New System.Drawing.Size(393, 247)
        Me.GroupBox_Edit.TabIndex = 14
        Me.GroupBox_Edit.TabStop = False
        Me.GroupBox_Edit.Text = "Add New User Information"
        '
        'Label_EditHeader
        '
        Me.Label_EditHeader.AutoSize = True
        Me.Label_EditHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_EditHeader.Location = New System.Drawing.Point(12, 23)
        Me.Label_EditHeader.Name = "Label_EditHeader"
        Me.Label_EditHeader.Size = New System.Drawing.Size(180, 26)
        Me.Label_EditHeader.TabIndex = 15
        Me.Label_EditHeader.Text = "Add A New User!"
        '
        'Form_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 326)
        Me.Controls.Add(Me.Label_EditHeader)
        Me.Controls.Add(Me.GroupBox_Edit)
        Me.Name = "Form_Edit"
        Me.Text = "Edit"
        Me.GroupBox_Edit.ResumeLayout(False)
        Me.GroupBox_Edit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Password As Label
    Friend WithEvents Label_FirstName As Label
    Friend WithEvents Label_PhoneNumber As Label
    Friend WithEvents Label_LastName As Label
    Friend WithEvents Label_EmailAddress As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents TextBox_FirstName As TextBox
    Friend WithEvents TextBox_LastName As TextBox
    Friend WithEvents TextBox_PhoneNumber As TextBox
    Friend WithEvents TextBox_EmailAddress As TextBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents GroupBox_Edit As GroupBox
    Friend WithEvents Label_EditHeader As Label
End Class

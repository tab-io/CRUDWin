<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign in to Continue"
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(27, 65)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(73, 17)
        Me.Label_Username.TabIndex = 2
        Me.Label_Username.Text = "Username"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(30, 85)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(181, 23)
        Me.TextBox_Username.TabIndex = 3
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.Location = New System.Drawing.Point(27, 121)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(69, 17)
        Me.Label_Password.TabIndex = 4
        Me.Label_Password.Text = "Password"
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(30, 141)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(181, 23)
        Me.TextBox_Password.TabIndex = 5
        '
        'Button_Login
        '
        Me.Button_Login.AutoSize = True
        Me.Button_Login.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(65, 184)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(111, 46)
        Me.Button_Login.TabIndex = 6
        Me.Button_Login.Text = "Login"
        Me.Button_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Login.UseVisualStyleBackColor = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 256)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.TextBox_Username)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button_Login As Button
End Class

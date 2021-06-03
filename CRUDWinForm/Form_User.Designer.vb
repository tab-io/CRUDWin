<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_User
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_Create = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Create
        '
        Me.Button_Create.AutoSize = True
        Me.Button_Create.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Create.Location = New System.Drawing.Point(692, 7)
        Me.Button_Create.Name = "Button_Create"
        Me.Button_Create.Size = New System.Drawing.Size(163, 46)
        Me.Button_Create.TabIndex = 7
        Me.Button_Create.Text = "Add New User"
        Me.Button_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Create.UseVisualStyleBackColor = False
        '
        'Button_Edit
        '
        Me.Button_Edit.AutoSize = True
        Me.Button_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Edit.Location = New System.Drawing.Point(692, 59)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(163, 46)
        Me.Button_Edit.TabIndex = 8
        Me.Button_Edit.Text = "Edit User"
        Me.Button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Edit.UseVisualStyleBackColor = False
        '
        'Button_Delete
        '
        Me.Button_Delete.AutoSize = True
        Me.Button_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(692, 111)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(163, 46)
        Me.Button_Delete.TabIndex = 9
        Me.Button_Delete.Text = "Delete User"
        Me.Button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Delete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(679, 342)
        Me.DataGridView1.TabIndex = 10
        '
        'Form_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 361)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Create)
        Me.Name = "Form_User"
        Me.Text = "Form_User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Create As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

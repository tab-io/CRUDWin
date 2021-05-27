<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_User
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRUDUserstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRUDUsersDataSet = New CRUDWinForm.CRUDUsersDataSet()
        Me.CRUDUsers_tblTableAdapter = New CRUDWinForm.CRUDUsersDataSetTableAdapters.CRUDUsers_tblTableAdapter()
        Me.Button_Create = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRUDUserstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRUDUsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CRUDUserstblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'CRUDUserstblBindingSource
        '
        Me.CRUDUserstblBindingSource.DataMember = "CRUDUsers_tbl"
        Me.CRUDUserstblBindingSource.DataSource = Me.CRUDUsersDataSet
        '
        'CRUDUsersDataSet
        '
        Me.CRUDUsersDataSet.DataSetName = "CRUDUsersDataSet"
        Me.CRUDUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRUDUsers_tblTableAdapter
        '
        Me.CRUDUsers_tblTableAdapter.ClearBeforeFill = True
        '
        'Button_Create
        '
        Me.Button_Create.AutoSize = True
        Me.Button_Create.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Create.Location = New System.Drawing.Point(17, 296)
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
        Me.Button_Edit.Location = New System.Drawing.Point(287, 296)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(112, 46)
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
        Me.Button_Delete.Location = New System.Drawing.Point(525, 296)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(137, 46)
        Me.Button_Delete.TabIndex = 9
        Me.Button_Delete.Text = "Delete User"
        Me.Button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button_Delete.UseVisualStyleBackColor = False
        '
        'Form_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 348)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Create)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_User"
        Me.Text = "Form_User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRUDUserstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRUDUsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CRUDUsersDataSet As CRUDUsersDataSet
    Friend WithEvents CRUDUserstblBindingSource As BindingSource
    Friend WithEvents CRUDUsers_tblTableAdapter As CRUDUsersDataSetTableAdapters.CRUDUsers_tblTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button_Create As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Delete As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnPets = New System.Windows.Forms.Button()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(63, 58)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.Size = New System.Drawing.Size(655, 207)
        Me.dgvAccounts.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(187, 29)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(75, 23)
        Me.btnAccounts.TabIndex = 2
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnPets
        '
        Me.btnPets.Location = New System.Drawing.Point(295, 29)
        Me.btnPets.Name = "btnPets"
        Me.btnPets.Size = New System.Drawing.Size(75, 23)
        Me.btnPets.TabIndex = 3
        Me.btnPets.Text = "Pets"
        Me.btnPets.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPets)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Name = "admin"
        Me.Text = "admin"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnPets As Button
End Class

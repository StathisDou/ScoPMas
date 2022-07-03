<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.TxtExecute = New System.Windows.Forms.TextBox()
        Me.BtnExecute = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(0, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(667, 301)
        Me.dgv1.TabIndex = 0
        '
        'TxtExecute
        '
        Me.TxtExecute.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtExecute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtExecute.Location = New System.Drawing.Point(116, 307)
        Me.TxtExecute.Multiline = True
        Me.TxtExecute.Name = "TxtExecute"
        Me.TxtExecute.Size = New System.Drawing.Size(540, 32)
        Me.TxtExecute.TabIndex = 1
        '
        'BtnExecute
        '
        Me.BtnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExecute.Location = New System.Drawing.Point(12, 307)
        Me.BtnExecute.Name = "BtnExecute"
        Me.BtnExecute.Size = New System.Drawing.Size(98, 32)
        Me.BtnExecute.TabIndex = 2
        Me.BtnExecute.Text = "Execute"
        Me.BtnExecute.UseVisualStyleBackColor = True
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.BtnExecute)
        Me.Controls.Add(Me.TxtExecute)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "FrmTest"
        Me.Text = "FrmTest"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents TxtExecute As TextBox
    Friend WithEvents BtnExecute As Button
End Class

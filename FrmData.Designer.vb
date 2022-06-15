<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmData
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
        Me.LPanel = New System.Windows.Forms.Panel()
        Me.BtnConnectDB = New System.Windows.Forms.Button()
        Me.LblDataV = New System.Windows.Forms.Label()
        Me.LblDataS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVersionNumber = New System.Windows.Forms.TextBox()
        Me.TxtDatabasePath = New System.Windows.Forms.TextBox()
        Me.LblConnectionState = New System.Windows.Forms.Label()
        Me.LPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LPanel
        '
        Me.LPanel.Controls.Add(Me.BtnConnectDB)
        Me.LPanel.Controls.Add(Me.LblDataV)
        Me.LPanel.Controls.Add(Me.LblDataS)
        Me.LPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LPanel.Location = New System.Drawing.Point(0, 0)
        Me.LPanel.Name = "LPanel"
        Me.LPanel.Size = New System.Drawing.Size(120, 67)
        Me.LPanel.TabIndex = 0
        '
        'BtnConnectDB
        '
        Me.BtnConnectDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConnectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConnectDB.Location = New System.Drawing.Point(0, 40)
        Me.BtnConnectDB.Name = "BtnConnectDB"
        Me.BtnConnectDB.Size = New System.Drawing.Size(120, 26)
        Me.BtnConnectDB.TabIndex = 4
        Me.BtnConnectDB.Text = "Connect"
        Me.BtnConnectDB.UseVisualStyleBackColor = True
        '
        'LblDataV
        '
        Me.LblDataV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDataV.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDataV.Location = New System.Drawing.Point(0, 20)
        Me.LblDataV.Name = "LblDataV"
        Me.LblDataV.Size = New System.Drawing.Size(120, 20)
        Me.LblDataV.TabIndex = 3
        Me.LblDataV.Text = "Version"
        Me.LblDataV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDataS
        '
        Me.LblDataS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDataS.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDataS.Location = New System.Drawing.Point(0, 0)
        Me.LblDataS.Name = "LblDataS"
        Me.LblDataS.Size = New System.Drawing.Size(120, 20)
        Me.LblDataS.TabIndex = 1
        Me.LblDataS.Text = "Data source"
        Me.LblDataS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblConnectionState)
        Me.Panel1.Controls.Add(Me.txtVersionNumber)
        Me.Panel1.Controls.Add(Me.TxtDatabasePath)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(120, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 67)
        Me.Panel1.TabIndex = 1
        '
        'txtVersionNumber
        '
        Me.txtVersionNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersionNumber.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtVersionNumber.Location = New System.Drawing.Point(0, 20)
        Me.txtVersionNumber.Name = "txtVersionNumber"
        Me.txtVersionNumber.Size = New System.Drawing.Size(233, 20)
        Me.txtVersionNumber.TabIndex = 1
        Me.txtVersionNumber.Text = "3"
        Me.txtVersionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDatabasePath
        '
        Me.TxtDatabasePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDatabasePath.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtDatabasePath.Location = New System.Drawing.Point(0, 0)
        Me.TxtDatabasePath.Name = "TxtDatabasePath"
        Me.TxtDatabasePath.Size = New System.Drawing.Size(233, 20)
        Me.TxtDatabasePath.TabIndex = 0
        Me.TxtDatabasePath.Text = "$DatabaseLocation"
        Me.TxtDatabasePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblConnectionState
        '
        Me.LblConnectionState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblConnectionState.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblConnectionState.Location = New System.Drawing.Point(0, 40)
        Me.LblConnectionState.Name = "LblConnectionState"
        Me.LblConnectionState.Size = New System.Drawing.Size(233, 26)
        Me.LblConnectionState.TabIndex = 4
        Me.LblConnectionState.Text = "State : Not connected"
        Me.LblConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 67)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmData"
        Me.Text = "Data File / Location"
        Me.LPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LPanel As Panel
    Friend WithEvents LblDataS As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDatabasePath As TextBox
    Friend WithEvents LblDataV As Label
    Friend WithEvents txtVersionNumber As TextBox
    Friend WithEvents BtnConnectDB As Button
    Friend WithEvents LblConnectionState As Label
End Class

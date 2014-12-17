<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lblTWSConnection = New System.Windows.Forms.Label()
        Me.Tws1 = New AxTWSLib.AxTws()
        CType(Me.Tws1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(24, 32)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = true
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(24, 61)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = true
        '
        'lblTWSConnection
        '
        Me.lblTWSConnection.AutoSize = true
        Me.lblTWSConnection.Location = New System.Drawing.Point(21, 133)
        Me.lblTWSConnection.Name = "lblTWSConnection"
        Me.lblTWSConnection.Size = New System.Drawing.Size(39, 13)
        Me.lblTWSConnection.TabIndex = 3
        Me.lblTWSConnection.Text = "Label1"
        '
        'Tws1
        '
        Me.Tws1.Enabled = true
        Me.Tws1.Location = New System.Drawing.Point(340, 226)
        Me.Tws1.Name = "Tws1"
        Me.Tws1.OcxState = CType(resources.GetObject("Tws1.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Tws1.Size = New System.Drawing.Size(100, 50)
        Me.Tws1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 304)
        Me.Controls.Add(Me.lblTWSConnection)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Tws1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tws1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Tws1 As AxTWSLib.AxTws
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents lblTWSConnection As System.Windows.Forms.Label

End Class

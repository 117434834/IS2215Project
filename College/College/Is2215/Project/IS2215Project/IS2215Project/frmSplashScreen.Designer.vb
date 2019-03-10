<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.prgSplash = New System.Windows.Forms.ProgressBar()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSplash
        '
        Me.tmrSplash.Enabled = True
        Me.tmrSplash.Interval = 20
        '
        'prgSplash
        '
        Me.prgSplash.Location = New System.Drawing.Point(99, 254)
        Me.prgSplash.Name = "prgSplash"
        Me.prgSplash.Size = New System.Drawing.Size(308, 23)
        Me.prgSplash.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(55, 58)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(136, 153)
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(209, 121)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(261, 34)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Group 3 Task Manager"
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 326)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.prgSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.Text = "frmSplashScreen"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrSplash As Timer
    Friend WithEvents prgSplash As ProgressBar
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
End Class

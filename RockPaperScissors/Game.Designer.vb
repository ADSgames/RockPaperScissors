<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 155)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(429, 91)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Choose rock, paper or scissors."
        '
        'btnRock
        '
        Me.btnRock.BackgroundImage = CType(resources.GetObject("btnRock.BackgroundImage"), System.Drawing.Image)
        Me.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRock.Location = New System.Drawing.Point(12, 12)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(140, 140)
        Me.btnRock.TabIndex = 4
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.BackgroundImage = CType(resources.GetObject("btnPaper.BackgroundImage"), System.Drawing.Image)
        Me.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaper.Location = New System.Drawing.Point(157, 12)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(140, 140)
        Me.btnPaper.TabIndex = 5
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.scissors
        Me.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScissors.Location = New System.Drawing.Point(301, 12)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(140, 140)
        Me.btnScissors.TabIndex = 6
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(318, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 27)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 284)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

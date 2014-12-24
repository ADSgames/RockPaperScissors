<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Me.Close = New System.Windows.Forms.Button()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblTie = New System.Windows.Forms.Label()
        Me.lblLoss = New System.Windows.Forms.Label()
        Me.statisitics = New System.Windows.Forms.Label()
        Me.lblNumberWins = New System.Windows.Forms.Label()
        Me.lblNumberTies = New System.Windows.Forms.Label()
        Me.lblNumberLosses = New System.Windows.Forms.Label()
        Me.statsGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnErase = New System.Windows.Forms.Button()
        CType(Me.statsGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(149, 223)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(123, 27)
        Me.Close.TabIndex = 0
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Location = New System.Drawing.Point(9, 207)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(34, 13)
        Me.lblWin.TabIndex = 1
        Me.lblWin.Text = "Wins-"
        '
        'lblTie
        '
        Me.lblTie.AutoSize = True
        Me.lblTie.Location = New System.Drawing.Point(110, 207)
        Me.lblTie.Name = "lblTie"
        Me.lblTie.Size = New System.Drawing.Size(30, 13)
        Me.lblTie.TabIndex = 2
        Me.lblTie.Text = "Ties-"
        '
        'lblLoss
        '
        Me.lblLoss.AutoSize = True
        Me.lblLoss.Location = New System.Drawing.Point(210, 207)
        Me.lblLoss.Name = "lblLoss"
        Me.lblLoss.Size = New System.Drawing.Size(43, 13)
        Me.lblLoss.TabIndex = 3
        Me.lblLoss.Text = "Losses-"
        '
        'statisitics
        '
        Me.statisitics.AutoSize = True
        Me.statisitics.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statisitics.Location = New System.Drawing.Point(100, 9)
        Me.statisitics.Name = "statisitics"
        Me.statisitics.Size = New System.Drawing.Size(92, 32)
        Me.statisitics.TabIndex = 4
        Me.statisitics.Text = "Stats"
        '
        'lblNumberWins
        '
        Me.lblNumberWins.AutoSize = True
        Me.lblNumberWins.Location = New System.Drawing.Point(49, 207)
        Me.lblNumberWins.Name = "lblNumberWins"
        Me.lblNumberWins.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberWins.TabIndex = 5
        Me.lblNumberWins.Text = "0"
        '
        'lblNumberTies
        '
        Me.lblNumberTies.AutoSize = True
        Me.lblNumberTies.Location = New System.Drawing.Point(146, 207)
        Me.lblNumberTies.Name = "lblNumberTies"
        Me.lblNumberTies.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberTies.TabIndex = 6
        Me.lblNumberTies.Text = "0"
        '
        'lblNumberLosses
        '
        Me.lblNumberLosses.AutoSize = True
        Me.lblNumberLosses.Location = New System.Drawing.Point(259, 207)
        Me.lblNumberLosses.Name = "lblNumberLosses"
        Me.lblNumberLosses.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberLosses.TabIndex = 7
        Me.lblNumberLosses.Text = "0"
        '
        'statsGraph
        '
        Me.statsGraph.BackColor = System.Drawing.Color.Transparent
        Me.statsGraph.BorderlineColor = System.Drawing.Color.Transparent
        Me.statsGraph.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea1.Area3DStyle.Inclination = 15
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.statsGraph.ChartAreas.Add(ChartArea1)
        Me.statsGraph.Location = New System.Drawing.Point(12, 44)
        Me.statsGraph.Name = "statsGraph"
        Me.statsGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.MarkerSize = 3
        Series1.Name = "Series1"
        DataPoint1.AxisLabel = "Wins"
        DataPoint1.IsValueShownAsLabel = False
        DataPoint1.Label = ""
        DataPoint1.LegendText = ""
        DataPoint2.AxisLabel = "Ties"
        DataPoint3.AxisLabel = "Losses"
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Me.statsGraph.Series.Add(Series1)
        Me.statsGraph.Size = New System.Drawing.Size(260, 149)
        Me.statsGraph.TabIndex = 0
        Me.statsGraph.TabStop = False
        Me.statsGraph.Text = "Stats"
        '
        'btnErase
        '
        Me.btnErase.Location = New System.Drawing.Point(12, 223)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(123, 27)
        Me.btnErase.TabIndex = 9
        Me.btnErase.Text = "Erase"
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.statsGraph)
        Me.Controls.Add(Me.lblNumberLosses)
        Me.Controls.Add(Me.lblNumberTies)
        Me.Controls.Add(Me.lblNumberWins)
        Me.Controls.Add(Me.statisitics)
        Me.Controls.Add(Me.lblLoss)
        Me.Controls.Add(Me.lblTie)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.Close)
        Me.Name = "Stats"
        Me.Text = "Stats"
        CType(Me.statsGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close As System.Windows.Forms.Button
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents lblTie As System.Windows.Forms.Label
    Friend WithEvents lblLoss As System.Windows.Forms.Label
    Friend WithEvents statisitics As System.Windows.Forms.Label
    Friend WithEvents lblNumberWins As System.Windows.Forms.Label
    Friend WithEvents lblNumberTies As System.Windows.Forms.Label
    Friend WithEvents lblNumberLosses As System.Windows.Forms.Label
    Friend WithEvents statsGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnErase As System.Windows.Forms.Button
End Class

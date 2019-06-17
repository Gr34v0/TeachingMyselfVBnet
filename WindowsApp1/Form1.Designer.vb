<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn1Click = New System.Windows.Forms.Button()
        Me.btn2Click = New System.Windows.Forms.Button()
        Me.btn3Click = New System.Windows.Forms.Button()
        Me.targetOfBtn = New System.Windows.Forms.Label()
        Me.btnCSViewClick = New System.Windows.Forms.Button()
        Me.btnRange = New System.Windows.Forms.Button()
        Me.btnMedian = New System.Windows.Forms.Button()
        Me.btnMean = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1Click
        '
        Me.btn1Click.Location = New System.Drawing.Point(38, 409)
        Me.btn1Click.Name = "btn1Click"
        Me.btn1Click.Size = New System.Drawing.Size(137, 54)
        Me.btn1Click.TabIndex = 0
        Me.btn1Click.Text = "Hello World"
        Me.btn1Click.UseVisualStyleBackColor = True
        '
        'btn2Click
        '
        Me.btn2Click.Location = New System.Drawing.Point(326, 409)
        Me.btn2Click.Name = "btn2Click"
        Me.btn2Click.Size = New System.Drawing.Size(137, 54)
        Me.btn2Click.TabIndex = 1
        Me.btn2Click.Text = "Hello There"
        Me.btn2Click.UseVisualStyleBackColor = True
        '
        'btn3Click
        '
        Me.btn3Click.Location = New System.Drawing.Point(608, 409)
        Me.btn3Click.Name = "btn3Click"
        Me.btn3Click.Size = New System.Drawing.Size(137, 54)
        Me.btn3Click.TabIndex = 2
        Me.btn3Click.Text = "General Kenobi"
        Me.btn3Click.UseVisualStyleBackColor = True
        '
        'targetOfBtn
        '
        Me.targetOfBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.targetOfBtn.Location = New System.Drawing.Point(38, 132)
        Me.targetOfBtn.Name = "targetOfBtn"
        Me.targetOfBtn.Size = New System.Drawing.Size(707, 13)
        Me.targetOfBtn.TabIndex = 3
        Me.targetOfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCSViewClick
        '
        Me.btnCSViewClick.Location = New System.Drawing.Point(41, 191)
        Me.btnCSViewClick.Name = "btnCSViewClick"
        Me.btnCSViewClick.Size = New System.Drawing.Size(137, 54)
        Me.btnCSViewClick.TabIndex = 4
        Me.btnCSViewClick.Text = "View CSV"
        Me.btnCSViewClick.UseVisualStyleBackColor = True
        '
        'btnRange
        '
        Me.btnRange.Location = New System.Drawing.Point(608, 298)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Size = New System.Drawing.Size(137, 54)
        Me.btnRange.TabIndex = 5
        Me.btnRange.Text = "Range"
        Me.btnRange.UseVisualStyleBackColor = True
        '
        'btnMedian
        '
        Me.btnMedian.Location = New System.Drawing.Point(326, 298)
        Me.btnMedian.Name = "btnMedian"
        Me.btnMedian.Size = New System.Drawing.Size(137, 54)
        Me.btnMedian.TabIndex = 6
        Me.btnMedian.Text = "Median"
        Me.btnMedian.UseVisualStyleBackColor = True
        '
        'btnMean
        '
        Me.btnMean.Location = New System.Drawing.Point(38, 298)
        Me.btnMean.Name = "btnMean"
        Me.btnMean.Size = New System.Drawing.Size(137, 54)
        Me.btnMean.TabIndex = 7
        Me.btnMean.Text = "Mean"
        Me.btnMean.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(326, 191)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(137, 54)
        Me.btnSort.TabIndex = 8
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnMean)
        Me.Controls.Add(Me.btnMedian)
        Me.Controls.Add(Me.btnRange)
        Me.Controls.Add(Me.btnCSViewClick)
        Me.Controls.Add(Me.targetOfBtn)
        Me.Controls.Add(Me.btn3Click)
        Me.Controls.Add(Me.btn2Click)
        Me.Controls.Add(Me.btn1Click)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1Click As Button
    Friend WithEvents btn2Click As Button
    Friend WithEvents btn3Click As Button
    Friend WithEvents targetOfBtn As Label
    Friend WithEvents btnCSViewClick As Button
    Friend WithEvents btnRange As Button
    Friend WithEvents btnMedian As Button
    Friend WithEvents btnMean As Button
    Friend WithEvents btnSort As Button
End Class

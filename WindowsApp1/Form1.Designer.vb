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
        Me.SuspendLayout()
        '
        'btn1Click
        '
        Me.btn1Click.Location = New System.Drawing.Point(38, 204)
        Me.btn1Click.Name = "btn1Click"
        Me.btn1Click.Size = New System.Drawing.Size(137, 54)
        Me.btn1Click.TabIndex = 0
        Me.btn1Click.Text = "Hello World"
        Me.btn1Click.UseVisualStyleBackColor = True
        '
        'btn2Click
        '
        Me.btn2Click.Location = New System.Drawing.Point(322, 204)
        Me.btn2Click.Name = "btn2Click"
        Me.btn2Click.Size = New System.Drawing.Size(137, 54)
        Me.btn2Click.TabIndex = 1
        Me.btn2Click.Text = "Hello There"
        Me.btn2Click.UseVisualStyleBackColor = True
        '
        'btn3Click
        '
        Me.btn3Click.Location = New System.Drawing.Point(608, 204)
        Me.btn3Click.Name = "btn3Click"
        Me.btn3Click.Size = New System.Drawing.Size(137, 54)
        Me.btn3Click.TabIndex = 2
        Me.btn3Click.Text = "General Kenobi"
        Me.btn3Click.UseVisualStyleBackColor = True
        '
        'targetOfBtn
        '
        Me.targetOfBtn.AutoSize = True
        Me.targetOfBtn.Location = New System.Drawing.Point(360, 132)
        Me.targetOfBtn.Name = "targetOfBtn"
        Me.targetOfBtn.Size = New System.Drawing.Size(39, 13)
        Me.targetOfBtn.TabIndex = 3
        Me.targetOfBtn.Text = "Label1"
        '
        'btnCSViewClick
        '
        Me.btnCSViewClick.Location = New System.Drawing.Point(590, 50)
        Me.btnCSViewClick.Name = "btnCSViewClick"
        Me.btnCSViewClick.Size = New System.Drawing.Size(137, 54)
        Me.btnCSViewClick.TabIndex = 4
        Me.btnCSViewClick.Text = "View CSV"
        Me.btnCSViewClick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 323)
        Me.Controls.Add(Me.btnCSViewClick)
        Me.Controls.Add(Me.targetOfBtn)
        Me.Controls.Add(Me.btn3Click)
        Me.Controls.Add(Me.btn2Click)
        Me.Controls.Add(Me.btn1Click)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1Click As Button
    Friend WithEvents btn2Click As Button
    Friend WithEvents btn3Click As Button
    Friend WithEvents targetOfBtn As Label
    Friend WithEvents btnCSViewClick As Button
End Class

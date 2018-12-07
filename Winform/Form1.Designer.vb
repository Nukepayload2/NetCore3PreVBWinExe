Partial Public Class Form1
    Inherits Form

    Private components As System.ComponentModel.IContainer = Nothing

    Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(800, 376)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Hello .NET Core!"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.buttonExit.Location = New System.Drawing.Point(0, 376)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(800, 74)
        Me.buttonExit.TabIndex = 1
        Me.buttonExit.Text = "E&xit"
        Me.buttonExit.UseVisualStyleBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0F, 25.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
    End Sub

    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents buttonExit As System.Windows.Forms.Button
End Class

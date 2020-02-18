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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'TxtBtn
        '
        Me.TxtBtn.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBtn.Location = New System.Drawing.Point(45, 311)
        Me.TxtBtn.Name = "TxtBtn"
        Me.TxtBtn.Size = New System.Drawing.Size(95, 49)
        Me.TxtBtn.TabIndex = 3
        Me.TxtBtn.Text = "Txt"
        Me.TxtBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Button1.Location = New System.Drawing.Point(334, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "XML"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 20.25!)
        Me.Button2.Location = New System.Drawing.Point(648, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 49)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "JSON"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.NameBox.Location = New System.Drawing.Point(200, 47)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(456, 38)
        Me.NameBox.TabIndex = 6
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.AgeBox.Location = New System.Drawing.Point(200, 129)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(456, 38)
        Me.AgeBox.TabIndex = 7
        '
        'AddressBox
        '
        Me.AddressBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.AddressBox.Location = New System.Drawing.Point(200, 205)
        Me.AddressBox.Multiline = True
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(456, 81)
        Me.AddressBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HW1.My.Resources.Resources.calc_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Assignment 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NameBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AddressBox As TextBox
End Class

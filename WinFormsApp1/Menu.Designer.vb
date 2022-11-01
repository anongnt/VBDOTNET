<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "หน้าหลัก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(531, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "รายละเอียดของผู้ป่วย"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(184, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "เข้าสู่ระบบ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(795, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(203, 34)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "ผู้ป่วยนอก"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(151, 265)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(203, 34)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "หน้าสำหรับพนักงาน"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(427, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(203, 34)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "หน้าสำหรับพนักงาน2"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(670, 265)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(203, 34)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "บันทึกยาแลยทรัพยากร"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 644)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class

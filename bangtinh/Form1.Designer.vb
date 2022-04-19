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
        Me.value1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.value2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.value3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chiaNguyen = New System.Windows.Forms.RadioButton()
        Me.luythua = New System.Windows.Forms.RadioButton()
        Me.chiaMod = New System.Windows.Forms.RadioButton()
        Me.nhan = New System.Windows.Forms.RadioButton()
        Me.chia = New System.Windows.Forms.RadioButton()
        Me.tru = New System.Windows.Forms.RadioButton()
        Me.cong = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tron = New System.Windows.Forms.RadioButton()
        Me.tamgiac = New System.Windows.Forms.RadioButton()
        Me.vuong = New System.Windows.Forms.RadioButton()
        Me.chunhat = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Giá trị 1"
        '
        'value1
        '
        Me.value1.Location = New System.Drawing.Point(59, 52)
        Me.value1.Name = "value1"
        Me.value1.Size = New System.Drawing.Size(100, 20)
        Me.value1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Giá trị 2"
        '
        'value2
        '
        Me.value2.Location = New System.Drawing.Point(213, 52)
        Me.value2.Name = "value2"
        Me.value2.Size = New System.Drawing.Size(100, 20)
        Me.value2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(559, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Giá trị 3"
        '
        'value3
        '
        Me.value3.Location = New System.Drawing.Point(535, 51)
        Me.value3.Name = "value3"
        Me.value3.Size = New System.Drawing.Size(100, 20)
        Me.value3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chiaNguyen)
        Me.GroupBox1.Controls.Add(Me.luythua)
        Me.GroupBox1.Controls.Add(Me.chiaMod)
        Me.GroupBox1.Controls.Add(Me.nhan)
        Me.GroupBox1.Controls.Add(Me.chia)
        Me.GroupBox1.Controls.Add(Me.tru)
        Me.GroupBox1.Controls.Add(Me.cong)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(38, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 169)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toán tử"
        '
        'chiaNguyen
        '
        Me.chiaNguyen.AutoSize = True
        Me.chiaNguyen.Location = New System.Drawing.Point(185, 100)
        Me.chiaNguyen.Name = "chiaNguyen"
        Me.chiaNguyen.Size = New System.Drawing.Size(127, 17)
        Me.chiaNguyen.TabIndex = 7
        Me.chiaNguyen.TabStop = True
        Me.chiaNguyen.Text = "Phép chia lấy nguyên"
        Me.chiaNguyen.UseVisualStyleBackColor = True
        '
        'luythua
        '
        Me.luythua.AutoSize = True
        Me.luythua.Location = New System.Drawing.Point(185, 68)
        Me.luythua.Name = "luythua"
        Me.luythua.Size = New System.Drawing.Size(90, 17)
        Me.luythua.TabIndex = 6
        Me.luythua.TabStop = True
        Me.luythua.Text = "Phép luỹ thừa"
        Me.luythua.UseVisualStyleBackColor = True
        '
        'chiaMod
        '
        Me.chiaMod.AutoSize = True
        Me.chiaMod.Location = New System.Drawing.Point(185, 35)
        Me.chiaMod.Name = "chiaMod"
        Me.chiaMod.Size = New System.Drawing.Size(134, 17)
        Me.chiaMod.TabIndex = 5
        Me.chiaMod.TabStop = True
        Me.chiaMod.Text = "Phép chia lấy dư (Mod)"
        Me.chiaMod.UseVisualStyleBackColor = True
        '
        'nhan
        '
        Me.nhan.AutoSize = True
        Me.nhan.Location = New System.Drawing.Point(13, 132)
        Me.nhan.Name = "nhan"
        Me.nhan.Size = New System.Drawing.Size(90, 17)
        Me.nhan.TabIndex = 3
        Me.nhan.TabStop = True
        Me.nhan.Text = "Phép nhân (*)"
        Me.nhan.UseVisualStyleBackColor = True
        '
        'chia
        '
        Me.chia.AutoSize = True
        Me.chia.Location = New System.Drawing.Point(13, 100)
        Me.chia.Name = "chia"
        Me.chia.Size = New System.Drawing.Size(87, 17)
        Me.chia.TabIndex = 2
        Me.chia.TabStop = True
        Me.chia.Text = "Phép chia (/)"
        Me.chia.UseVisualStyleBackColor = True
        '
        'tru
        '
        Me.tru.AutoSize = True
        Me.tru.Location = New System.Drawing.Point(13, 68)
        Me.tru.Name = "tru"
        Me.tru.Size = New System.Drawing.Size(77, 17)
        Me.tru.TabIndex = 1
        Me.tru.TabStop = True
        Me.tru.Text = "Phép trừ (-)"
        Me.tru.UseVisualStyleBackColor = True
        '
        'cong
        '
        Me.cong.AutoSize = True
        Me.cong.Location = New System.Drawing.Point(13, 35)
        Me.cong.Name = "cong"
        Me.cong.Size = New System.Drawing.Size(92, 17)
        Me.cong.TabIndex = 0
        Me.cong.TabStop = True
        Me.cong.Text = "Phép cộng (+)"
        Me.cong.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tron)
        Me.GroupBox2.Controls.Add(Me.tamgiac)
        Me.GroupBox2.Controls.Add(Me.vuong)
        Me.GroupBox2.Controls.Add(Me.chunhat)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(454, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 169)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diện tích hình học"
        '
        'tron
        '
        Me.tron.AutoSize = True
        Me.tron.Location = New System.Drawing.Point(6, 132)
        Me.tron.Name = "tron"
        Me.tron.Size = New System.Drawing.Size(77, 17)
        Me.tron.TabIndex = 3
        Me.tron.TabStop = True
        Me.tron.Text = "Tròn (GT3)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tron.UseVisualStyleBackColor = True
        '
        'tamgiac
        '
        Me.tamgiac.AutoSize = True
        Me.tamgiac.Location = New System.Drawing.Point(6, 100)
        Me.tamgiac.Name = "tamgiac"
        Me.tamgiac.Size = New System.Drawing.Size(69, 17)
        Me.tamgiac.TabIndex = 2
        Me.tamgiac.TabStop = True
        Me.tamgiac.Text = "Tam giác"
        Me.tamgiac.UseVisualStyleBackColor = True
        '
        'vuong
        '
        Me.vuong.AutoSize = True
        Me.vuong.Location = New System.Drawing.Point(6, 68)
        Me.vuong.Name = "vuong"
        Me.vuong.Size = New System.Drawing.Size(86, 17)
        Me.vuong.TabIndex = 1
        Me.vuong.TabStop = True
        Me.vuong.Text = "Vuông (GT3)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.vuong.UseVisualStyleBackColor = True
        '
        'chunhat
        '
        Me.chunhat.AutoSize = True
        Me.chunhat.Location = New System.Drawing.Point(6, 35)
        Me.chunhat.Name = "chunhat"
        Me.chunhat.Size = New System.Drawing.Size(125, 17)
        Me.chunhat.TabIndex = 0
        Me.chunhat.TabStop = True
        Me.chunhat.Text = "Chữ nhật (GT1, GT2)"
        Me.chunhat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(123, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Thực hiện tính"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(526, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Tính"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kết quả"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(351, 367)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(107, 20)
        Me.result.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 439)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.value3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.value2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.value1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents value1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents value2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents value3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chiaNguyen As RadioButton
    Friend WithEvents luythua As RadioButton
    Friend WithEvents chiaMod As RadioButton
    Friend WithEvents nhan As RadioButton
    Friend WithEvents chia As RadioButton
    Friend WithEvents tru As RadioButton
    Friend WithEvents cong As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tron As RadioButton
    Friend WithEvents tamgiac As RadioButton
    Friend WithEvents vuong As RadioButton
    Friend WithEvents chunhat As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents result As TextBox
End Class

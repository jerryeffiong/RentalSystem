<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 164)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CHANGE PASSWORD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtOldPass
        '
        Me.txtOldPass.BackColor = System.Drawing.Color.White
        Me.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtOldPass.Location = New System.Drawing.Point(50, 192)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(210, 13)
        Me.txtOldPass.TabIndex = 8
        Me.txtOldPass.Text = "Enter old password"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(12, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 220)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(255, 31)
        Me.Button4.TabIndex = 9
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtNewPass.Location = New System.Drawing.Point(50, 229)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(210, 13)
        Me.txtNewPass.TabIndex = 8
        Me.txtNewPass.Text = "Enter new password"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(12, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(255, 31)
        Me.Button5.TabIndex = 9
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.BackColor = System.Drawing.Color.White
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtConfirm.Location = New System.Drawing.Point(50, 266)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(210, 13)
        Me.txtConfirm.TabIndex = 8
        Me.txtConfirm.Text = "Confirm new password"
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(277, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtConfirm As TextBox
End Class

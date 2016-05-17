<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCards
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
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Pic3 = New System.Windows.Forms.PictureBox()
        Me.Pic4 = New System.Windows.Forms.PictureBox()
        Me.Pic5 = New System.Windows.Forms.PictureBox()
        Me.btnPic5 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCardValue = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic1
        '
        Me.Pic1.Location = New System.Drawing.Point(71, 49)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(143, 206)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic1.TabIndex = 0
        Me.Pic1.TabStop = False
        '
        'Pic2
        '
        Me.Pic2.Location = New System.Drawing.Point(231, 49)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(143, 206)
        Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic2.TabIndex = 1
        Me.Pic2.TabStop = False
        '
        'Pic3
        '
        Me.Pic3.Location = New System.Drawing.Point(393, 49)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(143, 206)
        Me.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic3.TabIndex = 2
        Me.Pic3.TabStop = False
        '
        'Pic4
        '
        Me.Pic4.Location = New System.Drawing.Point(554, 49)
        Me.Pic4.Name = "Pic4"
        Me.Pic4.Size = New System.Drawing.Size(143, 206)
        Me.Pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic4.TabIndex = 3
        Me.Pic4.TabStop = False
        '
        'Pic5
        '
        Me.Pic5.Location = New System.Drawing.Point(718, 49)
        Me.Pic5.Name = "Pic5"
        Me.Pic5.Size = New System.Drawing.Size(143, 206)
        Me.Pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic5.TabIndex = 4
        Me.Pic5.TabStop = False
        '
        'btnPic5
        '
        Me.btnPic5.Location = New System.Drawing.Point(93, 327)
        Me.btnPic5.Name = "btnPic5"
        Me.btnPic5.Size = New System.Drawing.Size(75, 23)
        Me.btnPic5.TabIndex = 5
        Me.btnPic5.Text = "Pick 5"
        Me.btnPic5.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(742, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCardValue
        '
        Me.lblCardValue.AutoSize = True
        Me.lblCardValue.Location = New System.Drawing.Point(425, 307)
        Me.lblCardValue.Name = "lblCardValue"
        Me.lblCardValue.Size = New System.Drawing.Size(75, 16)
        Me.lblCardValue.TabIndex = 7
        Me.lblCardValue.Text = "Card Value"
        '
        'lblValue
        '
        Me.lblValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValue.Location = New System.Drawing.Point(393, 326)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(143, 23)
        Me.lblValue.TabIndex = 8
        '
        'frmCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 371)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblCardValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPic5)
        Me.Controls.Add(Me.Pic5)
        Me.Controls.Add(Me.Pic4)
        Me.Controls.Add(Me.Pic3)
        Me.Controls.Add(Me.Pic2)
        Me.Controls.Add(Me.Pic1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCards"
        Me.Text = "Card Table"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Pic2 As PictureBox
    Friend WithEvents Pic3 As PictureBox
    Friend WithEvents Pic4 As PictureBox
    Friend WithEvents Pic5 As PictureBox
    Friend WithEvents btnPic5 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCardValue As Label
    Friend WithEvents lblValue As Label
End Class

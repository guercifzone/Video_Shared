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
        Me.Txt_Title = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Post = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Link = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_CPU = New System.Windows.Forms.TextBox()
        Me.Combo_Type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_connection = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Title
        '
        Me.Txt_Title.Location = New System.Drawing.Point(111, 84)
        Me.Txt_Title.Name = "Txt_Title"
        Me.Txt_Title.Size = New System.Drawing.Size(234, 20)
        Me.Txt_Title.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Share Your video  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Btn_Post
        '
        Me.Btn_Post.Location = New System.Drawing.Point(209, 266)
        Me.Btn_Post.Name = "Btn_Post"
        Me.Btn_Post.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Post.TabIndex = 2
        Me.Btn_Post.Text = "&Post"
        Me.Btn_Post.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(19, 266)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.Text = "&Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Link"
        '
        'Txt_Link
        '
        Me.Txt_Link.Location = New System.Drawing.Point(111, 185)
        Me.Txt_Link.Name = "Txt_Link"
        Me.Txt_Link.Size = New System.Drawing.Size(234, 20)
        Me.Txt_Link.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "&Type"
        '
        'Txt_CPU
        '
        Me.Txt_CPU.Location = New System.Drawing.Point(111, 227)
        Me.Txt_CPU.Name = "Txt_CPU"
        Me.Txt_CPU.ReadOnly = True
        Me.Txt_CPU.Size = New System.Drawing.Size(234, 20)
        Me.Txt_CPU.TabIndex = 7
        '
        'Combo_Type
        '
        Me.Combo_Type.FormattingEnabled = True
        Me.Combo_Type.Items.AddRange(New Object() {"php", "html", "js"})
        Me.Combo_Type.Location = New System.Drawing.Point(125, 123)
        Me.Combo_Type.Name = "Combo_Type"
        Me.Combo_Type.Size = New System.Drawing.Size(121, 21)
        Me.Combo_Type.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "&CPU"
        '
        'Label_connection
        '
        Me.Label_connection.AutoSize = True
        Me.Label_connection.Location = New System.Drawing.Point(137, 328)
        Me.Label_connection.Name = "Label_connection"
        Me.Label_connection.Size = New System.Drawing.Size(108, 13)
        Me.Label_connection.TabIndex = 11
        Me.Label_connection.Text = "&Database Connected"
        Me.Label_connection.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 355)
        Me.Controls.Add(Me.Label_connection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Combo_Type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_CPU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Link)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Post)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Title)
        Me.Name = "Form1"
        Me.Text = "postVideo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Post As System.Windows.Forms.Button
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Link As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_CPU As System.Windows.Forms.TextBox
    Friend WithEvents Combo_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label_connection As System.Windows.Forms.Label

End Class

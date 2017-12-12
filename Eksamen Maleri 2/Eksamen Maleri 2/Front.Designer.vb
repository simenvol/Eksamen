<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frontform
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
        Me.Paintinglist = New System.Windows.Forms.ListBox()
        Me.Maleridropdown = New System.Windows.Forms.ComboBox()
        Me.InfoL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Paintinglist
        '
        Me.Paintinglist.FormattingEnabled = True
        Me.Paintinglist.Location = New System.Drawing.Point(12, 105)
        Me.Paintinglist.Name = "Paintinglist"
        Me.Paintinglist.Size = New System.Drawing.Size(351, 238)
        Me.Paintinglist.TabIndex = 0
        '
        'Maleridropdown
        '
        Me.Maleridropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Maleridropdown.FormattingEnabled = True
        Me.Maleridropdown.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.Maleridropdown.Location = New System.Drawing.Point(12, 25)
        Me.Maleridropdown.Name = "Maleridropdown"
        Me.Maleridropdown.Size = New System.Drawing.Size(150, 21)
        Me.Maleridropdown.TabIndex = 1
        '
        'InfoL
        '
        Me.InfoL.AutoSize = True
        Me.InfoL.Location = New System.Drawing.Point(12, 9)
        Me.InfoL.Name = "InfoL"
        Me.InfoL.Size = New System.Drawing.Size(58, 13)
        Me.InfoL.TabIndex = 2
        Me.InfoL.Text = "Velg maleri"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Registrer bud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 56)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Admin"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frontform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 370)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InfoL)
        Me.Controls.Add(Me.Maleridropdown)
        Me.Controls.Add(Me.Paintinglist)
        Me.Name = "Frontform"
        Me.Text = "Auksjon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Paintinglist As ListBox
    Friend WithEvents Maleridropdown As ComboBox
    Friend WithEvents InfoL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

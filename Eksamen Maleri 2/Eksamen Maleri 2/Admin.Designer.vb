<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Adminmaleridropdown = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Adminlistbox = New System.Windows.Forms.ListBox()
        Me.BAcceptbid = New System.Windows.Forms.Button()
        Me.BClearbids = New System.Windows.Forms.Button()
        Me.Profitinfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Adminmaleridropdown
        '
        Me.Adminmaleridropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Adminmaleridropdown.FormattingEnabled = True
        Me.Adminmaleridropdown.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.Adminmaleridropdown.Location = New System.Drawing.Point(12, 31)
        Me.Adminmaleridropdown.Name = "Adminmaleridropdown"
        Me.Adminmaleridropdown.Size = New System.Drawing.Size(186, 21)
        Me.Adminmaleridropdown.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Velg maleri"
        '
        'Adminlistbox
        '
        Me.Adminlistbox.FormattingEnabled = True
        Me.Adminlistbox.Location = New System.Drawing.Point(12, 112)
        Me.Adminlistbox.Name = "Adminlistbox"
        Me.Adminlistbox.Size = New System.Drawing.Size(186, 108)
        Me.Adminlistbox.TabIndex = 2
        '
        'BAcceptbid
        '
        Me.BAcceptbid.Location = New System.Drawing.Point(12, 58)
        Me.BAcceptbid.Name = "BAcceptbid"
        Me.BAcceptbid.Size = New System.Drawing.Size(86, 39)
        Me.BAcceptbid.TabIndex = 3
        Me.BAcceptbid.Text = "Aksepter bud"
        Me.BAcceptbid.UseVisualStyleBackColor = True
        '
        'BClearbids
        '
        Me.BClearbids.Location = New System.Drawing.Point(104, 58)
        Me.BClearbids.Name = "BClearbids"
        Me.BClearbids.Size = New System.Drawing.Size(94, 39)
        Me.BClearbids.TabIndex = 4
        Me.BClearbids.Text = "Nullstill"
        Me.BClearbids.UseVisualStyleBackColor = True
        '
        'Profitinfo
        '
        Me.Profitinfo.AutoSize = True
        Me.Profitinfo.Location = New System.Drawing.Point(16, 239)
        Me.Profitinfo.Name = "Profitinfo"
        Me.Profitinfo.Size = New System.Drawing.Size(152, 13)
        Me.Profitinfo.TabIndex = 5
        Me.Profitinfo.Text = "Dagens inntekt så langt er 0 kr"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 261)
        Me.Controls.Add(Me.Profitinfo)
        Me.Controls.Add(Me.BClearbids)
        Me.Controls.Add(Me.BAcceptbid)
        Me.Controls.Add(Me.Adminlistbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Adminmaleridropdown)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Adminmaleridropdown As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Adminlistbox As ListBox
    Friend WithEvents BAcceptbid As Button
    Friend WithEvents BClearbids As Button
    Friend WithEvents Profitinfo As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TombolPilih = New System.Windows.Forms.ComboBox()
        Me.Inputan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TombolPilih
        '
        Me.TombolPilih.FormattingEnabled = True
        Me.TombolPilih.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverter Pyramid", "Hollow Inverter Pyramid"})
        Me.TombolPilih.Location = New System.Drawing.Point(106, 25)
        Me.TombolPilih.Name = "TombolPilih"
        Me.TombolPilih.Size = New System.Drawing.Size(333, 21)
        Me.TombolPilih.TabIndex = 0
        '
        'Inputan
        '
        Me.Inputan.Location = New System.Drawing.Point(106, 56)
        Me.Inputan.Name = "Inputan"
        Me.Inputan.Size = New System.Drawing.Size(251, 20)
        Me.Inputan.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Output.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(36, 101)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Output.Size = New System.Drawing.Size(402, 296)
        Me.Output.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Inputan)
        Me.Controls.Add(Me.TombolPilih)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TombolPilih As System.Windows.Forms.ComboBox
    Friend WithEvents Inputan As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

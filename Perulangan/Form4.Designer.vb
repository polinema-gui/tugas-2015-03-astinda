<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Btn_proses = New System.Windows.Forms.Button()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.Txb_matrik2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_operasi = New System.Windows.Forms.ComboBox()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.Txb_matrik1 = New System.Windows.Forms.TextBox()
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_proses
        '
        Me.Btn_proses.Location = New System.Drawing.Point(308, 358)
        Me.Btn_proses.Name = "Btn_proses"
        Me.Btn_proses.Size = New System.Drawing.Size(122, 23)
        Me.Btn_proses.TabIndex = 17
        Me.Btn_proses.Text = "Proses"
        Me.Btn_proses.UseVisualStyleBackColor = True
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(13, 270)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 16
        Me.Lbl_hasil.Text = "Hasil"
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Location = New System.Drawing.Point(62, 267)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.Size = New System.Drawing.Size(368, 76)
        Me.Txb_hasil.TabIndex = 15
        '
        'Txb_matrik2
        '
        Me.Txb_matrik2.Location = New System.Drawing.Point(62, 172)
        Me.Txb_matrik2.Multiline = True
        Me.Txb_matrik2.Name = "Txb_matrik2"
        Me.Txb_matrik2.Size = New System.Drawing.Size(368, 76)
        Me.Txb_matrik2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Matrik 2"
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_operasi.FormattingEnabled = True
        Me.Cmb_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Cmb_operasi.Location = New System.Drawing.Point(62, 125)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(368, 21)
        Me.Cmb_operasi.TabIndex = 12
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(13, 128)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 11
        Me.Lbl_operasi.Text = "Operasi"
        '
        'Txb_matrik1
        '
        Me.Txb_matrik1.Location = New System.Drawing.Point(62, 27)
        Me.Txb_matrik1.Multiline = True
        Me.Txb_matrik1.Name = "Txb_matrik1"
        Me.Txb_matrik1.Size = New System.Drawing.Size(368, 76)
        Me.Txb_matrik1.TabIndex = 10
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(14, 30)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 9
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 428)
        Me.Controls.Add(Me.Btn_proses)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Txb_matrik2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.Txb_matrik1)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Txb_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents Txb_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents Btn_proses As System.Windows.Forms.Button
End Class

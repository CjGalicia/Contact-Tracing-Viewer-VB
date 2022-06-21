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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.readBtn = New System.Windows.Forms.Button()
        Me.importBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.displayBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.titleLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.titleLbl.Location = New System.Drawing.Point(12, 9)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(393, 25)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Quezon City Contact Tracing Viewer"
        '
        'readBtn
        '
        Me.readBtn.BackColor = System.Drawing.Color.PowderBlue
        Me.readBtn.Location = New System.Drawing.Point(29, 51)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(75, 23)
        Me.readBtn.TabIndex = 2
        Me.readBtn.Text = "Read"
        Me.readBtn.UseVisualStyleBackColor = False
        '
        'importBtn
        '
        Me.importBtn.BackColor = System.Drawing.Color.PowderBlue
        Me.importBtn.Location = New System.Drawing.Point(29, 80)
        Me.importBtn.Name = "importBtn"
        Me.importBtn.Size = New System.Drawing.Size(75, 23)
        Me.importBtn.TabIndex = 3
        Me.importBtn.Text = "Import"
        Me.importBtn.UseVisualStyleBackColor = False
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.PowderBlue
        Me.resetBtn.Location = New System.Drawing.Point(29, 241)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(75, 23)
        Me.resetBtn.TabIndex = 4
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'displayBox
        '
        Me.displayBox.Location = New System.Drawing.Point(141, 52)
        Me.displayBox.Name = "displayBox"
        Me.displayBox.Size = New System.Drawing.Size(256, 233)
        Me.displayBox.TabIndex = 5
        Me.displayBox.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(409, 544)
        Me.Controls.Add(Me.displayBox)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.importBtn)
        Me.Controls.Add(Me.readBtn)
        Me.Controls.Add(Me.titleLbl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Quezon City Contact Tracing Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents readBtn As Button
    Friend WithEvents importBtn As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents displayBox As RichTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDialog
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
        Me.pbxMainPic = New System.Windows.Forms.PictureBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.tbxBookName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCOnfirm = New System.Windows.Forms.Button()
        CType(Me.pbxMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxMainPic
        '
        Me.pbxMainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxMainPic.Image = Global.CustomDialog.My.Resources.Resources.mysleni
        Me.pbxMainPic.Location = New System.Drawing.Point(40, 49)
        Me.pbxMainPic.MinimumSize = New System.Drawing.Size(402, 582)
        Me.pbxMainPic.Name = "pbxMainPic"
        Me.pbxMainPic.Size = New System.Drawing.Size(402, 582)
        Me.pbxMainPic.TabIndex = 0
        Me.pbxMainPic.TabStop = False
        '
        'lblBook
        '
        Me.lblBook.AutoSize = True
        Me.lblBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBook.Location = New System.Drawing.Point(531, 68)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(162, 32)
        Me.lblBook.TabIndex = 1
        Me.lblBook.Text = "Book Name"
        '
        'tbxBookName
        '
        Me.tbxBookName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbxBookName.Location = New System.Drawing.Point(535, 110)
        Me.tbxBookName.Name = "tbxBookName"
        Me.tbxBookName.Size = New System.Drawing.Size(483, 35)
        Me.tbxBookName.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(810, 407)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(165, 71)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCOnfirm
        '
        Me.btnCOnfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCOnfirm.Location = New System.Drawing.Point(528, 407)
        Me.btnCOnfirm.Name = "btnCOnfirm"
        Me.btnCOnfirm.Size = New System.Drawing.Size(165, 71)
        Me.btnCOnfirm.TabIndex = 3
        Me.btnCOnfirm.Text = "Confirm"
        Me.btnCOnfirm.UseVisualStyleBackColor = True
        '
        'NewDialog
        '
        Me.AcceptButton = Me.btnCOnfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1056, 652)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCOnfirm)
        Me.Controls.Add(Me.tbxBookName)
        Me.Controls.Add(Me.lblBook)
        Me.Controls.Add(Me.pbxMainPic)
        Me.MinimumSize = New System.Drawing.Size(1078, 708)
        Me.Name = "NewDialog"
        Me.Text = "NewForm"
        CType(Me.pbxMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxMainPic As PictureBox
    Friend WithEvents lblBook As Label
    Friend WithEvents tbxBookName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCOnfirm As Button
End Class

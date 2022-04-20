<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtMatricNo = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtSNIC = New System.Windows.Forms.TextBox()
        Me.txtSTP = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress3 = New System.Windows.Forms.TextBox()
        Me.lblAddress3 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblNIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMatricNo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnPrev)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.txtMatricNo)
        Me.GroupBox1.Controls.Add(Me.txtSName)
        Me.GroupBox1.Controls.Add(Me.txtSNIC)
        Me.GroupBox1.Controls.Add(Me.txtSTP)
        Me.GroupBox1.Controls.Add(Me.txtAddress1)
        Me.GroupBox1.Controls.Add(Me.txtAddress2)
        Me.GroupBox1.Controls.Add(Me.txtAddress3)
        Me.GroupBox1.Controls.Add(Me.lblAddress3)
        Me.GroupBox1.Controls.Add(Me.lblAddress2)
        Me.GroupBox1.Controls.Add(Me.lblAddress1)
        Me.GroupBox1.Controls.Add(Me.lblTP)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblNIC)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblMatricNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 469)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Management"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(229, 179)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(77, 30)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(312, 179)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(103, 30)
        Me.radFemale.TabIndex = 2
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(507, 367)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(49, 37)
        Me.btnLast.TabIndex = 26
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(452, 367)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(49, 37)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(397, 367)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(49, 37)
        Me.btnPrev.TabIndex = 24
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(703, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 39)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(595, 365)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 39)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(703, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 35)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(686, 155)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 35)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(686, 196)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(116, 35)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(686, 237)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 35)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(342, 367)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(49, 37)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtMatricNo
        '
        Me.txtMatricNo.Location = New System.Drawing.Point(229, 74)
        Me.txtMatricNo.Name = "txtMatricNo"
        Me.txtMatricNo.Size = New System.Drawing.Size(209, 32)
        Me.txtMatricNo.TabIndex = 15
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(229, 110)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(318, 32)
        Me.txtSName.TabIndex = 14
        '
        'txtSNIC
        '
        Me.txtSNIC.Location = New System.Drawing.Point(229, 146)
        Me.txtSNIC.Name = "txtSNIC"
        Me.txtSNIC.Size = New System.Drawing.Size(209, 32)
        Me.txtSNIC.TabIndex = 13
        '
        'txtSTP
        '
        Me.txtSTP.Location = New System.Drawing.Point(229, 215)
        Me.txtSTP.Name = "txtSTP"
        Me.txtSTP.Size = New System.Drawing.Size(209, 32)
        Me.txtSTP.TabIndex = 12
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(229, 253)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(327, 32)
        Me.txtAddress1.TabIndex = 11
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(229, 290)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(327, 32)
        Me.txtAddress2.TabIndex = 10
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(229, 329)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(327, 32)
        Me.txtAddress3.TabIndex = 9
        '
        'lblAddress3
        '
        Me.lblAddress3.AutoSize = True
        Me.lblAddress3.Location = New System.Drawing.Point(105, 332)
        Me.lblAddress3.Name = "lblAddress3"
        Me.lblAddress3.Size = New System.Drawing.Size(110, 26)
        Me.lblAddress3.TabIndex = 7
        Me.lblAddress3.Text = "Address3:"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(105, 296)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(110, 26)
        Me.lblAddress2.TabIndex = 6
        Me.lblAddress2.Text = "Address2:"
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(105, 256)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(110, 26)
        Me.lblAddress1.TabIndex = 5
        Me.lblAddress1.Text = "Address1:"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(62, 218)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(153, 26)
        Me.lblTP.TabIndex = 4
        Me.lblTP.Text = "Telephone No:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(125, 182)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(90, 26)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender:"
        '
        'lblNIC
        '
        Me.lblNIC.AutoSize = True
        Me.lblNIC.Location = New System.Drawing.Point(141, 146)
        Me.lblNIC.Name = "lblNIC"
        Me.lblNIC.Size = New System.Drawing.Size(74, 26)
        Me.lblNIC.TabIndex = 2
        Me.lblNIC.Text = "IC No:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(68, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(158, 26)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Student Name:"
        '
        'lblMatricNo
        '
        Me.lblMatricNo.AutoSize = True
        Me.lblMatricNo.Location = New System.Drawing.Point(62, 74)
        Me.lblMatricNo.Name = "lblMatricNo"
        Me.lblMatricNo.Size = New System.Drawing.Size(161, 26)
        Me.lblMatricNo.TabIndex = 0
        Me.lblMatricNo.Text = "Matric Number:"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(872, 493)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmStudent"
        Me.Text = "Student Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTP As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblNIC As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblMatricNo As Label
    Friend WithEvents lblAddress3 As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents txtMatricNo As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtSNIC As TextBox
    Friend WithEvents txtSTP As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress3 As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
End Class

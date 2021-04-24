<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlaceOrder
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
        Me.spnrTableNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxReward = New System.Windows.Forms.GroupBox()
        Me.cboxRewardAccept = New System.Windows.Forms.CheckBox()
        Me.lblReward = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnRewardChk = New System.Windows.Forms.Button()
        Me.cboxMenuItems = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.spnrQnty = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemTotal = New System.Windows.Forms.TextBox()
        Me.txtItemNotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        CType(Me.spnrTableNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxReward.SuspendLayout()
        CType(Me.spnrQnty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spnrTableNum
        '
        Me.spnrTableNum.Location = New System.Drawing.Point(114, 16)
        Me.spnrTableNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnrTableNum.Name = "spnrTableNum"
        Me.spnrTableNum.Size = New System.Drawing.Size(120, 20)
        Me.spnrTableNum.TabIndex = 0
        Me.spnrTableNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Table Number"
        '
        'gboxReward
        '
        Me.gboxReward.Controls.Add(Me.cboxRewardAccept)
        Me.gboxReward.Controls.Add(Me.lblReward)
        Me.gboxReward.Location = New System.Drawing.Point(25, 107)
        Me.gboxReward.Name = "gboxReward"
        Me.gboxReward.Size = New System.Drawing.Size(209, 73)
        Me.gboxReward.TabIndex = 2
        Me.gboxReward.TabStop = False
        Me.gboxReward.Text = "Reward"
        '
        'cboxRewardAccept
        '
        Me.cboxRewardAccept.AutoSize = True
        Me.cboxRewardAccept.Enabled = False
        Me.cboxRewardAccept.Location = New System.Drawing.Point(57, 43)
        Me.cboxRewardAccept.Name = "cboxRewardAccept"
        Me.cboxRewardAccept.Size = New System.Drawing.Size(100, 17)
        Me.cboxRewardAccept.TabIndex = 1
        Me.cboxRewardAccept.Text = "Accept Reward"
        Me.cboxRewardAccept.UseVisualStyleBackColor = True
        '
        'lblReward
        '
        Me.lblReward.AutoSize = True
        Me.lblReward.Location = New System.Drawing.Point(76, 16)
        Me.lblReward.Name = "lblReward"
        Me.lblReward.Size = New System.Drawing.Size(61, 13)
        Me.lblReward.TabIndex = 0
        Me.lblReward.Text = "No Reward"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(114, 48)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(120, 20)
        Me.txtPhone.TabIndex = 4
        '
        'btnRewardChk
        '
        Me.btnRewardChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRewardChk.Location = New System.Drawing.Point(81, 78)
        Me.btnRewardChk.Name = "btnRewardChk"
        Me.btnRewardChk.Size = New System.Drawing.Size(120, 23)
        Me.btnRewardChk.TabIndex = 5
        Me.btnRewardChk.Text = "Check for Reward"
        Me.btnRewardChk.UseVisualStyleBackColor = True
        '
        'cboxMenuItems
        '
        Me.cboxMenuItems.FormattingEnabled = True
        Me.cboxMenuItems.Location = New System.Drawing.Point(25, 206)
        Me.cboxMenuItems.Name = "cboxMenuItems"
        Me.cboxMenuItems.Size = New System.Drawing.Size(209, 21)
        Me.cboxMenuItems.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Menu Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity"
        '
        'spnrQnty
        '
        Me.spnrQnty.Location = New System.Drawing.Point(104, 239)
        Me.spnrQnty.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.spnrQnty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnrQnty.Name = "spnrQnty"
        Me.spnrQnty.Size = New System.Drawing.Size(130, 20)
        Me.spnrQnty.TabIndex = 9
        Me.spnrQnty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Item Total"
        '
        'txtItemTotal
        '
        Me.txtItemTotal.Location = New System.Drawing.Point(104, 341)
        Me.txtItemTotal.Name = "txtItemTotal"
        Me.txtItemTotal.ReadOnly = True
        Me.txtItemTotal.Size = New System.Drawing.Size(130, 20)
        Me.txtItemTotal.TabIndex = 11
        '
        'txtItemNotes
        '
        Me.txtItemNotes.Location = New System.Drawing.Point(25, 288)
        Me.txtItemNotes.Multiline = True
        Me.txtItemNotes.Name = "txtItemNotes"
        Me.txtItemNotes.Size = New System.Drawing.Size(210, 47)
        Me.txtItemNotes.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Item Notes"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(81, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Location = New System.Drawing.Point(104, 404)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.ReadOnly = True
        Me.txtOrderTotal.Size = New System.Drawing.Size(130, 20)
        Me.txtOrderTotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Order Total"
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplete.Location = New System.Drawing.Point(81, 435)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(120, 23)
        Me.btnComplete.TabIndex = 17
        Me.btnComplete.Text = "Complete Order"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'FormPlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 469)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.txtOrderTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtItemNotes)
        Me.Controls.Add(Me.txtItemTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.spnrQnty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxMenuItems)
        Me.Controls.Add(Me.btnRewardChk)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gboxReward)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.spnrTableNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormPlaceOrder"
        Me.Text = "Place Order"
        CType(Me.spnrTableNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxReward.ResumeLayout(False)
        Me.gboxReward.PerformLayout()
        CType(Me.spnrQnty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spnrTableNum As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents gboxReward As GroupBox
    Friend WithEvents cboxRewardAccept As CheckBox
    Friend WithEvents lblReward As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnRewardChk As Button
    Friend WithEvents cboxMenuItems As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents spnrQnty As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemTotal As TextBox
    Friend WithEvents txtItemNotes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnComplete As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventoryManager
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.DataGridViewInventory = New System.Windows.Forms.DataGridView()
        Me.btnSaveToFileMngr = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBottleLvl = New System.Windows.Forms.TextBox()
        Me.txtBottleID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeleteID = New System.Windows.Forms.TextBox()
        Me.DataGridViewEditINV = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddQTY = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewEditINV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(38, 44)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 619)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.DataGridViewInventory)
        Me.TabPage1.Controls.Add(Me.btnSaveToFileMngr)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.txtBottleLvl)
        Me.TabPage1.Controls.Add(Me.txtBottleID)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1311, 572)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(235, 115)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 31)
        Me.txtName.TabIndex = 22
        '
        'DataGridViewInventory
        '
        Me.DataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventory.Location = New System.Drawing.Point(344, 208)
        Me.DataGridViewInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewInventory.Name = "DataGridViewInventory"
        Me.DataGridViewInventory.RowHeadersWidth = 82
        Me.DataGridViewInventory.RowTemplate.Height = 33
        Me.DataGridViewInventory.Size = New System.Drawing.Size(868, 344)
        Me.DataGridViewInventory.TabIndex = 21
        '
        'btnSaveToFileMngr
        '
        Me.btnSaveToFileMngr.Location = New System.Drawing.Point(56, 429)
        Me.btnSaveToFileMngr.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveToFileMngr.Name = "btnSaveToFileMngr"
        Me.btnSaveToFileMngr.Size = New System.Drawing.Size(142, 54)
        Me.btnSaveToFileMngr.TabIndex = 20
        Me.btnSaveToFileMngr.Text = "Save To File"
        Me.btnSaveToFileMngr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Inventory Editor"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(56, 346)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 54)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBottleLvl
        '
        Me.txtBottleLvl.Location = New System.Drawing.Point(200, 265)
        Me.txtBottleLvl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBottleLvl.Name = "txtBottleLvl"
        Me.txtBottleLvl.Size = New System.Drawing.Size(100, 31)
        Me.txtBottleLvl.TabIndex = 16
        '
        'txtBottleID
        '
        Me.txtBottleID.Location = New System.Drawing.Point(200, 206)
        Me.txtBottleID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBottleID.Name = "txtBottleID"
        Me.txtBottleID.Size = New System.Drawing.Size(100, 31)
        Me.txtBottleID.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bottle Level:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 208)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Item ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employee Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtDeleteID)
        Me.TabPage2.Controls.Add(Me.DataGridViewEditINV)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.txtAddName)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtAddQTY)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Controls.Add(Me.txtAddID)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1311, 572)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 436)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Delete Item with ID:"
        '
        'txtDeleteID
        '
        Me.txtDeleteID.Location = New System.Drawing.Point(232, 430)
        Me.txtDeleteID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeleteID.Name = "txtDeleteID"
        Me.txtDeleteID.Size = New System.Drawing.Size(100, 31)
        Me.txtDeleteID.TabIndex = 37
        '
        'DataGridViewEditINV
        '
        Me.DataGridViewEditINV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEditINV.Location = New System.Drawing.Point(352, 173)
        Me.DataGridViewEditINV.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewEditINV.Name = "DataGridViewEditINV"
        Me.DataGridViewEditINV.RowHeadersWidth = 82
        Me.DataGridViewEditINV.RowTemplate.Height = 33
        Me.DataGridViewEditINV.Size = New System.Drawing.Size(905, 344)
        Me.DataGridViewEditINV.TabIndex = 36
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(720, 115)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(378, 31)
        Me.DateTimePicker2.TabIndex = 35
        Me.DateTimePicker2.Value = New Date(2020, 3, 12, 18, 23, 31, 0)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(33, 485)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(142, 54)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtAddName
        '
        Me.txtAddName.Location = New System.Drawing.Point(232, 221)
        Me.txtAddName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(100, 31)
        Me.txtAddName.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 221)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 25)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Item Name:"
        '
        'txtAddQTY
        '
        Me.txtAddQTY.Location = New System.Drawing.Point(232, 267)
        Me.txtAddQTY.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddQTY.Name = "txtAddQTY"
        Me.txtAddQTY.Size = New System.Drawing.Size(100, 31)
        Me.txtAddQTY.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 269)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Item Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Manager Editor"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(33, 342)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 54)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtAddID
        '
        Me.txtAddID.Location = New System.Drawing.Point(232, 173)
        Me.txtAddID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddID.Name = "txtAddID"
        Me.txtAddID.Size = New System.Drawing.Size(100, 31)
        Me.txtAddID.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 177)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 25)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Item ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(628, 121)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(244, 119)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 121)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Employee Name:"
        '
        'FormInventoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 706)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormInventoryManager"
        Me.Text = "FormInventoryManager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewEditINV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtName As TextBox
    Friend WithEvents DataGridViewInventory As DataGridView
    Friend WithEvents btnSaveToFileMngr As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtBottleLvl As TextBox
    Friend WithEvents txtBottleID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtAddName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAddQTY As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAddID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewEditINV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeleteID As TextBox
End Class

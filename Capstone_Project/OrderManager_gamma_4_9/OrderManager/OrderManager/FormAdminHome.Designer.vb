<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminHome
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSalesTotal = New System.Windows.Forms.TextBox()
        Me.cboxSalesPeriod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtSalesTotal)
        Me.Panel1.Controls.Add(Me.cboxSalesPeriod)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 243)
        Me.Panel1.TabIndex = 0
        '
        'txtSalesTotal
        '
        Me.txtSalesTotal.Location = New System.Drawing.Point(210, 12)
        Me.txtSalesTotal.Name = "txtSalesTotal"
        Me.txtSalesTotal.ReadOnly = True
        Me.txtSalesTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTotal.TabIndex = 2
        '
        'cboxSalesPeriod
        '
        Me.cboxSalesPeriod.FormattingEnabled = True
        Me.cboxSalesPeriod.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cboxSalesPeriod.Location = New System.Drawing.Point(20, 12)
        Me.cboxSalesPeriod.MaxDropDownItems = 3
        Me.cboxSalesPeriod.Name = "cboxSalesPeriod"
        Me.cboxSalesPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboxSalesPeriod.TabIndex = 1
        Me.cboxSalesPeriod.Text = "Select period"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "sales total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstOrders)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 190)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recent Orders"
        '
        'lstOrders
        '
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.Location = New System.Drawing.Point(7, 20)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstOrders.Size = New System.Drawing.Size(228, 160)
        Me.lstOrders.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(387, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstCustomers)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 190)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customers Last Served"
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(7, 20)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(218, 160)
        Me.lstCustomers.TabIndex = 0
        '
        'FormAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 319)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormAdminHome"
        Me.Text = "Point of Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSalesTotal As TextBox
    Friend WithEvents cboxSalesPeriod As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lstOrders As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstCustomers As ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewOrders
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.spnrNumOrders = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        CType(Me.spnrNumOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View the last (n) orders"
        '
        'spnrNumOrders
        '
        Me.spnrNumOrders.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.spnrNumOrders.Location = New System.Drawing.Point(267, 7)
        Me.spnrNumOrders.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.spnrNumOrders.Name = "spnrNumOrders"
        Me.spnrNumOrders.Size = New System.Drawing.Size(57, 20)
        Me.spnrNumOrders.TabIndex = 1
        Me.spnrNumOrders.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvOrders)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 262)
        Me.Panel1.TabIndex = 2
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrders.Location = New System.Drawing.Point(0, 0)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.Size = New System.Drawing.Size(446, 262)
        Me.dgvOrders.TabIndex = 0
        '
        'FormViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 307)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.spnrNumOrders)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormViewOrders"
        Me.Text = "View Orders"
        CType(Me.spnrNumOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents spnrNumOrders As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvOrders As DataGridView
End Class

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
        Me.btnCustomerInfo = New System.Windows.Forms.Button()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomerInfo
        '
        Me.btnCustomerInfo.Location = New System.Drawing.Point(74, 12)
        Me.btnCustomerInfo.Name = "btnCustomerInfo"
        Me.btnCustomerInfo.Size = New System.Drawing.Size(144, 29)
        Me.btnCustomerInfo.TabIndex = 0
        Me.btnCustomerInfo.Text = "Enter Customer Information"
        Me.btnCustomerInfo.UseVisualStyleBackColor = True
        '
        'lblHighest
        '
        Me.lblHighest.Location = New System.Drawing.Point(12, 44)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(268, 39)
        Me.lblHighest.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(15, 83)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(265, 36)
        Me.lblAverage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 138)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.btnCustomerInfo)
        Me.Name = "Form1"
        Me.Text = "Customers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class

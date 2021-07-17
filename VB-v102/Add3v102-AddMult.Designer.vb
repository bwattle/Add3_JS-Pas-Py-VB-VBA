<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add3v102
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
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNo3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSumValue = New System.Windows.Forms.TextBox()
        Me.btnCalcSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(98, 41)
        Me.txtNo1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(104, 20)
        Me.txtNo1.TabIndex = 0
        Me.txtNo1.Text = "Enter #1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'txtNo2
        '
        Me.txtNo2.Location = New System.Drawing.Point(98, 68)
        Me.txtNo2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNo2.Name = "txtNo2"
        Me.txtNo2.Size = New System.Drawing.Size(104, 20)
        Me.txtNo2.TabIndex = 1
        Me.txtNo2.Text = "Enter #2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3rd Number"
        '
        'txtNo3
        '
        Me.txtNo3.Location = New System.Drawing.Point(98, 97)
        Me.txtNo3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNo3.Name = "txtNo3"
        Me.txtNo3.Size = New System.Drawing.Size(104, 20)
        Me.txtNo3.TabIndex = 2
        Me.txtNo3.Text = "Enter #3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sum "
        '
        'txtSumValue
        '
        Me.txtSumValue.Location = New System.Drawing.Point(98, 172)
        Me.txtSumValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSumValue.Name = "txtSumValue"
        Me.txtSumValue.Size = New System.Drawing.Size(104, 20)
        Me.txtSumValue.TabIndex = 6
        Me.txtSumValue.Text = "Answer"
        '
        'btnCalcSum
        '
        Me.btnCalcSum.Location = New System.Drawing.Point(34, 131)
        Me.btnCalcSum.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcSum.Name = "btnCalcSum"
        Me.btnCalcSum.Size = New System.Drawing.Size(168, 22)
        Me.btnCalcSum.TabIndex = 3
        Me.btnCalcSum.Text = "Calculate Sum"
        Me.btnCalcSum.UseVisualStyleBackColor = True
        '
        'Add3v102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 248)
        Me.Controls.Add(Me.btnCalcSum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSumValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNo3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNo1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Add3v102"
        Me.Text = "v102 Add3 Adds and Multiplies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNo1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNo2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNo3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSumValue As TextBox
    Friend WithEvents btnCalcSum As Button
End Class

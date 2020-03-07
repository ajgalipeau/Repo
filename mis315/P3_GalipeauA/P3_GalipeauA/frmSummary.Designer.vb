<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.lblChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.lblTotalTicketsSold = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNetTotal = New System.Windows.Forms.TextBox()
        Me.lblChildNet = New System.Windows.Forms.TextBox()
        Me.lblAdultNet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGrossTotal = New System.Windows.Forms.TextBox()
        Me.lblChildTotal = New System.Windows.Forms.TextBox()
        Me.lblAdultTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCloseSummary = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Summary Ticket Sales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotalTicketsSold)
        Me.GroupBox1.Controls.Add(Me.lblChildTicketsSold)
        Me.GroupBox1.Controls.Add(Me.lblAdultTicketsSold)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 113)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of Tickets Sold"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. of Adult Tickets:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total No. of Tickets:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdultTicketsSold
        '
        Me.lblAdultTicketsSold.Location = New System.Drawing.Point(188, 21)
        Me.lblAdultTicketsSold.Name = "lblAdultTicketsSold"
        Me.lblAdultTicketsSold.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultTicketsSold.TabIndex = 3
        '
        'lblChildTicketsSold
        '
        Me.lblChildTicketsSold.Location = New System.Drawing.Point(188, 50)
        Me.lblChildTicketsSold.Name = "lblChildTicketsSold"
        Me.lblChildTicketsSold.Size = New System.Drawing.Size(100, 20)
        Me.lblChildTicketsSold.TabIndex = 4
        '
        'lblTotalTicketsSold
        '
        Me.lblTotalTicketsSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTicketsSold.Location = New System.Drawing.Point(188, 80)
        Me.lblTotalTicketsSold.Name = "lblTotalTicketsSold"
        Me.lblTotalTicketsSold.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalTicketsSold.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. of Child Tickets:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblNetTotal)
        Me.GroupBox2.Controls.Add(Me.lblChildNet)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblAdultNet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 113)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Net Revenue"
        '
        'lblNetTotal
        '
        Me.lblNetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetTotal.Location = New System.Drawing.Point(188, 80)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblNetTotal.TabIndex = 5
        '
        'lblChildNet
        '
        Me.lblChildNet.Location = New System.Drawing.Point(188, 50)
        Me.lblChildNet.Name = "lblChildNet"
        Me.lblChildNet.Size = New System.Drawing.Size(100, 20)
        Me.lblChildNet.TabIndex = 4
        '
        'lblAdultNet
        '
        Me.lblAdultNet.Location = New System.Drawing.Point(188, 21)
        Me.lblAdultNet.Name = "lblAdultNet"
        Me.lblAdultNet.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultNet.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total Net Revenue"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblGrossTotal)
        Me.GroupBox3.Controls.Add(Me.lblChildTotal)
        Me.GroupBox3.Controls.Add(Me.lblAdultTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(68, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 113)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Revenue"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(64, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Child Ticket Sales:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrossTotal
        '
        Me.lblGrossTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossTotal.Location = New System.Drawing.Point(188, 80)
        Me.lblGrossTotal.Name = "lblGrossTotal"
        Me.lblGrossTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblGrossTotal.TabIndex = 5
        '
        'lblChildTotal
        '
        Me.lblChildTotal.Location = New System.Drawing.Point(188, 50)
        Me.lblChildTotal.Name = "lblChildTotal"
        Me.lblChildTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblChildTotal.TabIndex = 4
        '
        'lblAdultTotal
        '
        Me.lblAdultTotal.Location = New System.Drawing.Point(188, 21)
        Me.lblAdultTotal.Name = "lblAdultTotal"
        Me.lblAdultTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultTotal.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Gross Revenue:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(64, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Adult Ticket Sales:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(64, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 21)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Child Ticket Sales:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(64, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Adult Ticket Sales:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCloseSummary
        '
        Me.btnCloseSummary.Location = New System.Drawing.Point(336, 375)
        Me.btnCloseSummary.Name = "btnCloseSummary"
        Me.btnCloseSummary.Size = New System.Drawing.Size(127, 39)
        Me.btnCloseSummary.TabIndex = 8
        Me.btnCloseSummary.Text = "Close"
        Me.btnCloseSummary.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCloseSummary)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalTicketsSold As TextBox
    Friend WithEvents lblChildTicketsSold As TextBox
    Friend WithEvents lblAdultTicketsSold As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNetTotal As TextBox
    Friend WithEvents lblChildNet As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAdultNet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblGrossTotal As TextBox
    Friend WithEvents lblChildTotal As TextBox
    Friend WithEvents lblAdultTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCloseSummary As Button
End Class

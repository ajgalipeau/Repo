<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheater
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateTicketRevenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySummaryRevenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtAdultTicket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtChildTicket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGrossTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblChildTotal = New System.Windows.Forms.TextBox()
        Me.lblAdultTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblChildNet = New System.Windows.Forms.TextBox()
        Me.lblAdultNet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateTicketRevenueToolStripMenuItem, Me.DisplaySummaryRevenueToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateTicketRevenueToolStripMenuItem
        '
        Me.CalculateTicketRevenueToolStripMenuItem.Name = "CalculateTicketRevenueToolStripMenuItem"
        Me.CalculateTicketRevenueToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CalculateTicketRevenueToolStripMenuItem.Text = "&Calculate Ticket Revenue"
        Me.CalculateTicketRevenueToolStripMenuItem.ToolTipText = "Calculate and display gross and net revenues"
        '
        'DisplaySummaryRevenueToolStripMenuItem
        '
        Me.DisplaySummaryRevenueToolStripMenuItem.Name = "DisplaySummaryRevenueToolStripMenuItem"
        Me.DisplaySummaryRevenueToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DisplaySummaryRevenueToolStripMenuItem.Text = "Display &Summary Revenue"
        Me.DisplaySummaryRevenueToolStripMenuItem.ToolTipText = "Display summary total sales and revenues"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Terminate project execution"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        Me.ClearToolStripMenuItem.ToolTipText = "Clear all textboxes and labels on this form"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear &All"
        Me.ClearAllToolStripMenuItem.ToolTipText = "Clear all textboxes and labels on this form and the Summary form, and reinitializ" &
    "e totals"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        Me.AboutToolStripMenuItem.ToolTipText = "Display About Box"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketsSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultTicket)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AdultTicketSales"
        '
        'txtAdultTicketsSold
        '
        Me.txtAdultTicketsSold.Location = New System.Drawing.Point(164, 101)
        Me.txtAdultTicketsSold.Name = "txtAdultTicketsSold"
        Me.txtAdultTicketsSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTicketsSold.TabIndex = 1
        '
        'txtAdultTicket
        '
        Me.txtAdultTicket.Location = New System.Drawing.Point(164, 46)
        Me.txtAdultTicket.Name = "txtAdultTicket"
        Me.txtAdultTicket.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTicket.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtChildTicketsSold)
        Me.GroupBox3.Controls.Add(Me.txtChildTicket)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(427, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 164)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Child Ticket Sales"
        '
        'txtChildTicketsSold
        '
        Me.txtChildTicketsSold.Location = New System.Drawing.Point(164, 101)
        Me.txtChildTicketsSold.Name = "txtChildTicketsSold"
        Me.txtChildTicketsSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTicketsSold.TabIndex = 1
        '
        'txtChildTicket
        '
        Me.txtChildTicket.Location = New System.Drawing.Point(164, 46)
        Me.txtChildTicket.Name = "txtChildTicket"
        Me.txtChildTicket.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTicket.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tickets Sold:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price Per Ticket:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblGrossTotal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblChildTotal)
        Me.GroupBox2.Controls.Add(Me.lblAdultTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 187)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gross Ticket Revenue"
        '
        'lblGrossTotal
        '
        Me.lblGrossTotal.Location = New System.Drawing.Point(164, 120)
        Me.lblGrossTotal.Name = "lblGrossTotal"
        Me.lblGrossTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblGrossTotal.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(43, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 33)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Gross Revenue for Ticket Sales:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChildTotal
        '
        Me.lblChildTotal.Location = New System.Drawing.Point(164, 84)
        Me.lblChildTotal.Name = "lblChildTotal"
        Me.lblChildTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblChildTotal.TabIndex = 1
        '
        'lblAdultTotal
        '
        Me.lblAdultTotal.Location = New System.Drawing.Point(164, 46)
        Me.lblAdultTotal.Name = "lblAdultTotal"
        Me.lblAdultTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultTotal.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Child Ticket Sales:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Adult Ticket Sales:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalNet)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.lblChildNet)
        Me.GroupBox4.Controls.Add(Me.lblAdultNet)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(427, 305)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(337, 187)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblTotalNet
        '
        Me.lblTotalNet.Location = New System.Drawing.Point(164, 120)
        Me.lblTotalNet.Name = "lblTotalNet"
        Me.lblTotalNet.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalNet.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(43, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 33)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total Gross Revenue for Ticket Sales:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChildNet
        '
        Me.lblChildNet.Location = New System.Drawing.Point(164, 84)
        Me.lblChildNet.Name = "lblChildNet"
        Me.lblChildNet.Size = New System.Drawing.Size(100, 20)
        Me.lblChildNet.TabIndex = 1
        '
        'lblAdultNet
        '
        Me.lblAdultNet.Location = New System.Drawing.Point(164, 46)
        Me.lblAdultNet.Name = "lblAdultNet"
        Me.lblAdultNet.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultNet.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Child Ticket Sales:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Adult Ticket Sales:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(578, 526)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Programmed by Aaron Galipeau, 2019"
        '
        'frmTheater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 560)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTheater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theater Revenue"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdultTicketsSold As TextBox
    Friend WithEvents txtAdultTicket As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtChildTicketsSold As TextBox
    Friend WithEvents txtChildTicket As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblGrossTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChildTotal As TextBox
    Friend WithEvents lblAdultTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotalNet As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblChildNet As TextBox
    Friend WithEvents lblAdultNet As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CalculateTicketRevenueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySummaryRevenueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip6 As ToolTip
End Class

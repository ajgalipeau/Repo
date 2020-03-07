' Project:           P3 frmTheater (revisited)
' Description:       This program calculates and displays the number of tickets 
'                   that a movie theater sells To children And To adults.  
'                   This program also computes And displays the gross 
'                   And net revenues generated from adult ticket sales 
'                   As well As child ticket sales.
'
' Programmer:        Aaron Galipeau
' Date:              4/24/2019
' Option Strict ON
Public Class frmTheater

    'Declare the Constant "Sales Tax" of 20% for the Theater

    Const decSALESTAX As Decimal = 0.2D

    'Declare the variables for the program execution

    Dim decAdultTicket As Decimal
    Dim intAdultTicketsSold As Integer
    Dim decChildTicket As Decimal
    Dim intChildTicketsSold As Integer
    Dim decAdultTotal As Decimal
    Dim decChildTotal As Decimal
    Dim decGrossTotal As Decimal
    Dim decAdultNet As Decimal
    Dim decChildNet As Decimal
    Dim decTotalNet As Decimal
    Dim blnAdultPriceError As Boolean
    Dim blnAdultTicketsSold As Boolean
    Dim blnChildPriceError As Boolean
    Dim blnChildTicketsSold As Boolean



    Private Sub CalculateTicketRevenueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateTicketRevenueToolStripMenuItem.Click


        If ValidateInput() = False Then
            ' Perform Calculation

            'Group Box Gross Ticket Revenue
            decAdultTotal = (decAdultTicket * intAdultTicketsSold)
            lblAdultTotal.Text = decAdultTotal.ToString("C2")

            decChildTotal = (decChildTicket * intChildTicketsSold)
            lblChildTotal.Text = decChildTotal.ToString("C2")

            decGrossTotal = decAdultTotal + decChildTicket
            lblGrossTotal.Text = decGrossTotal.ToString("C2")

            'Group Box Net Ticket Revenue
            decAdultNet = (decSALESTAX * decAdultTotal)
            lblAdultNet.Text = decAdultNet.ToString("C2")

            decChildNet = (decSALESTAX * decChildTotal)
            lblChildNet.Text = decChildNet.ToString("C2")

            decTotalNet = decAdultNet + decChildNet
            lblTotalNet.Text = decTotalNet.ToString("C2")
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'Close the Program

        Me.Close()

    End Sub

    Private Sub frmTheater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

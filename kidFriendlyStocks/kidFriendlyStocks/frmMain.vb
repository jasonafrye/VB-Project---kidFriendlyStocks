'Program:       kidFriendlyStocks
'Developer:     Jason A. Frye
'Date:          7/17/11
'Purpose:       This Windows application opens an Access database in a Windows form with 16 child-centered stock picks from an investment portolfio. 
'               The database can be viewed, updated, and deleted. The application also computes the total investment made in a given stock, as well as
'               the entire portfolio and lists the name of all stocks in the portfolio with the same selected rating. 

Option Strict On
Option Explicit On
Imports System.Data

Public Class frmMain

#Region "Change/Load Events"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'this event uses a try-catch block to ensure that the associated database file is available. 
        'If so, it fills the dataadapter, if not it presents the user with an error and closes the program

        Try
            'TODO: This line of code loads data into the 'KidfriendlystocksDataSet.Stocks' table. You can move, or remove it, as needed.
            Me.StocksTableAdapter.Fill(Me.KidfriendlystocksDataSet.Stocks)
        Catch ex As Exception
            MsgBox("The database file is unavailable", , "Error")
            Close()
        End Try

        'call subprocedure to group similar earning potential ratings
        GroupRatings()

        'call subprocedure to remove un-used labels from the user's view
        ResetValues()

    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        'Calls the ResetValues subprocedure to reset the labels that show the user stock values
        ResetValues()

    End Sub

    Private Sub Earning_Potential_RatingComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Earning_Potential_RatingComboBox.SelectedIndexChanged
        'Calls the GroupRatings sub procedure to re-group earning potential ratings and display names in listbox
        GroupRatings()

    End Sub

#End Region

#Region "Click Events"

    Private Sub StocksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksBindingNavigatorSaveItem.Click
        'Validates the database information, ends the editing of the sourcefile, and updates the original database. 
        'This event was coded and created by the Database Wizard
        Me.Validate()
        Me.StocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KidfriendlystocksDataSet)

    End Sub

    Private Sub btnTotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'This event connects to the database, fills the datatable, and 
        'using a loop, calculates total worth of all stocks in the portfolio and presents it to the user.

        'strSql is a SQL statement that selects all the fields from the approvedtravelrequests table
        Dim strSql As String = "Select * FROM Stocks"

        'strPath provides the database type and path of the Travel database. 
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=kidfriendlystocks.accdb"
        Dim odaStocks As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datStocks As New DataTable

        'declare and prime loop control variable
        Dim intCount As Integer = 0
        'declare and prime variables for calculation
        Dim decSharePrice As Decimal = 0D
        Dim intNumShares As Integer = 0
        Dim decTotalWorth As Decimal = 0D

        'The datatable name datStocks is filled with the table data
        odaStocks.Fill(datStocks)

        'the conneciton to the database is disconnected
        odaStocks.Dispose()

        'count through entire database, retrieve number of shares and price per shares
        For intCount = 0 To datStocks.Rows.Count - 1
            decSharePrice = Convert.ToDecimal(datStocks.Rows(intCount)("Price per share"))
            intNumShares = Convert.ToInt32(datStocks.Rows(intCount)("Number Of Shares"))

            'accumulate stock value
            decTotalWorth += (decSharePrice * intNumShares)

        Next

        'make the Total Worth label visible and display the total worth to the user
        lblTotal.Visible = True
        lblTotal.Text = "The total stock cost is " & decTotalWorth.ToString("C")

    End Sub

    Private Sub btnValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValue.Click
        'This event multiplies the number of shares by the price per share of 
        'the currently selected stock to determine it's value and presents it to the user

        'declare/prime calculation variables and retrieve information from the form
        Dim intIndiShares As Integer = Convert.ToInt32(Number_of_sharesTextBox.Text)
        Dim decIndiPrice As Decimal = Convert.ToDecimal(Price_per_shareTextBox.Text)
        Dim decStockValue As Decimal = 0D

        'Value = number of shares * price per share
        decStockValue = intIndiShares * decIndiPrice

        'make the Stock Value label visible and display the stock value to the user
        lblValue.Visible = True
        lblValue.Text = "The total value of this stock is " & decStockValue.ToString("C")

    End Sub

#End Region

#Region "Functions, Properties, and Procedures"

    Private Sub ResetValues()
        'This procedure resets the the labels containing the value for 
        'the current stock and the total stock

        lblValue.Text = ""
        lblTotal.Text = ""
        lblValue.Visible = False
        lblTotal.Visible = False

    End Sub

    Private Sub GroupRatings()
        'This procedure connects to the database to populate the data table, then runs a loop to determine 
        'if the Earning Potential Rating of a given stock matches the currently selected stock. 
        'If so, the name of the stock is added to the list box. 


        'strSql is a SQL statement that selects all the fields from the approvedtravelrequests table
        Dim strSql As String = "Select * FROM Stocks"

        'strPath provides the database type and path of the Travel database. 
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=kidfriendlystocks.accdb"
        Dim odaStocks As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datRating As New DataTable

        'declare and prime loop control variable
        Dim intCount As Integer = 0

        'declare string value of rating
        Dim strRating As String


        'The datatable name datStocks is filled with the table data
        odaStocks.Fill(datRating)

        'the conneciton to the database is disconnection
        odaStocks.Dispose()

        'retrive rating value from the form and clear the listbox to start a fresh list
        strRating = Earning_Potential_RatingComboBox.Text
        lstRating.Items.Clear()

        'count through entire database to determine if the value ratings match
        For intCount = 0 To datRating.Rows.Count - 1
            If datRating.Rows(intCount)("Earning Potential Rating").ToString = strRating Then
                'if value ratings match, add stock name to the listbox
                lstRating.Items.Add(datRating.Rows(intCount)("Stock Name"))
            End If
        Next

    End Sub

#End Region

End Class

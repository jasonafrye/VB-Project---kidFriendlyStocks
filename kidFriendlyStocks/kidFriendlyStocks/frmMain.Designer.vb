<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim Earning_Potential_RatingLabel As System.Windows.Forms.Label
        Dim Stock_SymbolLabel1 As System.Windows.Forms.Label
        Dim Stock_NameLabel As System.Windows.Forms.Label
        Dim Date_PurchasedLabel1 As System.Windows.Forms.Label
        Dim Price_per_shareLabel1 As System.Windows.Forms.Label
        Dim Number_of_sharesLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.KidfriendlystocksDataSet = New kidFriendlyStocks.kidfriendlystocksDataSet()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTableAdapter = New kidFriendlyStocks.kidfriendlystocksDataSetTableAdapters.StocksTableAdapter()
        Me.TableAdapterManager = New kidFriendlyStocks.kidfriendlystocksDataSetTableAdapters.TableAdapterManager()
        Me.StocksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StocksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Stock_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.Earning_Potential_RatingComboBox = New System.Windows.Forms.ComboBox()
        Me.lstRating = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Number_of_sharesTextBox = New System.Windows.Forms.TextBox()
        Me.Price_per_shareTextBox = New System.Windows.Forms.TextBox()
        Me.Date_PurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_SymbolTextBox = New System.Windows.Forms.TextBox()
        Earning_Potential_RatingLabel = New System.Windows.Forms.Label()
        Stock_SymbolLabel1 = New System.Windows.Forms.Label()
        Stock_NameLabel = New System.Windows.Forms.Label()
        Date_PurchasedLabel1 = New System.Windows.Forms.Label()
        Price_per_shareLabel1 = New System.Windows.Forms.Label()
        Number_of_sharesLabel1 = New System.Windows.Forms.Label()
        CType(Me.KidfriendlystocksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StocksBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Earning_Potential_RatingLabel
        '
        Earning_Potential_RatingLabel.AutoSize = True
        Earning_Potential_RatingLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Earning_Potential_RatingLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Earning_Potential_RatingLabel.Location = New System.Drawing.Point(313, 42)
        Earning_Potential_RatingLabel.Name = "Earning_Potential_RatingLabel"
        Earning_Potential_RatingLabel.Size = New System.Drawing.Size(265, 33)
        Earning_Potential_RatingLabel.TabIndex = 11
        Earning_Potential_RatingLabel.Text = "Earning Potential Rating:"
        '
        'Stock_SymbolLabel1
        '
        Stock_SymbolLabel1.AutoSize = True
        Stock_SymbolLabel1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stock_SymbolLabel1.ForeColor = System.Drawing.Color.RoyalBlue
        Stock_SymbolLabel1.Location = New System.Drawing.Point(15, 75)
        Stock_SymbolLabel1.Name = "Stock_SymbolLabel1"
        Stock_SymbolLabel1.Size = New System.Drawing.Size(152, 33)
        Stock_SymbolLabel1.TabIndex = 13
        Stock_SymbolLabel1.Text = "Stock Symbol:"
        '
        'Stock_NameLabel
        '
        Stock_NameLabel.AutoSize = True
        Stock_NameLabel.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stock_NameLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Stock_NameLabel.Location = New System.Drawing.Point(15, 42)
        Stock_NameLabel.Name = "Stock_NameLabel"
        Stock_NameLabel.Size = New System.Drawing.Size(138, 33)
        Stock_NameLabel.TabIndex = 14
        Stock_NameLabel.Text = "Stock Name:"
        '
        'Date_PurchasedLabel1
        '
        Date_PurchasedLabel1.AutoSize = True
        Date_PurchasedLabel1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_PurchasedLabel1.ForeColor = System.Drawing.Color.RoyalBlue
        Date_PurchasedLabel1.Location = New System.Drawing.Point(12, 123)
        Date_PurchasedLabel1.Name = "Date_PurchasedLabel1"
        Date_PurchasedLabel1.Size = New System.Drawing.Size(173, 33)
        Date_PurchasedLabel1.TabIndex = 19
        Date_PurchasedLabel1.Text = "Date Purchased:"
        '
        'Price_per_shareLabel1
        '
        Price_per_shareLabel1.AutoSize = True
        Price_per_shareLabel1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Price_per_shareLabel1.ForeColor = System.Drawing.Color.RoyalBlue
        Price_per_shareLabel1.Location = New System.Drawing.Point(12, 154)
        Price_per_shareLabel1.Name = "Price_per_shareLabel1"
        Price_per_shareLabel1.Size = New System.Drawing.Size(169, 33)
        Price_per_shareLabel1.TabIndex = 20
        Price_per_shareLabel1.Text = "Price per share:"
        '
        'Number_of_sharesLabel1
        '
        Number_of_sharesLabel1.AutoSize = True
        Number_of_sharesLabel1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_sharesLabel1.ForeColor = System.Drawing.Color.RoyalBlue
        Number_of_sharesLabel1.Location = New System.Drawing.Point(12, 185)
        Number_of_sharesLabel1.Name = "Number_of_sharesLabel1"
        Number_of_sharesLabel1.Size = New System.Drawing.Size(137, 33)
        Number_of_sharesLabel1.TabIndex = 21
        Number_of_sharesLabel1.Text = "Total shares:"
        '
        'KidfriendlystocksDataSet
        '
        Me.KidfriendlystocksDataSet.DataSetName = "kidfriendlystocksDataSet"
        Me.KidfriendlystocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "Stocks"
        Me.StocksBindingSource.DataSource = Me.KidfriendlystocksDataSet
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StocksTableAdapter = Me.StocksTableAdapter
        Me.TableAdapterManager.UpdateOrder = kidFriendlyStocks.kidfriendlystocksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StocksBindingNavigator
        '
        Me.StocksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StocksBindingNavigator.BindingSource = Me.StocksBindingSource
        Me.StocksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StocksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StocksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StocksBindingNavigatorSaveItem})
        Me.StocksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StocksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StocksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StocksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StocksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StocksBindingNavigator.Name = "StocksBindingNavigator"
        Me.StocksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StocksBindingNavigator.Size = New System.Drawing.Size(971, 25)
        Me.StocksBindingNavigator.TabIndex = 0
        Me.StocksBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StocksBindingNavigatorSaveItem
        '
        Me.StocksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StocksBindingNavigatorSaveItem.Image = CType(resources.GetObject("StocksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StocksBindingNavigatorSaveItem.Name = "StocksBindingNavigatorSaveItem"
        Me.StocksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StocksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Stock_NameComboBox
        '
        Me.Stock_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Stock Name", True))
        Me.Stock_NameComboBox.DataSource = Me.StocksBindingSource
        Me.Stock_NameComboBox.DisplayMember = "Stock Name"
        Me.Stock_NameComboBox.FormattingEnabled = True
        Me.Stock_NameComboBox.Location = New System.Drawing.Point(168, 52)
        Me.Stock_NameComboBox.Name = "Stock_NameComboBox"
        Me.Stock_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Stock_NameComboBox.TabIndex = 15
        Me.Stock_NameComboBox.ValueMember = "Stock Name"
        '
        'btnTotal
        '
        Me.btnTotal.AutoSize = True
        Me.btnTotal.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnTotal.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.Coral
        Me.btnTotal.Location = New System.Drawing.Point(18, 221)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(239, 38)
        Me.btnTotal.TabIndex = 16
        Me.btnTotal.Text = "Compute Total Investment"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTotal.Location = New System.Drawing.Point(65, 262)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(85, 33)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "lblTotal"
        '
        'btnValue
        '
        Me.btnValue.AutoSize = True
        Me.btnValue.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnValue.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValue.ForeColor = System.Drawing.Color.Coral
        Me.btnValue.Location = New System.Drawing.Point(18, 298)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(115, 38)
        Me.btnValue.TabIndex = 18
        Me.btnValue.Text = "Stock Value"
        Me.btnValue.UseVisualStyleBackColor = False
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblValue.Location = New System.Drawing.Point(65, 339)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(88, 33)
        Me.lblValue.TabIndex = 19
        Me.lblValue.Text = "lblValue"
        '
        'Earning_Potential_RatingComboBox
        '
        Me.Earning_Potential_RatingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Earning Potential Rating", True))
        Me.Earning_Potential_RatingComboBox.DataSource = Me.StocksBindingSource
        Me.Earning_Potential_RatingComboBox.DisplayMember = "Earning Potential Rating"
        Me.Earning_Potential_RatingComboBox.FormattingEnabled = True
        Me.Earning_Potential_RatingComboBox.Location = New System.Drawing.Point(576, 49)
        Me.Earning_Potential_RatingComboBox.Name = "Earning_Potential_RatingComboBox"
        Me.Earning_Potential_RatingComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Earning_Potential_RatingComboBox.TabIndex = 23
        Me.Earning_Potential_RatingComboBox.ValueMember = "Earning Potential Rating"
        '
        'lstRating
        '
        Me.lstRating.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstRating.Font = New System.Drawing.Font("Jokerman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRating.ForeColor = System.Drawing.Color.Coral
        Me.lstRating.FormattingEnabled = True
        Me.lstRating.ItemHeight = 20
        Me.lstRating.Location = New System.Drawing.Point(319, 123)
        Me.lstRating.Name = "lstRating"
        Me.lstRating.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstRating.Size = New System.Drawing.Size(272, 140)
        Me.lstRating.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(313, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 33)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Similarly Rated Stocks"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.kidFriendlyStocks.My.Resources.Resources.BoyBusinessman1
        Me.PictureBox1.Location = New System.Drawing.Point(703, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 394)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(30, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(701, 47)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Investing in the Stock Market with your Children"
        '
        'Number_of_sharesTextBox
        '
        Me.Number_of_sharesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Number of shares", True))
        Me.Number_of_sharesTextBox.Location = New System.Drawing.Point(189, 195)
        Me.Number_of_sharesTextBox.Name = "Number_of_sharesTextBox"
        Me.Number_of_sharesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number_of_sharesTextBox.TabIndex = 28
        '
        'Price_per_shareTextBox
        '
        Me.Price_per_shareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Price per share", True))
        Me.Price_per_shareTextBox.Location = New System.Drawing.Point(189, 164)
        Me.Price_per_shareTextBox.Name = "Price_per_shareTextBox"
        Me.Price_per_shareTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Price_per_shareTextBox.TabIndex = 29
        '
        'Date_PurchasedTextBox
        '
        Me.Date_PurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Date Purchased", True))
        Me.Date_PurchasedTextBox.Location = New System.Drawing.Point(189, 133)
        Me.Date_PurchasedTextBox.Name = "Date_PurchasedTextBox"
        Me.Date_PurchasedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_PurchasedTextBox.TabIndex = 30
        '
        'Stock_SymbolTextBox
        '
        Me.Stock_SymbolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Stock Symbol", True))
        Me.Stock_SymbolTextBox.Location = New System.Drawing.Point(189, 85)
        Me.Stock_SymbolTextBox.Name = "Stock_SymbolTextBox"
        Me.Stock_SymbolTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stock_SymbolTextBox.TabIndex = 31
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(971, 453)
        Me.Controls.Add(Me.Stock_SymbolTextBox)
        Me.Controls.Add(Me.Date_PurchasedTextBox)
        Me.Controls.Add(Me.Price_per_shareTextBox)
        Me.Controls.Add(Me.Number_of_sharesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRating)
        Me.Controls.Add(Me.Earning_Potential_RatingComboBox)
        Me.Controls.Add(Number_of_sharesLabel1)
        Me.Controls.Add(Price_per_shareLabel1)
        Me.Controls.Add(Date_PurchasedLabel1)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Stock_NameLabel)
        Me.Controls.Add(Me.Stock_NameComboBox)
        Me.Controls.Add(Stock_SymbolLabel1)
        Me.Controls.Add(Earning_Potential_RatingLabel)
        Me.Controls.Add(Me.StocksBindingNavigator)
        Me.Name = "frmMain"
        Me.Text = "Kid Friendly Stocks"
        CType(Me.KidfriendlystocksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StocksBindingNavigator.ResumeLayout(False)
        Me.StocksBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KidfriendlystocksDataSet As kidFriendlyStocks.kidfriendlystocksDataSet
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As kidFriendlyStocks.kidfriendlystocksDataSetTableAdapters.StocksTableAdapter
    Friend WithEvents TableAdapterManager As kidFriendlyStocks.kidfriendlystocksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StocksBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StocksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Stock_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnValue As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents Earning_Potential_RatingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lstRating As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Number_of_sharesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Price_per_shareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_PurchasedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_SymbolTextBox As System.Windows.Forms.TextBox

End Class

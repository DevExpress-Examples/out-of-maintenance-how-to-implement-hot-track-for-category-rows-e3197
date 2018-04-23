Imports Microsoft.VisualBasic
Imports System
Namespace VerticalGridGroupHotTrack
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.verticalGrid = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New VerticalGridGroupHotTrack.nwindDataSet()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowProductID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowProductName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowSupplierID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCategoryID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowUnitPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowUnitsOnOrder = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.productsTableAdapter = New VerticalGridGroupHotTrack.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.verticalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' verticalGrid
			' 
			Me.verticalGrid.DataSource = Me.productsBindingSource
			Me.verticalGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.verticalGrid.Location = New System.Drawing.Point(0, 0)
			Me.verticalGrid.Name = "verticalGrid"
			Me.verticalGrid.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
			Me.verticalGrid.Size = New System.Drawing.Size(1264, 268)
			Me.verticalGrid.TabIndex = 0
'			Me.verticalGrid.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnVGridControlMouseMove);
'			Me.verticalGrid.CustomDrawRowHeaderCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(Me.OnCustomDrawRowHeaderCell);
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowProductID, Me.rowProductName})
			Me.categoryRow1.Name = "categoryRow1"
			Me.categoryRow1.Properties.Caption = "Product Info"
			' 
			' rowProductID
			' 
			Me.rowProductID.Name = "rowProductID"
			Me.rowProductID.Properties.Caption = "Product ID"
			Me.rowProductID.Properties.FieldName = "ProductID"
			' 
			' rowProductName
			' 
			Me.rowProductName.Name = "rowProductName"
			Me.rowProductName.Properties.Caption = "Product Name"
			Me.rowProductName.Properties.FieldName = "ProductName"
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowSupplierID, Me.rowCategoryID})
			Me.categoryRow2.Name = "categoryRow2"
			Me.categoryRow2.Properties.Caption = "Relations Info"
			' 
			' rowSupplierID
			' 
			Me.rowSupplierID.Name = "rowSupplierID"
			Me.rowSupplierID.Properties.Caption = "Supplier ID"
			Me.rowSupplierID.Properties.FieldName = "SupplierID"
			' 
			' rowCategoryID
			' 
			Me.rowCategoryID.Name = "rowCategoryID"
			Me.rowCategoryID.Properties.Caption = "Category ID"
			Me.rowCategoryID.Properties.FieldName = "CategoryID"
			' 
			' categoryRow3
			' 
			Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowUnitPrice, Me.rowUnitsOnOrder})
			Me.categoryRow3.Name = "categoryRow3"
			Me.categoryRow3.Properties.Caption = "Detail Info"
			' 
			' rowUnitPrice
			' 
			Me.rowUnitPrice.Name = "rowUnitPrice"
			Me.rowUnitPrice.Properties.Caption = "Unit Price"
			Me.rowUnitPrice.Properties.FieldName = "UnitPrice"
			' 
			' rowUnitsOnOrder
			' 
			Me.rowUnitsOnOrder.Name = "rowUnitsOnOrder"
			Me.rowUnitsOnOrder.Properties.Caption = "Units On Order"
			Me.rowUnitsOnOrder.Properties.FieldName = "UnitsOnOrder"
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1264, 268)
			Me.Controls.Add(Me.verticalGrid)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.verticalGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents verticalGrid As DevExpress.XtraVerticalGrid.VGridControl
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As VerticalGridGroupHotTrack.nwindDataSetTableAdapters.ProductsTableAdapter
		Private rowProductID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowProductName As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowSupplierID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategoryID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowUnitPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowUnitsOnOrder As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
	End Class
End Namespace


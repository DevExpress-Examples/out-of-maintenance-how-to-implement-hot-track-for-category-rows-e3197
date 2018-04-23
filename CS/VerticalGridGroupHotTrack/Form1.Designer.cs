namespace VerticalGridGroupHotTrack {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.verticalGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new VerticalGridGroupHotTrack.nwindDataSet();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowProductID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowProductName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowSupplierID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCategoryID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowUnitPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUnitsOnOrder = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.productsTableAdapter = new VerticalGridGroupHotTrack.nwindDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.verticalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalGrid
            // 
            this.verticalGrid.DataSource = this.productsBindingSource;
            this.verticalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalGrid.Location = new System.Drawing.Point(0, 0);
            this.verticalGrid.Name = "verticalGrid";
            this.verticalGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow1,
            this.categoryRow2,
            this.categoryRow3});
            this.verticalGrid.Size = new System.Drawing.Size(1264, 268);
            this.verticalGrid.TabIndex = 0;
            this.verticalGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnVGridControlMouseMove);
            this.verticalGrid.CustomDrawRowHeaderCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(this.OnCustomDrawRowHeaderCell);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowProductID,
            this.rowProductName});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Product Info";
            // 
            // rowProductID
            // 
            this.rowProductID.Name = "rowProductID";
            this.rowProductID.Properties.Caption = "Product ID";
            this.rowProductID.Properties.FieldName = "ProductID";
            // 
            // rowProductName
            // 
            this.rowProductName.Name = "rowProductName";
            this.rowProductName.Properties.Caption = "Product Name";
            this.rowProductName.Properties.FieldName = "ProductName";
            // 
            // categoryRow2
            // 
            this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSupplierID,
            this.rowCategoryID});
            this.categoryRow2.Name = "categoryRow2";
            this.categoryRow2.Properties.Caption = "Relations Info";
            // 
            // rowSupplierID
            // 
            this.rowSupplierID.Name = "rowSupplierID";
            this.rowSupplierID.Properties.Caption = "Supplier ID";
            this.rowSupplierID.Properties.FieldName = "SupplierID";
            // 
            // rowCategoryID
            // 
            this.rowCategoryID.Name = "rowCategoryID";
            this.rowCategoryID.Properties.Caption = "Category ID";
            this.rowCategoryID.Properties.FieldName = "CategoryID";
            // 
            // categoryRow3
            // 
            this.categoryRow3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowUnitPrice,
            this.rowUnitsOnOrder});
            this.categoryRow3.Name = "categoryRow3";
            this.categoryRow3.Properties.Caption = "Detail Info";
            // 
            // rowUnitPrice
            // 
            this.rowUnitPrice.Name = "rowUnitPrice";
            this.rowUnitPrice.Properties.Caption = "Unit Price";
            this.rowUnitPrice.Properties.FieldName = "UnitPrice";
            // 
            // rowUnitsOnOrder
            // 
            this.rowUnitsOnOrder.Name = "rowUnitsOnOrder";
            this.rowUnitsOnOrder.Properties.Caption = "Units On Order";
            this.rowUnitsOnOrder.Properties.FieldName = "UnitsOnOrder";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 268);
            this.Controls.Add(this.verticalGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verticalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl verticalGrid;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private VerticalGridGroupHotTrack.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowProductID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowProductName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSupplierID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategoryID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUnitPrice;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUnitsOnOrder;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow3;
    }
}


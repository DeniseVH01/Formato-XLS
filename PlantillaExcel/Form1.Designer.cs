namespace PlantillaExcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTNexcel = new System.Windows.Forms.Button();
            this.DGVtabla = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new PlantillaExcel.NorthwindDataSet();
            this.ordersTableAdapter = new PlantillaExcel.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNexcel
            // 
            this.BTNexcel.BackColor = System.Drawing.Color.SlateGray;
            this.BTNexcel.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNexcel.Location = new System.Drawing.Point(22, 288);
            this.BTNexcel.Name = "BTNexcel";
            this.BTNexcel.Size = new System.Drawing.Size(76, 41);
            this.BTNexcel.TabIndex = 0;
            this.BTNexcel.Text = "EXCEL";
            this.BTNexcel.UseVisualStyleBackColor = false;
            this.BTNexcel.Click += new System.EventHandler(this.BTNexcel_Click);
            // 
            // DGVtabla
            // 
            this.DGVtabla.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DGVtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtabla.Location = new System.Drawing.Point(22, 34);
            this.DGVtabla.Name = "DGVtabla";
            this.DGVtabla.Size = new System.Drawing.Size(477, 243);
            this.DGVtabla.TabIndex = 1;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(139, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(246, 28);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "PLANTILLA EXCEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(525, 341);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DGVtabla);
            this.Controls.Add(this.BTNexcel);
            this.Name = "Form1";
            this.Text = "PLANTILLA EXCEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNexcel;
        private System.Windows.Forms.DataGridView DGVtabla;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        internal System.Windows.Forms.Label Label1;
    }
}


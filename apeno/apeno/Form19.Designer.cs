namespace apeno
{
    partial class Form19
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApeNoDataSet = new apeno.ApeNoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTableAdapter = new apeno.ApeNoDataSetTableAdapters.reportTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApeNoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.ApeNoDataSet;
            // 
            // ApeNoDataSet
            // 
            this.ApeNoDataSet.DataSetName = "ApeNoDataSet";
            this.ApeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "apeno.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 24);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(614, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(548, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Relatorio Report";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApeNoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private ApeNoDataSet ApeNoDataSet;
        private ApeNoDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
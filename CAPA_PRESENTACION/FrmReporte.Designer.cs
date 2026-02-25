namespace CAPA_PRESENTACION
{
    partial class FrmReporte
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

            if (disposing && (reportViewer1m != null))
            {
                reportViewer1m.Dispose();
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEscolarDataSet = new CAPA_PRESENTACION.GestionEscolarDataSet();
            this.reportViewer1m = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gestionEscolarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new CAPA_PRESENTACION.GestionEscolarDataSetTableAdapters.MateriaTableAdapter();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAESTRODAT = new CAPA_PRESENTACION.MAESTRODAT();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAESTRODAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "Materia";
            this.materiaBindingSource1.DataSource = this.gestionEscolarDataSet;
            // 
            // gestionEscolarDataSet
            // 
            this.gestionEscolarDataSet.DataSetName = "GestionEscolarDataSet";
            this.gestionEscolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1m
            // 
            this.reportViewer1m.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.profesorBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.materiaBindingSource;
            this.reportViewer1m.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1m.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1m.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.maestro.rdlc";
            this.reportViewer1m.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1m.Name = "reportViewer1m";
            this.reportViewer1m.ServerReport.BearerToken = null;
            this.reportViewer1m.Size = new System.Drawing.Size(942, 754);
            this.reportViewer1m.TabIndex = 0;
            // 
            // gestionEscolarDataSetBindingSource
            // 
            this.gestionEscolarDataSetBindingSource.DataSource = this.gestionEscolarDataSet;
            this.gestionEscolarDataSetBindingSource.Position = 0;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.mAESTRODAT;
            // 
            // mAESTRODAT
            // 
            this.mAESTRODAT.DataSetName = "MAESTRODAT";
            this.mAESTRODAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.mAESTRODAT;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 754);
            this.Controls.Add(this.reportViewer1m);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAESTRODAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1m;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private MAESTRODAT mAESTRODAT;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private GestionEscolarDataSet gestionEscolarDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private GestionEscolarDataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource gestionEscolarDataSetBindingSource;
    }
}
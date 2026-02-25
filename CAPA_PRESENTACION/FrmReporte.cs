using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FrmReporte : Form
    {
        private int estudianteId;

        public FrmReporte(int id) 
        { 
            InitializeComponent(); estudianteId = id;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionEscolarDataSet.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.gestionEscolarDataSet.Materia);



            EstudianteMateriaBLL bll = new EstudianteMateriaBLL();

            DataTable dt1 = bll.ObtenerReporteAsignaciones(estudianteId);
            DataTable dt2 = bll.ObtenerOtraConsulta(estudianteId);

            reportViewer1m.LocalReport.DataSources.Clear();
            reportViewer1m.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt1));
            reportViewer1m.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));
            reportViewer1m.RefreshReport();
                }


    }

}
 





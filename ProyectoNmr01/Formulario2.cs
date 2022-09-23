using System;
using System.Windows.Forms;

namespace ProyectoNmr01
{
    public partial class Formulario2 : Form
    {
        private readonly string Base = "JYoplac";

        public Formulario2()
        {
            InitializeComponent();
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("SELECT A.NomAlu, A.ApeAlu, M.FecMatri, C.NomCur, C.Costo " +
                                                       "FROM Matricula M JOIN Curso C ON M.IdCur = C.IdCur " +
                                                       "JOIN Alumno A ON M.IdAlu = A.IdAlu", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("USP_BUSCAR_RANGOFECHAS_MATRICULA '" + DtpDesde.Value + "', '" + DtpHasta.Value + "'", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);

            DtpDesde.MaxDate = DtpHasta.Value;
            DtpHasta.MinDate = DtpDesde.Value;
        }
    }
}

using System;
using System.Windows.Forms;

namespace ProyectoNmr01
{
    public partial class Formulario1 : Form
    {
        private readonly string Base = "JYoplac";

        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("SELECT * FROM Curso", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }

        private void TxtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                TxtEntrada.Clear();
                DgvTabla.DataSource = ConexionSQL.FillData("SELECT * FROM Curso", Base);
            }
        }

        private void TxtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtEntrada_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtEntrada.Text != "")
            {
                DgvTabla.DataSource = ConexionSQL.FillData("Execute USP_BUSCAR_NOMBRE_CURSO '" + TxtEntrada.Text + "'", Base);
            }
            else
            {
                DgvTabla.DataSource = ConexionSQL.FillData("SELECT * FROM Curso", Base);
            }

            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }
    }
}

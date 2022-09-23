using System;
using System.Windows.Forms;

namespace ProyectoNmr01
{
    public partial class Formulario3 : Form
    {
        private readonly string Base = "Northwind";

        public Formulario3()
        {
            InitializeComponent();
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {
            CbxPais.DisplayMember = "Country";
            CbxPais.DataSource = ConexionSQL.FillData("SELECT DISTINCT Country FROM Customers", Base);

            DgvTabla.DataSource = ConexionSQL.FillData("SELECT CustomerID, CompanyName, ContactName, Address, City, Country FROM Customers", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }

        private void CbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("USP_BUSCAR_NOMBREPAIS_CUSTOMERS " + CbxPais.Text, Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }
    }
}

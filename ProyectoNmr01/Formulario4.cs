using System;
using System.Windows.Forms;

namespace ProyectoNmr01
{
    public partial class Formulario4 : Form
    {
        private readonly string Base = "Northwind";

        public Formulario4()
        {
            InitializeComponent();
        }

        private void Formulario4_Load(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("SELECT O.OrderID, C.CompanyName, C.ContactName, C.Country, [Employees Name] = (E.LastName + ' ' + E.FirstName), O.OrderDate, O.ShippedDate, O.Freight FROM Orders O JOIN Customers C ON O.CustomerID = C.CustomerID JOIN Employees E ON O.EmployeeID = E.EmployeeID", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DgvTabla.DataSource = ConexionSQL.FillData("USP_BUSCAR_RANGOFECHAS_ORDERS '" + DtpDesde.Value + "', '" + DtpHasta.Value + "'", Base);
            LblFilas.Text = "Filas: " + (DgvTabla.Rows.Count - 1);

            DtpDesde.MaxDate = DtpHasta.Value;
            DtpHasta.MinDate = DtpDesde.Value;
        }
    }
}

using System;
using System.Windows.Forms;

namespace ProyectoNmr01
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CbxFormulario.SelectedIndex = 0;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            switch (CbxFormulario.SelectedIndex)
            {
                case 0:
                    AbrirForm(new Formulario1());
                    break;

                case 1:
                    AbrirForm(new Formulario2());
                    break;

                case 2:
                    AbrirForm(new Formulario3());
                    break;

                case 3:
                    AbrirForm(new Formulario4());
                    break;

                default:
                    MessageBox.Show("Hi. Atte: Joa xD");
                    break;
            }
        }

        private void LblSeleccion_DoubleClick(object sender, EventArgs e)
        {
            CbxFormulario.Items.Add("Saludo");
        }

        private void AbrirForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}

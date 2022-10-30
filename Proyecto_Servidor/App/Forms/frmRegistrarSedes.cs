using System;
using System.Windows.Forms;

using static Business.Controllers.SedesController;
using static Business.Utils.Funciones;
using Entities.Models;

namespace App.Forms
{
    public partial class frmRegistrarSedes : Form
    {
        public frmRegistrarSedes()
        {
            InitializeComponent();
        }

        private void Limpiar() 
        {
            txtIdSede.Text = string.Empty;
            txtNombreSede.Text = string.Empty;
            txtDireccionSede.Text = string.Empty;
            txtTelSede.Text = string.Empty;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarSede_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDireccionSede.Text) || string.IsNullOrEmpty(txtIdSede.Text) || string.IsNullOrEmpty(txtNombreSede.Text) || string.IsNullOrEmpty(txtTelSede.Text))// Validación de espacio vacío de campo Descripción
            {
                MessageBox.Show("No pueden quedar espacios vacíos.");
                return;
            }

            if (!esNumero(txtIdSede.Text)) 
            {
                MessageBox.Show("Debe digitar un número en el espacio de Id de Sede.");
                return;
            }

            if (BuscarSede(int.Parse(txtIdSede.Text)))
            {
                MessageBox.Show("El Id de Sede ya existe.");
                return;
            }
                        
            if (LlenoSede() == false)
            {
                AgregarSedeController(int.Parse(txtIdSede.Text), txtNombreSede.Text, txtDireccionSede.Text, true, txtTelSede.Text);
                MessageBox.Show("Sede agregada.");
            }
            else 
            {
                MessageBox.Show("No hay más espacio.");
            }

            Limpiar();
        }
    }
}

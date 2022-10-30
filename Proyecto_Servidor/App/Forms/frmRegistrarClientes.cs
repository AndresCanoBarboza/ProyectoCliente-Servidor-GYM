using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Business.Controllers.ClienteController;
using static Business.Utils.Funciones;
using Entities.Models;

namespace App.Forms
{
    public partial class frmRegistrarClientes : Form
    {
        public frmRegistrarClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIdCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            cmbGenero.SelectedIndex = '\0';

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtIdCliente.Text) || string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtApellido1.Text) || string.IsNullOrEmpty(txtApellido2.Text))// Validación de espacio vacío de campo Descripción
            {
                MessageBox.Show("No pueden quedar espacios vacíos.");
                return;
            }

            if (cmbGenero.SelectedItem == null) // Validación de selección de comboBox género
            {
                MessageBox.Show("Debe seleccionar una opción en género.");
                return;
            }
            
            if (dtpFechaNacimiento.Value.Date > DateTime.Today || dtpFechaIngreso.Value.Date > DateTime.Today) // Validación para que no se pueda escoger fecha futura
            {
                MessageBox.Show("No puede seleccionar una fecha futura.");
                return;
            }

            if (BuscarCliente(txtIdCliente.Text))
            {
                MessageBox.Show("El Id de Cliente ya existe.");
                return;
            }

            
            if (LlenoCliente() == false)
            {
                AgregarClienteController(txtIdCliente.Text, txtNombreCliente.Text, txtApellido1.Text, txtApellido2.Text, dtpFechaNacimiento.Value, cmbGenero.SelectedIndex == 0 ? 'F' : cmbGenero.SelectedIndex == 1 ? 'M' : cmbGenero.SelectedIndex == 2 ? 'O' : '\0', dtpFechaIngreso.Value);//AgregarCliente(nuevo);
                MessageBox.Show("Cliente agregado.");
            }
            else
            {
                MessageBox.Show("No hay más espacio.");
            }

            Limpiar();
            }

        
    }
    
}

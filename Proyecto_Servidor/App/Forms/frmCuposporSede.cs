using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Business.Utils.Funciones;
using Entities.Models;
using static Business.Controllers.CuposController;


namespace App.Forms
{
    public partial class frmCuposporSede : Form
    {
        public frmCuposporSede()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CuposporSede_Load(object sender, EventArgs e)
        {
            MostrarCmbCuposSedes(cmbSedes);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!esNumero(txtcantCupos.Text))
            {
                MessageBox.Show("Debe digitar un número en el espacio de Contidad de Cupos.");
                return;
            }

            if (cmbSedes.SelectedItem == null) // Validación de selección de comboBox Sede
            {
                MessageBox.Show("Debe seleccionar una Sede.");
                return;
            }

            /*CupoporSede cupo = new CupoporSede()
            {
                sede = (Sede)cmbSedes.SelectedItem,
                cupos = int.Parse(txtcantCupos.Text),
                fechaCupos = dtpfechaCupo.Value
            };*/

            if (LlenoCupos() == false) 
            {
                AgregarCuposController((Sede)cmbSedes.SelectedItem, dtpfechaCupo.Value, int.Parse(txtcantCupos.Text));
                MessageBox.Show("Cupo agregado.");
            }
            else
            {
                MessageBox.Show("No hay más espacio.");
            }
            txtcantCupos.Text = string.Empty;
        }
    }
}

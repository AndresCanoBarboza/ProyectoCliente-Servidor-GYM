using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities.Models;
using static Business.Controllers.ClienteController;
using static Business.Controllers.SedesController;
using static Business.Controllers.AfiliacionController;

namespace App.Forms
{
    public partial class frmRegistrarSedesdeClientes : Form
    {
        private List<AfiliacionSede> afiaux = new List<AfiliacionSede>();
        
        public frmRegistrarSedesdeClientes()
        {
            InitializeComponent();
        }

        private void frmRegistrarSedesdeClientes_Load(object sender, EventArgs e)
        {
            MostrarCmbClientes(cmbClientes);
            MostrarCmbSedes(cmbSedes);
            dgvAfiliacion.DataSource = afiaux;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            afiaux.Add((AfiliacionSede)cmbClientes.SelectedItem); //ERROR
            dgvAfiliacion.DataSource = null;
            dgvAfiliacion.DataSource = afiaux;
        }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (LlenoAfi() == false) 
            {
                AgregarAfiController(int.Parse(txtAfi.Text), dtpAfi.Value, (Cliente)cmbClientes.SelectedItem, (Sede)cmbSedes.SelectedItem);
                MessageBox.Show("Cliente agregado a Sede.");
            }
            else
            {
                MessageBox.Show("No se pudo agregar información.");
            }

        }
    }
}

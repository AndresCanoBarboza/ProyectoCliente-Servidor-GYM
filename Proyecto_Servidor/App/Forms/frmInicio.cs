using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegisSedes_Click(object sender, EventArgs e)
        {
            frmRegistrarSedes ventana = new frmRegistrarSedes();
            ventana.ShowDialog();
        }

        private void btnRegisClientes_Click(object sender, EventArgs e)
        {
            frmRegistrarClientes ventana = new frmRegistrarClientes();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsulSedes_Click(object sender, EventArgs e)
        {
            fmrConsultarSedes ventana = new fmrConsultarSedes();
            ventana.ShowDialog();
        }

        private void btnConsulClientes_Click(object sender, EventArgs e)
        {
            frmConsultarClientes ventana = new frmConsultarClientes();
            ventana.ShowDialog();
        }

        private void btnConsulSedesCliente_Click(object sender, EventArgs e)
        {
            frmComsultarSedesCliente ventana = new frmComsultarSedesCliente();
            ventana.ShowDialog();
        }

        private void btnRegisSedesCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarSedesdeClientes ventana = new frmRegistrarSedesdeClientes();
            ventana.ShowDialog();
        }

        private void btnCupos_Click(object sender, EventArgs e)
        {
            frmCuposporSede ventana = new frmCuposporSede();
            ventana.ShowDialog();
        }

        private void btnConsultarCupos_Click(object sender, EventArgs e)
        {
            frmConsultarCuposporSede ventana = new frmConsultarCuposporSede();
            ventana.ShowDialog();
        }
    }
}

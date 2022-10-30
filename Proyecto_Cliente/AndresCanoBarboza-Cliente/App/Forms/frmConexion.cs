using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App.TCP_Cliente;
using Entities.Models;

namespace App.Forms
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void btnConecctar_Click(object sender, EventArgs e)
        {
            Cliente conexion = new Cliente()
            {
                clienteId = txtCedula.Text
            };

            Conectar(conexion);

            if (error != "")
            {
                MessageBox.Show(error);
            }
            else 
            {
                frmMenú ventana = new frmMenú();
                ventana.ShowDialog();
            }
        }
    }
}

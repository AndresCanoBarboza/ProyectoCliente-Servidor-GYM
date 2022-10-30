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

namespace App.Forms
{
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarClientes_Load_1(object sender, EventArgs e)
        {
            
            dgvClientes.DataSource = MostrarCliente();
        }
    }
}

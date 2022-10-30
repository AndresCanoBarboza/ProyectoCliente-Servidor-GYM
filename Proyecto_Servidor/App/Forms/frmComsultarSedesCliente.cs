using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Business.Controllers.AfiliacionController;
namespace App.Forms
{
    public partial class frmComsultarSedesCliente : Form
    {
        public frmComsultarSedesCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComsultarSedesCliente_Load(object sender, EventArgs e)
        {
            dgvSedesporCliente.DataSource = MostrarAfiliacion();            
        }
    }
}

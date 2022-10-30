using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Business.Controllers.SedesController;

namespace App.Forms
{
    public partial class fmrConsultarSedes : Form
    {
        public fmrConsultarSedes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrConsultarSedes_Load(object sender, EventArgs e)
        {
            dgvSedes.DataSource = MostrarSede();
        }
    }
}

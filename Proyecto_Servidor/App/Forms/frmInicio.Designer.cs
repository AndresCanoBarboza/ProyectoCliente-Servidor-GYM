
namespace App.Forms
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisSedes = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnConsulSedesCliente = new System.Windows.Forms.Button();
            this.btnConsulSedes = new System.Windows.Forms.Button();
            this.btnConsulClientes = new System.Windows.Forms.Button();
            this.btnRegisSedesCliente = new System.Windows.Forms.Button();
            this.btnRegisClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCupos = new System.Windows.Forms.Button();
            this.btnConsultarCupos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisSedes
            // 
            this.btnRegisSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisSedes.Location = new System.Drawing.Point(160, 87);
            this.btnRegisSedes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisSedes.Name = "btnRegisSedes";
            this.btnRegisSedes.Size = new System.Drawing.Size(369, 57);
            this.btnRegisSedes.TabIndex = 0;
            this.btnRegisSedes.Text = "Registrar Sedes";
            this.btnRegisSedes.UseVisualStyleBackColor = true;
            this.btnRegisSedes.Click += new System.EventHandler(this.btnRegisSedes_Click);
            // 
            // btnConsulSedesCliente
            // 
            this.btnConsulSedesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulSedesCliente.Location = new System.Drawing.Point(160, 357);
            this.btnConsulSedesCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulSedesCliente.Name = "btnConsulSedesCliente";
            this.btnConsulSedesCliente.Size = new System.Drawing.Size(369, 68);
            this.btnConsulSedesCliente.TabIndex = 1;
            this.btnConsulSedesCliente.Text = "Consultar Sedes de Cliente";
            this.btnConsulSedesCliente.UseVisualStyleBackColor = true;
            this.btnConsulSedesCliente.Click += new System.EventHandler(this.btnConsulSedesCliente_Click);
            // 
            // btnConsulSedes
            // 
            this.btnConsulSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulSedes.Location = new System.Drawing.Point(160, 432);
            this.btnConsulSedes.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulSedes.Name = "btnConsulSedes";
            this.btnConsulSedes.Size = new System.Drawing.Size(369, 57);
            this.btnConsulSedes.TabIndex = 2;
            this.btnConsulSedes.Text = "Consultar Sedes";
            this.btnConsulSedes.UseVisualStyleBackColor = true;
            this.btnConsulSedes.Click += new System.EventHandler(this.btnConsulSedes_Click);
            // 
            // btnConsulClientes
            // 
            this.btnConsulClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulClientes.Location = new System.Drawing.Point(160, 496);
            this.btnConsulClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulClientes.Name = "btnConsulClientes";
            this.btnConsulClientes.Size = new System.Drawing.Size(369, 57);
            this.btnConsulClientes.TabIndex = 3;
            this.btnConsulClientes.Text = "Consultar Clientes";
            this.btnConsulClientes.UseVisualStyleBackColor = true;
            this.btnConsulClientes.Click += new System.EventHandler(this.btnConsulClientes_Click);
            // 
            // btnRegisSedesCliente
            // 
            this.btnRegisSedesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisSedesCliente.Location = new System.Drawing.Point(160, 215);
            this.btnRegisSedesCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisSedesCliente.Name = "btnRegisSedesCliente";
            this.btnRegisSedesCliente.Size = new System.Drawing.Size(369, 68);
            this.btnRegisSedesCliente.TabIndex = 4;
            this.btnRegisSedesCliente.Text = "Registrar Sedes de Cliente";
            this.btnRegisSedesCliente.UseVisualStyleBackColor = true;
            this.btnRegisSedesCliente.Click += new System.EventHandler(this.btnRegisSedesCliente_Click);
            // 
            // btnRegisClientes
            // 
            this.btnRegisClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisClientes.Location = new System.Drawing.Point(160, 151);
            this.btnRegisClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisClientes.Name = "btnRegisClientes";
            this.btnRegisClientes.Size = new System.Drawing.Size(369, 57);
            this.btnRegisClientes.TabIndex = 5;
            this.btnRegisClientes.Text = "Registrar Clientes";
            this.btnRegisClientes.UseVisualStyleBackColor = true;
            this.btnRegisClientes.Click += new System.EventHandler(this.btnRegisClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido, Escoja una opción";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(160, 626);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(369, 57);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCupos
            // 
            this.btnCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCupos.Location = new System.Drawing.Point(160, 291);
            this.btnCupos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCupos.Name = "btnCupos";
            this.btnCupos.Size = new System.Drawing.Size(369, 57);
            this.btnCupos.TabIndex = 8;
            this.btnCupos.Text = "Registrar Cupos por Sede";
            this.btnCupos.UseVisualStyleBackColor = true;
            this.btnCupos.Click += new System.EventHandler(this.btnCupos_Click);
            // 
            // btnConsultarCupos
            // 
            this.btnConsultarCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCupos.Location = new System.Drawing.Point(160, 561);
            this.btnConsultarCupos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarCupos.Name = "btnConsultarCupos";
            this.btnConsultarCupos.Size = new System.Drawing.Size(369, 57);
            this.btnConsultarCupos.TabIndex = 9;
            this.btnConsultarCupos.Text = "Consultar Cupos por Sede";
            this.btnConsultarCupos.UseVisualStyleBackColor = true;
            this.btnConsultarCupos.Click += new System.EventHandler(this.btnConsultarCupos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 760);
            this.Controls.Add(this.btnConsultarCupos);
            this.Controls.Add(this.btnCupos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisClientes);
            this.Controls.Add(this.btnRegisSedesCliente);
            this.Controls.Add(this.btnConsulClientes);
            this.Controls.Add(this.btnConsulSedes);
            this.Controls.Add(this.btnConsulSedesCliente);
            this.Controls.Add(this.btnRegisSedes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisSedes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnConsulSedesCliente;
        private System.Windows.Forms.Button btnConsulSedes;
        private System.Windows.Forms.Button btnConsulClientes;
        private System.Windows.Forms.Button btnRegisSedesCliente;
        private System.Windows.Forms.Button btnRegisClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCupos;
        private System.Windows.Forms.Button btnConsultarCupos;
    }
}
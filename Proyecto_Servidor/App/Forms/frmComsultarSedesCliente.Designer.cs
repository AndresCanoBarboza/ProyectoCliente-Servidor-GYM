
namespace App.Forms
{
    partial class frmComsultarSedesCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSedesporCliente = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesporCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Consulta de Sedes por Cliente";
            // 
            // dgvSedesporCliente
            // 
            this.dgvSedesporCliente.AllowUserToAddRows = false;
            this.dgvSedesporCliente.AllowUserToDeleteRows = false;
            this.dgvSedesporCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedesporCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedesporCliente.Location = new System.Drawing.Point(5, 52);
            this.dgvSedesporCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSedesporCliente.Name = "dgvSedesporCliente";
            this.dgvSedesporCliente.ReadOnly = true;
            this.dgvSedesporCliente.RowHeadersVisible = false;
            this.dgvSedesporCliente.RowHeadersWidth = 51;
            this.dgvSedesporCliente.RowTemplate.Height = 24;
            this.dgvSedesporCliente.Size = new System.Drawing.Size(1027, 288);
            this.dgvSedesporCliente.TabIndex = 19;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(808, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(224, 46);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmComsultarSedesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 416);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvSedesporCliente);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmComsultarSedesCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComsultarSedesCliente";
            this.Load += new System.EventHandler(this.frmComsultarSedesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesporCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSedesporCliente;
        private System.Windows.Forms.Button btnVolver;
    }
}
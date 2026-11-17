using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2.Views
{
    partial class FormLavadero
    {
        /// <summary>
        ///  Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lstPendientes = new System.Windows.Forms.ListBox();
            this.lblEventos = new System.Windows.Forms.Label();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendientes.Location = new System.Drawing.Point(12, 9);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(162, 21);
            this.lblPendientes.TabIndex = 0;
            this.lblPendientes.Text = "Pedidos en proceso:";
            // 
            // lstPendientes
            // 
            this.lstPendientes.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPendientes.FormattingEnabled = true;
            this.lstPendientes.ItemHeight = 15;
            this.lstPendientes.Location = new System.Drawing.Point(12, 40);
            this.lstPendientes.Name = "lstPendientes";
            this.lstPendientes.Size = new System.Drawing.Size(476, 289);
            this.lstPendientes.TabIndex = 1;
            this.lstPendientes.SelectedIndexChanged += new System.EventHandler(this.lstPendientes_SelectedIndexChanged);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(12, 340);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(86, 15);
            this.lblEventos.TabIndex = 2;
            this.lblEventos.Text = "Últimos avisos:";
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 15;
            this.lstEventos.Location = new System.Drawing.Point(12, 360);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(476, 109);
            this.lstEventos.TabIndex = 3;
            // 
            // FormLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 482);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lstPendientes);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.lstEventos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLavadero";
            this.Text = "Pantalla de lavado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPendientes;
        private ListBox lstPendientes;
        private Label lblEventos;
        private ListBox lstEventos;
    }
}

﻿namespace MaxiKiosko.Formularios
{
    partial class frmCompraConsulta
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridCompras = new System.Windows.Forms.DataGridView();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Text = "Compras realizadas";
            // 
            // dataGridVentas
            // 
            this.dataGridCompras.AllowUserToAddRows = false;
            this.dataGridCompras.AllowUserToDeleteRows = false;
            this.dataGridCompras.AllowUserToResizeRows = false;
            this.dataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompras.Location = new System.Drawing.Point(15, 50);
            this.dataGridCompras.Name = "dataGridCompras";
            this.dataGridCompras.ReadOnly = true;
            this.dataGridCompras.RowHeadersVisible = false;
            this.dataGridCompras.Size = new System.Drawing.Size(770, 465);
            // 
            // frmVentaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dataGridCompras);
            this.Name = "frmCompraConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras realizadas";
            this.ResumeLayout(false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataGridCompras;
    }
}

﻿namespace ListaMercado.Lista
{
    partial class FormListagemListas
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
            this.dgvListas = new System.Windows.Forms.DataGridView();
            this.VerLista = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoverLista = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCompararPreco = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListas
            // 
            this.dgvListas.AllowUserToAddRows = false;
            this.dgvListas.AllowUserToDeleteRows = false;
            this.dgvListas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerLista,
            this.RemoverLista,
            this.btnCompararPreco});
            this.dgvListas.Location = new System.Drawing.Point(5, 63);
            this.dgvListas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListas.Name = "dgvListas";
            this.dgvListas.ReadOnly = true;
            this.dgvListas.RowTemplate.Height = 28;
            this.dgvListas.Size = new System.Drawing.Size(449, 334);
            this.dgvListas.TabIndex = 0;
            this.dgvListas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListas_CellContentClick);
            // 
            // VerLista
            // 
            this.VerLista.HeaderText = "Ver Lista";
            this.VerLista.Name = "VerLista";
            this.VerLista.ReadOnly = true;
            // 
            // RemoverLista
            // 
            this.RemoverLista.HeaderText = "Remover Lista";
            this.RemoverLista.Name = "RemoverLista";
            this.RemoverLista.ReadOnly = true;
            // 
            // btnCompararPreco
            // 
            this.btnCompararPreco.HeaderText = "Comparar Preço";
            this.btnCompararPreco.Name = "btnCompararPreco";
            this.btnCompararPreco.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Suas listas de compras";
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDivider.Location = new System.Drawing.Point(-366, 36);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1106, 2);
            this.lblDivider.TabIndex = 21;
            // 
            // FormListagemListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 408);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvListas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListagemListas";
            this.Text = "FormListagemListas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewButtonColumn VerLista;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.DataGridViewButtonColumn RemoverLista;
        private System.Windows.Forms.DataGridViewButtonColumn btnCompararPreco;
    }
}
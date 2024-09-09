﻿namespace WindowsFormsApp1
{
    partial class Registro_de_Autores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.btnNuevoAutor = new WindowsFormsApp1.PillButton();
            this.btnBuscarAutor = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtFiltroAutor = new System.Windows.Forms.TextBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblFiltroNombreApellido = new System.Windows.Forms.Label();
            this.lblAutoresRegistrados = new System.Windows.Forms.Label();
            this.txtFiltroNacionalidad = new System.Windows.Forms.TextBox();
            this.lblFiltroNacionalidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtFiltroNacionalidad);
            this.panel1.Controls.Add(this.lblFiltroNacionalidad);
            this.panel1.Controls.Add(this.dgvAutores);
            this.panel1.Controls.Add(this.btnNuevoAutor);
            this.panel1.Controls.Add(this.btnBuscarAutor);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.txtFiltroAutor);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroNombreApellido);
            this.panel1.Location = new System.Drawing.Point(48, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 3;
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(35, 262);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.RowTemplate.Height = 24;
            this.dgvAutores.Size = new System.Drawing.Size(968, 415);
            this.dgvAutores.TabIndex = 7;
            // 
            // btnNuevoAutor
            // 
            this.btnNuevoAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoAutor.FlatAppearance.BorderSize = 0;
            this.btnNuevoAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoAutor.Location = new System.Drawing.Point(167, 196);
            this.btnNuevoAutor.Name = "btnNuevoAutor";
            this.btnNuevoAutor.Size = new System.Drawing.Size(165, 38);
            this.btnNuevoAutor.TabIndex = 6;
            this.btnNuevoAutor.Text = "+ Nuevo Autor";
            this.btnNuevoAutor.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAutor.Location = new System.Drawing.Point(44, 196);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarAutor.TabIndex = 5;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(35, 139);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(338, 33);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // txtFiltroAutor
            // 
            this.txtFiltroAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAutor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroAutor.Location = new System.Drawing.Point(35, 51);
            this.txtFiltroAutor.Multiline = true;
            this.txtFiltroAutor.Name = "txtFiltroAutor";
            this.txtFiltroAutor.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroAutor.TabIndex = 4;
            this.txtFiltroAutor.Text = "Ingrese el nombre o apellido del autor";
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(40, 112);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(76, 24);
            this.lblFiltroPeriodo.TabIndex = 3;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroNombreApellido
            // 
            this.lblFiltroNombreApellido.AutoSize = true;
            this.lblFiltroNombreApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreApellido.Location = new System.Drawing.Point(40, 24);
            this.lblFiltroNombreApellido.Name = "lblFiltroNombreApellido";
            this.lblFiltroNombreApellido.Size = new System.Drawing.Size(163, 24);
            this.lblFiltroNombreApellido.TabIndex = 2;
            this.lblFiltroNombreApellido.Text = "Nombre / Apellido";
            this.lblFiltroNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAutoresRegistrados
            // 
            this.lblAutoresRegistrados.AutoSize = true;
            this.lblAutoresRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAutoresRegistrados.Location = new System.Drawing.Point(103, 63);
            this.lblAutoresRegistrados.Name = "lblAutoresRegistrados";
            this.lblAutoresRegistrados.Size = new System.Drawing.Size(261, 31);
            this.lblAutoresRegistrados.TabIndex = 2;
            this.lblAutoresRegistrados.Text = "Autores Registrados";
            this.lblAutoresRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFiltroNacionalidad
            // 
            this.txtFiltroNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNacionalidad.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroNacionalidad.Location = new System.Drawing.Point(557, 51);
            this.txtFiltroNacionalidad.Multiline = true;
            this.txtFiltroNacionalidad.Name = "txtFiltroNacionalidad";
            this.txtFiltroNacionalidad.Size = new System.Drawing.Size(446, 41);
            this.txtFiltroNacionalidad.TabIndex = 9;
            this.txtFiltroNacionalidad.Text = "Ingrese la nacionalidad del autor";
            // 
            // lblFiltroNacionalidad
            // 
            this.lblFiltroNacionalidad.AutoSize = true;
            this.lblFiltroNacionalidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNacionalidad.Location = new System.Drawing.Point(562, 24);
            this.lblFiltroNacionalidad.Name = "lblFiltroNacionalidad";
            this.lblFiltroNacionalidad.Size = new System.Drawing.Size(120, 24);
            this.lblFiltroNacionalidad.TabIndex = 8;
            this.lblFiltroNacionalidad.Text = "Nacionalidad";
            this.lblFiltroNacionalidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAutoresRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Autores";
            this.Text = "Registro_de_Autores";
            this.Load += new System.EventHandler(this.Registro_de_Autores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAutores;
        private PillButton btnNuevoAutor;
        private PillButton btnBuscarAutor;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.TextBox txtFiltroAutor;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroNombreApellido;
        private System.Windows.Forms.Label lblAutoresRegistrados;
        private System.Windows.Forms.TextBox txtFiltroNacionalidad;
        private System.Windows.Forms.Label lblFiltroNacionalidad;
    }
}
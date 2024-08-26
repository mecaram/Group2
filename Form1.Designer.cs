namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideView = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDespLibros = new WindowsFormsApp1.PillButton();
            this.btnDespEnciclopedias = new WindowsFormsApp1.PillButton();
            this.btnDespJuegos = new WindowsFormsApp1.PillButton();
            this.btnDespMapas = new WindowsFormsApp1.PillButton();
            this.pillButton1 = new WindowsFormsApp1.PillButton();
            this.panelSideView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideView
            // 
            this.panelSideView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelSideView.Controls.Add(this.pillButton1);
            this.panelSideView.Controls.Add(this.btnDespMapas);
            this.panelSideView.Controls.Add(this.btnDespJuegos);
            this.panelSideView.Controls.Add(this.btnDespEnciclopedias);
            this.panelSideView.Controls.Add(this.btnDespLibros);
            this.panelSideView.Controls.Add(this.flowLayoutPanel1);
            this.panelSideView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideView.Location = new System.Drawing.Point(0, 0);
            this.panelSideView.Name = "panelSideView";
            this.panelSideView.Size = new System.Drawing.Size(275, 690);
            this.panelSideView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDespLibros
            // 
            this.btnDespLibros.FlatAppearance.BorderSize = 0;
            this.btnDespLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDespLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDespLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespLibros.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDespLibros.Location = new System.Drawing.Point(12, 106);
            this.btnDespLibros.Name = "btnDespLibros";
            this.btnDespLibros.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDespLibros.Size = new System.Drawing.Size(250, 47);
            this.btnDespLibros.TabIndex = 1;
            this.btnDespLibros.Text = "LIBROS";
            this.btnDespLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespLibros.UseVisualStyleBackColor = true;
            // 
            // btnDespEnciclopedias
            // 
            this.btnDespEnciclopedias.FlatAppearance.BorderSize = 0;
            this.btnDespEnciclopedias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDespEnciclopedias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDespEnciclopedias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespEnciclopedias.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespEnciclopedias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDespEnciclopedias.Location = new System.Drawing.Point(12, 247);
            this.btnDespEnciclopedias.Name = "btnDespEnciclopedias";
            this.btnDespEnciclopedias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDespEnciclopedias.Size = new System.Drawing.Size(250, 47);
            this.btnDespEnciclopedias.TabIndex = 2;
            this.btnDespEnciclopedias.Text = "ENCICLOPEDIAS";
            this.btnDespEnciclopedias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespEnciclopedias.UseVisualStyleBackColor = true;
            // 
            // btnDespJuegos
            // 
            this.btnDespJuegos.FlatAppearance.BorderSize = 0;
            this.btnDespJuegos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDespJuegos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDespJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespJuegos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespJuegos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDespJuegos.Location = new System.Drawing.Point(12, 294);
            this.btnDespJuegos.Name = "btnDespJuegos";
            this.btnDespJuegos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDespJuegos.Size = new System.Drawing.Size(250, 47);
            this.btnDespJuegos.TabIndex = 3;
            this.btnDespJuegos.Text = "JUEGOS";
            this.btnDespJuegos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespJuegos.UseVisualStyleBackColor = true;
            // 
            // btnDespMapas
            // 
            this.btnDespMapas.FlatAppearance.BorderSize = 0;
            this.btnDespMapas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDespMapas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDespMapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespMapas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespMapas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDespMapas.Location = new System.Drawing.Point(12, 200);
            this.btnDespMapas.Name = "btnDespMapas";
            this.btnDespMapas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDespMapas.Size = new System.Drawing.Size(250, 47);
            this.btnDespMapas.TabIndex = 4;
            this.btnDespMapas.Text = "MAPAS";
            this.btnDespMapas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespMapas.UseVisualStyleBackColor = true;
            // 
            // pillButton1
            // 
            this.pillButton1.FlatAppearance.BorderSize = 0;
            this.pillButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pillButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pillButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pillButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pillButton1.Location = new System.Drawing.Point(12, 153);
            this.pillButton1.Name = "pillButton1";
            this.pillButton1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.pillButton1.Size = new System.Drawing.Size(250, 47);
            this.pillButton1.TabIndex = 5;
            this.pillButton1.Text = "REVISTAS";
            this.pillButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pillButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 690);
            this.Controls.Add(this.panelSideView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PillButton btnDespLibros;
        private PillButton btnDespEnciclopedias;
        private PillButton pillButton1;
        private PillButton btnDespMapas;
        private PillButton btnDespJuegos;
    }
}


namespace Refuerzo2024.View.Docentes
{
    partial class ViewDocentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nuevoIngreso = new System.Windows.Forms.Button();
            this.btneliminarDocente = new System.Windows.Forms.Button();
            this.btnActualizarDocente = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cmbEspecialidaddd = new System.Windows.Forms.ComboBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.nuevoIngreso);
            this.panel2.Controls.Add(this.btneliminarDocente);
            this.panel2.Controls.Add(this.btnActualizarDocente);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.cmbEspecialidaddd);
            this.panel2.Controls.Add(this.txtDui);
            this.panel2.Controls.Add(this.txtapellidos);
            this.panel2.Controls.Add(this.txtnombres);
            this.panel2.Controls.Add(this.txtIDP);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 556);
            this.panel2.TabIndex = 1;
            // 
            // nuevoIngreso
            // 
            this.nuevoIngreso.Location = new System.Drawing.Point(176, 465);
            this.nuevoIngreso.Name = "nuevoIngreso";
            this.nuevoIngreso.Size = new System.Drawing.Size(144, 41);
            this.nuevoIngreso.TabIndex = 10;
            this.nuevoIngreso.Text = "Nuevo registro";
            this.nuevoIngreso.UseVisualStyleBackColor = true;
            // 
            // btneliminarDocente
            // 
            this.btneliminarDocente.Location = new System.Drawing.Point(20, 465);
            this.btneliminarDocente.Name = "btneliminarDocente";
            this.btneliminarDocente.Size = new System.Drawing.Size(144, 41);
            this.btneliminarDocente.TabIndex = 9;
            this.btneliminarDocente.Text = "Eliminar";
            this.btneliminarDocente.UseVisualStyleBackColor = true;
            this.btneliminarDocente.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizarDocente
            // 
            this.btnActualizarDocente.Location = new System.Drawing.Point(176, 418);
            this.btnActualizarDocente.Name = "btnActualizarDocente";
            this.btnActualizarDocente.Size = new System.Drawing.Size(144, 41);
            this.btnActualizarDocente.TabIndex = 8;
            this.btnActualizarDocente.Text = "Actualizar registro";
            this.btnActualizarDocente.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(20, 418);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(144, 41);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidaddd
            // 
            this.cmbEspecialidaddd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidaddd.FormattingEnabled = true;
            this.cmbEspecialidaddd.Location = new System.Drawing.Point(20, 378);
            this.cmbEspecialidaddd.Name = "cmbEspecialidaddd";
            this.cmbEspecialidaddd.Size = new System.Drawing.Size(300, 21);
            this.cmbEspecialidaddd.TabIndex = 6;
            this.cmbEspecialidaddd.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidaddd_SelectedIndexChanged);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(20, 325);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(300, 20);
            this.txtDui.TabIndex = 4;
            this.txtDui.TextChanged += new System.EventHandler(this.txtDui_TextChanged);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(20, 262);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(300, 20);
            this.txtapellidos.TabIndex = 1;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(20, 181);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(300, 20);
            this.txtnombres.TabIndex = 0;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(20, 103);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(112, 20);
            this.txtIDP.TabIndex = 0;
            this.txtIDP.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Asignatura";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Docente";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes.Location = new System.Drawing.Point(336, 0);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(650, 556);
            this.dgvDocentes.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnBuscarDocente);
            this.panel3.Controls.Add(this.txtBuscarDocente);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(336, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 41);
            this.panel3.TabIndex = 5;
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDocente.Location = new System.Drawing.Point(503, 9);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(144, 23);
            this.btnBuscarDocente.TabIndex = 12;
            this.btnBuscarDocente.Text = "Buscar Docente";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDocente.Location = new System.Drawing.Point(110, 11);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(387, 20);
            this.txtBuscarDocente.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Buscar Docente";
            // 
            // ViewDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.panel2);
            this.Name = "ViewDocentes";
            this.Text = "ViewDocentes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button nuevoIngreso;
        public System.Windows.Forms.Button btneliminarDocente;
        public System.Windows.Forms.Button btnActualizarDocente;
        public System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.ComboBox cmbEspecialidaddd;
        public System.Windows.Forms.TextBox txtDui;
        public System.Windows.Forms.TextBox txtapellidos;
        public System.Windows.Forms.TextBox txtnombres;
        public System.Windows.Forms.TextBox txtIDP;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnBuscarDocente;
        public System.Windows.Forms.TextBox txtBuscarDocente;
        public System.Windows.Forms.Label label9;
    }
}
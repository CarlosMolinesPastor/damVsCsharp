namespace CENTRO_ESCOLAR
{
    partial class FCursos
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
            this.dGridCursos = new System.Windows.Forms.DataGridView();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPrimero = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bRefrescar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegActual = new System.Windows.Forms.TextBox();
            this.txtRegTotal = new System.Windows.Forms.TextBox();
            this.bsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGridCursos
            // 
            this.dGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridCursos.Location = new System.Drawing.Point(88, 381);
            this.dGridCursos.MultiSelect = false;
            this.dGridCursos.Name = "dGridCursos";
            this.dGridCursos.RowHeadersWidth = 51;
            this.dGridCursos.RowTemplate.Height = 24;
            this.dGridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridCursos.Size = new System.Drawing.Size(561, 286);
            this.dGridCursos.TabIndex = 10;
            this.dGridCursos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridCursos_RowEnter);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(235, 228);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(125, 41);
            this.bGuardar.TabIndex = 2;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(380, 228);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(125, 41);
            this.bActualizar.TabIndex = 3;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(524, 228);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(125, 41);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(88, 228);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(125, 41);
            this.bNuevo.TabIndex = 1;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(178, 14);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(95, 24);
            this.txtCod.TabIndex = 0;
            this.txtCod.Enter += new System.EventHandler(this.txtCod_Enter);
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(88, 683);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(97, 41);
            this.bPrimero.TabIndex = 11;
            this.bPrimero.Text = "Primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(191, 683);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(103, 41);
            this.bAnterior.TabIndex = 12;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(443, 683);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(97, 41);
            this.bSiguiente.TabIndex = 13;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(546, 683);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(103, 41);
            this.bUltimo.TabIndex = 14;
            this.bUltimo.Text = "Ultimo";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.ItemHeight = 18;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbBuscar.Location = new System.Drawing.Point(21, 23);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(97, 26);
            this.cmbBuscar.TabIndex = 6;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(357, 15);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(107, 41);
            this.bBuscar.TabIndex = 8;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(124, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(214, 24);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(248, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "CURSOS";
            // 
            // bRefrescar
            // 
            this.bRefrescar.Location = new System.Drawing.Point(479, 15);
            this.bRefrescar.Name = "bRefrescar";
            this.bRefrescar.Size = new System.Drawing.Size(103, 41);
            this.bRefrescar.TabIndex = 9;
            this.bRefrescar.Text = "Refrescar";
            this.bRefrescar.UseVisualStyleBackColor = true;
            this.bRefrescar.Click += new System.EventHandler(this.bRefrescar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.bRefrescar);
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(68, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 69);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCod);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(68, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 118);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(68, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 60);
            this.panel3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "/";
            // 
            // txtRegActual
            // 
            this.txtRegActual.Location = new System.Drawing.Point(300, 688);
            this.txtRegActual.Name = "txtRegActual";
            this.txtRegActual.ReadOnly = true;
            this.txtRegActual.Size = new System.Drawing.Size(49, 24);
            this.txtRegActual.TabIndex = 20;
            this.txtRegActual.TabStop = false;
            this.txtRegActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRegTotal
            // 
            this.txtRegTotal.Location = new System.Drawing.Point(388, 688);
            this.txtRegTotal.Name = "txtRegTotal";
            this.txtRegTotal.ReadOnly = true;
            this.txtRegTotal.Size = new System.Drawing.Size(49, 24);
            this.txtRegTotal.TabIndex = 21;
            this.txtRegTotal.TabStop = false;
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.Red;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bsalir.Location = new System.Drawing.Point(443, 742);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(206, 36);
            this.bsalir.TabIndex = 15;
            this.bsalir.Text = "SALIR";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // FCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 803);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.txtRegTotal);
            this.Controls.Add(this.txtRegActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bUltimo);
            this.Controls.Add(this.bSiguiente);
            this.Controls.Add(this.bAnterior);
            this.Controls.Add(this.bPrimero);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dGridCursos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURSOS";
            this.Load += new System.EventHandler(this.FCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridCursos;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bRefrescar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegActual;
        private System.Windows.Forms.TextBox txtRegTotal;
        private System.Windows.Forms.Button bsalir;
    }
}
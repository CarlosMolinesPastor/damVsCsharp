﻿namespace CENTRO_ESCOLAR
{
    partial class FAlumnos
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
            this.bsalir = new System.Windows.Forms.Button();
            this.txtRegTotal = new System.Windows.Forms.TextBox();
            this.txtRegActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bNCurso = new System.Windows.Forms.Button();
            this.cmbCurs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBuscar2 = new System.Windows.Forms.ComboBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.bRefrescar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dGridAlumnos = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.Red;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bsalir.Location = new System.Drawing.Point(700, 836);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(206, 36);
            this.bsalir.TabIndex = 15;
            this.bsalir.Text = "SALIR";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // txtRegTotal
            // 
            this.txtRegTotal.Location = new System.Drawing.Point(496, 784);
            this.txtRegTotal.Name = "txtRegTotal";
            this.txtRegTotal.ReadOnly = true;
            this.txtRegTotal.Size = new System.Drawing.Size(49, 24);
            this.txtRegTotal.TabIndex = 52;
            this.txtRegTotal.TabStop = false;
            // 
            // txtRegActual
            // 
            this.txtRegActual.Location = new System.Drawing.Point(408, 784);
            this.txtRegActual.Name = "txtRegActual";
            this.txtRegActual.ReadOnly = true;
            this.txtRegActual.Size = new System.Drawing.Size(49, 24);
            this.txtRegActual.TabIndex = 51;
            this.txtRegActual.TabStop = false;
            this.txtRegActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "/";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(41, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 60);
            this.panel3.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(366, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "ALUMNOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.bNCurso);
            this.panel2.Controls.Add(this.cmbCurs);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCod);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(41, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 192);
            this.panel2.TabIndex = 0;
            // 
            // bNCurso
            // 
            this.bNCurso.Location = new System.Drawing.Point(792, 19);
            this.bNCurso.Name = "bNCurso";
            this.bNCurso.Size = new System.Drawing.Size(60, 26);
            this.bNCurso.TabIndex = 4;
            this.bNCurso.Text = "Nuevo";
            this.bNCurso.UseVisualStyleBackColor = true;
            this.bNCurso.Click += new System.EventHandler(this.bNCurso_Click);
            // 
            // cmbCurs
            // 
            this.cmbCurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurs.FormattingEnabled = true;
            this.cmbCurs.Location = new System.Drawing.Point(547, 19);
            this.cmbCurs.Name = "cmbCurs";
            this.cmbCurs.Size = new System.Drawing.Size(234, 26);
            this.cmbCurs.TabIndex = 3;
            this.cmbCurs.TabStop = false;
            this.cmbCurs.Enter += new System.EventHandler(this.cmbCurs_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = " Curso";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(123, 119);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(268, 24);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(123, 15);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(95, 24);
            this.txtCod.TabIndex = 0;
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cmbBuscar2);
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.bRefrescar);
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(33, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 69);
            this.panel1.TabIndex = 9;
            // 
            // cmbBuscar2
            // 
            this.cmbBuscar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar2.FormattingEnabled = true;
            this.cmbBuscar2.Items.AddRange(new object[] {
            "DniProfesor",
            "Nombre",
            "Telefono",
            "Email",
            "CursoTutor"});
            this.cmbBuscar2.Location = new System.Drawing.Point(188, 23);
            this.cmbBuscar2.Name = "cmbBuscar2";
            this.cmbBuscar2.Size = new System.Drawing.Size(171, 26);
            this.cmbBuscar2.TabIndex = 1;
            this.cmbBuscar2.Enter += new System.EventHandler(this.cmbBuscar2_Enter);
            this.cmbBuscar2.Leave += new System.EventHandler(this.cmbBuscar2_Leave);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "DniAlumno",
            "Nombre",
            "Telefono",
            "Curso"});
            this.cmbBuscar.Location = new System.Drawing.Point(20, 23);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(162, 26);
            this.cmbBuscar.TabIndex = 0;
            this.cmbBuscar.SelectedValueChanged += new System.EventHandler(this.cmbBuscar_SelectedValueChanged);
            // 
            // bRefrescar
            // 
            this.bRefrescar.Location = new System.Drawing.Point(763, 15);
            this.bRefrescar.Name = "bRefrescar";
            this.bRefrescar.Size = new System.Drawing.Size(103, 41);
            this.bRefrescar.TabIndex = 4;
            this.bRefrescar.Text = "Refrescar";
            this.bRefrescar.UseVisualStyleBackColor = true;
            this.bRefrescar.Click += new System.EventHandler(this.bRefrescar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(641, 15);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(107, 41);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(365, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(251, 24);
            this.txtBuscar.TabIndex = 2;
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(803, 779);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(103, 41);
            this.bUltimo.TabIndex = 14;
            this.bUltimo.Text = "Ultimo";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(700, 779);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(97, 41);
            this.bSiguiente.TabIndex = 13;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(156, 779);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(103, 41);
            this.bAnterior.TabIndex = 12;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(53, 779);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(97, 41);
            this.bPrimero.TabIndex = 11;
            this.bPrimero.Text = "Primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(203, 325);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(125, 41);
            this.bNuevo.TabIndex = 5;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(639, 325);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(125, 41);
            this.bBorrar.TabIndex = 8;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(495, 325);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(125, 41);
            this.bActualizar.TabIndex = 7;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(350, 325);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(125, 41);
            this.bGuardar.TabIndex = 6;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dGridAlumnos
            // 
            this.dGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAlumnos.Location = new System.Drawing.Point(33, 477);
            this.dGridAlumnos.MultiSelect = false;
            this.dGridAlumnos.Name = "dGridAlumnos";
            this.dGridAlumnos.RowHeadersWidth = 51;
            this.dGridAlumnos.RowTemplate.Height = 24;
            this.dGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridAlumnos.Size = new System.Drawing.Size(893, 286);
            this.dGridAlumnos.TabIndex = 10;
            this.dGridAlumnos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAlumnos_RowEnter);
            // 
            // FAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 895);
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
            this.Controls.Add(this.dGridAlumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAlumnos";
            this.Load += new System.EventHandler(this.FAlumnos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.TextBox txtRegTotal;
        private System.Windows.Forms.TextBox txtRegActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bNCurso;
        private System.Windows.Forms.ComboBox cmbCurs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBuscar2;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button bRefrescar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DataGridView dGridAlumnos;
    }
}
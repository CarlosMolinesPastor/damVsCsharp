namespace CENTRO_ESCOLAR
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
            this.bCursos = new System.Windows.Forms.Button();
            this.bProfesores = new System.Windows.Forms.Button();
            this.bAlumnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(64, 55);
            this.bCursos.Margin = new System.Windows.Forms.Padding(5);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(67, 24);
            this.bCursos.TabIndex = 0;
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bProfesores
            // 
            this.bProfesores.Location = new System.Drawing.Point(64, 131);
            this.bProfesores.Margin = new System.Windows.Forms.Padding(5);
            this.bProfesores.Name = "bProfesores";
            this.bProfesores.Size = new System.Drawing.Size(67, 24);
            this.bProfesores.TabIndex = 1;
            this.bProfesores.UseVisualStyleBackColor = true;
            this.bProfesores.Click += new System.EventHandler(this.bProfesores_Click);
            // 
            // bAlumnos
            // 
            this.bAlumnos.Location = new System.Drawing.Point(64, 207);
            this.bAlumnos.Margin = new System.Windows.Forms.Padding(5);
            this.bAlumnos.Name = "bAlumnos";
            this.bAlumnos.Size = new System.Drawing.Size(67, 24);
            this.bAlumnos.TabIndex = 2;
            this.bAlumnos.UseVisualStyleBackColor = true;
            this.bAlumnos.Click += new System.EventHandler(this.bAlumnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROFESORES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALUMNOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bProfesores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bCursos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bAlumnos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 294);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "GESTION ESCOLAR";
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bSalir.Location = new System.Drawing.Point(60, 432);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(354, 66);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(495, 543);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION ESCOLAR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bProfesores;
        private System.Windows.Forms.Button bAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSalir;
    }
}


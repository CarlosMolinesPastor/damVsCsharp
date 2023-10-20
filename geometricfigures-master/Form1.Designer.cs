namespace E2_T8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bHexagono = new System.Windows.Forms.Button();
            this.bRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.bIntroCuadrado = new System.Windows.Forms.Button();
            this.bIntroCirculo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bMostrarHexagonos = new System.Windows.Forms.Button();
            this.bMostrarRectangulo = new System.Windows.Forms.Button();
            this.bMostrarTriangulos = new System.Windows.Forms.Button();
            this.bMostrarTodos = new System.Windows.Forms.Button();
            this.bMostrarCuadrados = new System.Windows.Forms.Button();
            this.bMostrarCirculos = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.bHexagono);
            this.groupBox1.Controls.Add(this.bRectangulo);
            this.groupBox1.Controls.Add(this.btnTriangulo);
            this.groupBox1.Controls.Add(this.bIntroCuadrado);
            this.groupBox1.Controls.Add(this.bIntroCirculo);
            this.groupBox1.Location = new System.Drawing.Point(22, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INTRO DATOS";
            // 
            // bHexagono
            // 
            this.bHexagono.Location = new System.Drawing.Point(36, 238);
            this.bHexagono.Name = "bHexagono";
            this.bHexagono.Size = new System.Drawing.Size(220, 43);
            this.bHexagono.TabIndex = 9;
            this.bHexagono.Text = "HEXAGONO";
            this.bHexagono.UseVisualStyleBackColor = true;
            this.bHexagono.Click += new System.EventHandler(this.bHexagono_Click);
            // 
            // bRectangulo
            // 
            this.bRectangulo.Location = new System.Drawing.Point(36, 189);
            this.bRectangulo.Name = "bRectangulo";
            this.bRectangulo.Size = new System.Drawing.Size(220, 43);
            this.bRectangulo.TabIndex = 7;
            this.bRectangulo.Text = "RECTANGULO";
            this.bRectangulo.UseVisualStyleBackColor = true;
            this.bRectangulo.Click += new System.EventHandler(this.bRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(36, 140);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(220, 43);
            this.btnTriangulo.TabIndex = 5;
            this.btnTriangulo.Text = "TRIANGULO";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // bIntroCuadrado
            // 
            this.bIntroCuadrado.Location = new System.Drawing.Point(36, 91);
            this.bIntroCuadrado.Name = "bIntroCuadrado";
            this.bIntroCuadrado.Size = new System.Drawing.Size(220, 43);
            this.bIntroCuadrado.TabIndex = 4;
            this.bIntroCuadrado.Text = "CUADRADO";
            this.bIntroCuadrado.UseVisualStyleBackColor = true;
            this.bIntroCuadrado.Click += new System.EventHandler(this.bIntroCuadrado_Click);
            // 
            // bIntroCirculo
            // 
            this.bIntroCirculo.Location = new System.Drawing.Point(36, 42);
            this.bIntroCirculo.Name = "bIntroCirculo";
            this.bIntroCirculo.Size = new System.Drawing.Size(220, 43);
            this.bIntroCirculo.TabIndex = 3;
            this.bIntroCirculo.Text = "CIRCULO";
            this.bIntroCirculo.UseVisualStyleBackColor = true;
            this.bIntroCirculo.Click += new System.EventHandler(this.bIntroCirculo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.bMostrarHexagonos);
            this.groupBox2.Controls.Add(this.bMostrarRectangulo);
            this.groupBox2.Controls.Add(this.bMostrarTriangulos);
            this.groupBox2.Controls.Add(this.bMostrarTodos);
            this.groupBox2.Controls.Add(this.bMostrarCuadrados);
            this.groupBox2.Controls.Add(this.bMostrarCirculos);
            this.groupBox2.Location = new System.Drawing.Point(340, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 361);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOSTRAR DATOS";
            // 
            // bMostrarHexagonos
            // 
            this.bMostrarHexagonos.Location = new System.Drawing.Point(21, 287);
            this.bMostrarHexagonos.Name = "bMostrarHexagonos";
            this.bMostrarHexagonos.Size = new System.Drawing.Size(260, 43);
            this.bMostrarHexagonos.TabIndex = 12;
            this.bMostrarHexagonos.Text = "MOSTRAR HEXAGONOS";
            this.bMostrarHexagonos.UseVisualStyleBackColor = true;
            this.bMostrarHexagonos.Click += new System.EventHandler(this.bMostrarHexagonos_Click);
            // 
            // bMostrarRectangulo
            // 
            this.bMostrarRectangulo.Location = new System.Drawing.Point(21, 238);
            this.bMostrarRectangulo.Name = "bMostrarRectangulo";
            this.bMostrarRectangulo.Size = new System.Drawing.Size(260, 43);
            this.bMostrarRectangulo.TabIndex = 10;
            this.bMostrarRectangulo.Text = "MOSTRAR RECTANGULOS";
            this.bMostrarRectangulo.UseVisualStyleBackColor = true;
            this.bMostrarRectangulo.Click += new System.EventHandler(this.bMostrarRectangulo_Click);
            // 
            // bMostrarTriangulos
            // 
            this.bMostrarTriangulos.Location = new System.Drawing.Point(21, 189);
            this.bMostrarTriangulos.Name = "bMostrarTriangulos";
            this.bMostrarTriangulos.Size = new System.Drawing.Size(260, 43);
            this.bMostrarTriangulos.TabIndex = 8;
            this.bMostrarTriangulos.Text = "MOSTRAR TRIANGULOS";
            this.bMostrarTriangulos.UseVisualStyleBackColor = true;
            this.bMostrarTriangulos.Click += new System.EventHandler(this.bMostrarTriangulos_Click);
            // 
            // bMostrarTodos
            // 
            this.bMostrarTodos.Location = new System.Drawing.Point(21, 42);
            this.bMostrarTodos.Name = "bMostrarTodos";
            this.bMostrarTodos.Size = new System.Drawing.Size(260, 43);
            this.bMostrarTodos.TabIndex = 5;
            this.bMostrarTodos.Text = "MOSTRAR TODOS";
            this.bMostrarTodos.UseVisualStyleBackColor = true;
            this.bMostrarTodos.Click += new System.EventHandler(this.bMostrarTodos_Click);
            // 
            // bMostrarCuadrados
            // 
            this.bMostrarCuadrados.Location = new System.Drawing.Point(21, 140);
            this.bMostrarCuadrados.Name = "bMostrarCuadrados";
            this.bMostrarCuadrados.Size = new System.Drawing.Size(260, 43);
            this.bMostrarCuadrados.TabIndex = 4;
            this.bMostrarCuadrados.Text = "MOSTRAR CUADRADOS";
            this.bMostrarCuadrados.UseVisualStyleBackColor = true;
            this.bMostrarCuadrados.Click += new System.EventHandler(this.bMostrarCuadrados_Click);
            // 
            // bMostrarCirculos
            // 
            this.bMostrarCirculos.Location = new System.Drawing.Point(21, 91);
            this.bMostrarCirculos.Name = "bMostrarCirculos";
            this.bMostrarCirculos.Size = new System.Drawing.Size(260, 43);
            this.bMostrarCirculos.TabIndex = 3;
            this.bMostrarCirculos.Text = "MOSTRAR CIRCULOS";
            this.bMostrarCirculos.UseVisualStyleBackColor = true;
            this.bMostrarCirculos.Click += new System.EventHandler(this.bMostrarCirculos_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.bClose.BackgroundImage = global::E2_T8.Properties.Resources.exit_button_icon_18;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bClose.Location = new System.Drawing.Point(22, 408);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(615, 50);
            this.bClose.TabIndex = 10;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(661, 468);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIGURAS GEOMETRICAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bIntroCirculo;
        private System.Windows.Forms.Button bIntroCuadrado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarTodos;
        private System.Windows.Forms.Button bMostrarCuadrados;
        private System.Windows.Forms.Button bMostrarCirculos;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button bMostrarTriangulos;
        private System.Windows.Forms.Button bRectangulo;
        private System.Windows.Forms.Button bMostrarRectangulo;
        private System.Windows.Forms.Button bHexagono;
        private System.Windows.Forms.Button bMostrarHexagonos;
        private System.Windows.Forms.Button bClose;
    }
}


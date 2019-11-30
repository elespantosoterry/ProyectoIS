namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionUnidadesTematicas
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
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.unidadEliminado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminarUnidadBT = new System.Windows.Forms.Button();
            this.cursoEliminado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcionUnidad = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreNuevaUnidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cursoNuevaUnidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guardarNuevaUnidadBT = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.descripcionUnidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.back.Location = new System.Drawing.Point(679, 21);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(220, 47);
            this.back.TabIndex = 18;
            this.back.Text = "Retroceder";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gestión de Unidades Temáticas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.unidadEliminado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.eliminarUnidadBT);
            this.panel3.Controls.Add(this.cursoEliminado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(765, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 584);
            this.panel3.TabIndex = 21;
            // 
            // unidadEliminado
            // 
            this.unidadEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.unidadEliminado.FormattingEnabled = true;
            this.unidadEliminado.Location = new System.Drawing.Point(21, 170);
            this.unidadEliminado.Name = "unidadEliminado";
            this.unidadEliminado.Size = new System.Drawing.Size(329, 33);
            this.unidadEliminado.TabIndex = 21;
            this.unidadEliminado.SelectedIndexChanged += new System.EventHandler(this.unidadEliminado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Unidad a eliminar";
            // 
            // eliminarUnidadBT
            // 
            this.eliminarUnidadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.eliminarUnidadBT.Location = new System.Drawing.Point(84, 518);
            this.eliminarUnidadBT.Name = "eliminarUnidadBT";
            this.eliminarUnidadBT.Size = new System.Drawing.Size(220, 47);
            this.eliminarUnidadBT.TabIndex = 18;
            this.eliminarUnidadBT.Text = "Guardar";
            this.eliminarUnidadBT.UseVisualStyleBackColor = true;
            this.eliminarUnidadBT.Click += new System.EventHandler(this.eliminarUnidadBT_Click);
            // 
            // cursoEliminado
            // 
            this.cursoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cursoEliminado.FormattingEnabled = true;
            this.cursoEliminado.Location = new System.Drawing.Point(21, 105);
            this.cursoEliminado.Name = "cursoEliminado";
            this.cursoEliminado.Size = new System.Drawing.Size(329, 33);
            this.cursoEliminado.TabIndex = 19;
            this.cursoEliminado.SelectedIndexChanged += new System.EventHandler(this.cursoEliminado_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eliminar Unidad Temática";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descripcionUnidad
            // 
            this.descripcionUnidad.BackColor = System.Drawing.Color.White;
            this.descripcionUnidad.Controls.Add(this.textBox1);
            this.descripcionUnidad.Controls.Add(this.label1);
            this.descripcionUnidad.Controls.Add(this.nombreNuevaUnidad);
            this.descripcionUnidad.Controls.Add(this.label11);
            this.descripcionUnidad.Controls.Add(this.cursoNuevaUnidad);
            this.descripcionUnidad.Controls.Add(this.label4);
            this.descripcionUnidad.Controls.Add(this.label6);
            this.descripcionUnidad.Controls.Add(this.guardarNuevaUnidadBT);
            this.descripcionUnidad.Location = new System.Drawing.Point(171, 95);
            this.descripcionUnidad.Name = "descripcionUnidad";
            this.descripcionUnidad.Size = new System.Drawing.Size(376, 584);
            this.descripcionUnidad.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(19, 224);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 98);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripción";
            // 
            // nombreNuevaUnidad
            // 
            this.nombreNuevaUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nombreNuevaUnidad.Location = new System.Drawing.Point(19, 156);
            this.nombreNuevaUnidad.Name = "nombreNuevaUnidad";
            this.nombreNuevaUnidad.Size = new System.Drawing.Size(329, 30);
            this.nombreNuevaUnidad.TabIndex = 17;
            this.nombreNuevaUnidad.TextChanged += new System.EventHandler(this.nuevoGrupo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombre";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cursoNuevaUnidad
            // 
            this.cursoNuevaUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cursoNuevaUnidad.FormattingEnabled = true;
            this.cursoNuevaUnidad.Location = new System.Drawing.Point(19, 89);
            this.cursoNuevaUnidad.Name = "cursoNuevaUnidad";
            this.cursoNuevaUnidad.Size = new System.Drawing.Size(329, 33);
            this.cursoNuevaUnidad.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Crear Unidad Temática";
            // 
            // guardarNuevaUnidadBT
            // 
            this.guardarNuevaUnidadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guardarNuevaUnidadBT.Location = new System.Drawing.Point(69, 518);
            this.guardarNuevaUnidadBT.Name = "guardarNuevaUnidadBT";
            this.guardarNuevaUnidadBT.Size = new System.Drawing.Size(220, 47);
            this.guardarNuevaUnidadBT.TabIndex = 11;
            this.guardarNuevaUnidadBT.Text = "Guardar";
            this.guardarNuevaUnidadBT.UseVisualStyleBackColor = true;
            // 
            // gestionUnidadesTematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.descripcionUnidad);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Name = "gestionUnidadesTematicas";
            this.Text = "gestionUnidadesTematicas";
            this.Load += new System.EventHandler(this.gestionUnidadesTematicas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.descripcionUnidad.ResumeLayout(false);
            this.descripcionUnidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button eliminarUnidadBT;
        private System.Windows.Forms.ComboBox cursoEliminado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel descripcionUnidad;
        private System.Windows.Forms.ComboBox cursoNuevaUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button guardarNuevaUnidadBT;
        private System.Windows.Forms.TextBox nombreNuevaUnidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unidadEliminado;
        private System.Windows.Forms.Label label5;
    }
}
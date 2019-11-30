namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionPreguntas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preguntaPlanteamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DesarrolloCheck = new System.Windows.Forms.RadioButton();
            this.ConcretaCheck = new System.Windows.Forms.RadioButton();
            this.AlternativaCheck = new System.Windows.Forms.RadioButton();
            this.ChoiceCheck = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Reglones = new System.Windows.Forms.NumericUpDown();
            this.AlternativaIncorrecta = new System.Windows.Forms.TextBox();
            this.UploadCorrecta = new System.Windows.Forms.Button();
            this.ChoiceIncorrecta = new System.Windows.Forms.TextBox();
            this.GUARDARbancoPregunta = new System.Windows.Forms.Button();
            this.ViewBanco = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ChoiceCorrecta = new System.Windows.Forms.TextBox();
            this.AlternativaCorrecta = new System.Windows.Forms.TextBox();
            this.UploadIncorrecta = new System.Windows.Forms.Button();
            this.UploadChoiceCorrecta = new System.Windows.Forms.Button();
            this.UploadChoiceIncorrecta = new System.Windows.Forms.Button();
            this.ConcretaRespuesta = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CursosComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unidadesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reglones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de preguntas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coloque el planteamiento de la pregunta";
            // 
            // preguntaPlanteamiento
            // 
            this.preguntaPlanteamiento.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.preguntaPlanteamiento.Location = new System.Drawing.Point(23, 138);
            this.preguntaPlanteamiento.Margin = new System.Windows.Forms.Padding(4);
            this.preguntaPlanteamiento.Multiline = true;
            this.preguntaPlanteamiento.Name = "preguntaPlanteamiento";
            this.preguntaPlanteamiento.Size = new System.Drawing.Size(475, 78);
            this.preguntaPlanteamiento.TabIndex = 2;
            this.preguntaPlanteamiento.Text = "Cuerpo de la pregunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione el tipo de pregunta:";
            // 
            // DesarrolloCheck
            // 
            this.DesarrolloCheck.AutoSize = true;
            this.DesarrolloCheck.Location = new System.Drawing.Point(23, 296);
            this.DesarrolloCheck.Margin = new System.Windows.Forms.Padding(4);
            this.DesarrolloCheck.Name = "DesarrolloCheck";
            this.DesarrolloCheck.Size = new System.Drawing.Size(158, 21);
            this.DesarrolloCheck.TabIndex = 4;
            this.DesarrolloCheck.TabStop = true;
            this.DesarrolloCheck.Text = "Escrita de Desarrollo";
            this.DesarrolloCheck.UseVisualStyleBackColor = true;
            // 
            // ConcretaCheck
            // 
            this.ConcretaCheck.AutoSize = true;
            this.ConcretaCheck.Location = new System.Drawing.Point(23, 325);
            this.ConcretaCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ConcretaCheck.Name = "ConcretaCheck";
            this.ConcretaCheck.Size = new System.Drawing.Size(222, 21);
            this.ConcretaCheck.TabIndex = 5;
            this.ConcretaCheck.TabStop = true;
            this.ConcretaCheck.Text = "Escrita de Respuesta Concreta";
            this.ConcretaCheck.UseVisualStyleBackColor = true;
            // 
            // AlternativaCheck
            // 
            this.AlternativaCheck.AutoSize = true;
            this.AlternativaCheck.Location = new System.Drawing.Point(23, 354);
            this.AlternativaCheck.Margin = new System.Windows.Forms.Padding(4);
            this.AlternativaCheck.Name = "AlternativaCheck";
            this.AlternativaCheck.Size = new System.Drawing.Size(145, 21);
            this.AlternativaCheck.TabIndex = 6;
            this.AlternativaCheck.TabStop = true;
            this.AlternativaCheck.Text = "Alternativa Multiple";
            this.AlternativaCheck.UseVisualStyleBackColor = true;
            // 
            // ChoiceCheck
            // 
            this.ChoiceCheck.AutoSize = true;
            this.ChoiceCheck.Location = new System.Drawing.Point(15, 443);
            this.ChoiceCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ChoiceCheck.Name = "ChoiceCheck";
            this.ChoiceCheck.Size = new System.Drawing.Size(139, 21);
            this.ChoiceCheck.TabIndex = 7;
            this.ChoiceCheck.TabStop = true;
            this.ChoiceCheck.Text = "Verdadero / Falso";
            this.ChoiceCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de Reglones:";
            // 
            // Reglones
            // 
            this.Reglones.Location = new System.Drawing.Point(385, 296);
            this.Reglones.Name = "Reglones";
            this.Reglones.Size = new System.Drawing.Size(53, 23);
            this.Reglones.TabIndex = 10;
            // 
            // AlternativaIncorrecta
            // 
            this.AlternativaIncorrecta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AlternativaIncorrecta.Location = new System.Drawing.Point(33, 412);
            this.AlternativaIncorrecta.Margin = new System.Windows.Forms.Padding(4);
            this.AlternativaIncorrecta.Name = "AlternativaIncorrecta";
            this.AlternativaIncorrecta.Size = new System.Drawing.Size(233, 23);
            this.AlternativaIncorrecta.TabIndex = 11;
            this.AlternativaIncorrecta.Text = "Escriba aqui la alternativa";
            // 
            // UploadCorrecta
            // 
            this.UploadCorrecta.Location = new System.Drawing.Point(282, 381);
            this.UploadCorrecta.Name = "UploadCorrecta";
            this.UploadCorrecta.Size = new System.Drawing.Size(75, 23);
            this.UploadCorrecta.TabIndex = 12;
            this.UploadCorrecta.Text = "Subir";
            this.UploadCorrecta.UseVisualStyleBackColor = true;
            this.UploadCorrecta.Click += new System.EventHandler(this.UploadCorrecta_Click);
            // 
            // ChoiceIncorrecta
            // 
            this.ChoiceIncorrecta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ChoiceIncorrecta.Location = new System.Drawing.Point(33, 503);
            this.ChoiceIncorrecta.Margin = new System.Windows.Forms.Padding(4);
            this.ChoiceIncorrecta.Name = "ChoiceIncorrecta";
            this.ChoiceIncorrecta.Size = new System.Drawing.Size(233, 23);
            this.ChoiceIncorrecta.TabIndex = 13;
            this.ChoiceIncorrecta.Text = "Escriba aqui la alternativa";
            // 
            // GUARDARbancoPregunta
            // 
            this.GUARDARbancoPregunta.Location = new System.Drawing.Point(666, 237);
            this.GUARDARbancoPregunta.Name = "GUARDARbancoPregunta";
            this.GUARDARbancoPregunta.Size = new System.Drawing.Size(125, 96);
            this.GUARDARbancoPregunta.TabIndex = 19;
            this.GUARDARbancoPregunta.Text = "Guardar en Banco de Preguntas";
            this.GUARDARbancoPregunta.UseVisualStyleBackColor = true;
            this.GUARDARbancoPregunta.Click += new System.EventHandler(this.GUARDARbancoPregunta_Click);
            // 
            // ViewBanco
            // 
            this.ViewBanco.Location = new System.Drawing.Point(853, 237);
            this.ViewBanco.Name = "ViewBanco";
            this.ViewBanco.Size = new System.Drawing.Size(125, 96);
            this.ViewBanco.TabIndex = 20;
            this.ViewBanco.Text = "Ver Banco de Preguntas";
            this.ViewBanco.UseVisualStyleBackColor = true;
            this.ViewBanco.Click += new System.EventHandler(this.ViewBanco_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "Retroceder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChoiceCorrecta
            // 
            this.ChoiceCorrecta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ChoiceCorrecta.Location = new System.Drawing.Point(33, 472);
            this.ChoiceCorrecta.Margin = new System.Windows.Forms.Padding(4);
            this.ChoiceCorrecta.Name = "ChoiceCorrecta";
            this.ChoiceCorrecta.Size = new System.Drawing.Size(233, 23);
            this.ChoiceCorrecta.TabIndex = 22;
            this.ChoiceCorrecta.Text = "Escriba aqui la alternativa verdadera";
            // 
            // AlternativaCorrecta
            // 
            this.AlternativaCorrecta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AlternativaCorrecta.Location = new System.Drawing.Point(33, 381);
            this.AlternativaCorrecta.Margin = new System.Windows.Forms.Padding(4);
            this.AlternativaCorrecta.Name = "AlternativaCorrecta";
            this.AlternativaCorrecta.Size = new System.Drawing.Size(233, 23);
            this.AlternativaCorrecta.TabIndex = 23;
            this.AlternativaCorrecta.Text = "Escriba aqui la alternativa correcta";
            // 
            // UploadIncorrecta
            // 
            this.UploadIncorrecta.Location = new System.Drawing.Point(282, 412);
            this.UploadIncorrecta.Name = "UploadIncorrecta";
            this.UploadIncorrecta.Size = new System.Drawing.Size(75, 23);
            this.UploadIncorrecta.TabIndex = 24;
            this.UploadIncorrecta.Text = "Subir";
            this.UploadIncorrecta.UseVisualStyleBackColor = true;
            this.UploadIncorrecta.Click += new System.EventHandler(this.UploadIncorrecta_Click);
            // 
            // UploadChoiceCorrecta
            // 
            this.UploadChoiceCorrecta.Location = new System.Drawing.Point(303, 472);
            this.UploadChoiceCorrecta.Name = "UploadChoiceCorrecta";
            this.UploadChoiceCorrecta.Size = new System.Drawing.Size(75, 23);
            this.UploadChoiceCorrecta.TabIndex = 25;
            this.UploadChoiceCorrecta.Text = "Subir";
            this.UploadChoiceCorrecta.UseVisualStyleBackColor = true;
            this.UploadChoiceCorrecta.Click += new System.EventHandler(this.UploadChoiceCorrecta_Click);
            // 
            // UploadChoiceIncorrecta
            // 
            this.UploadChoiceIncorrecta.Location = new System.Drawing.Point(303, 503);
            this.UploadChoiceIncorrecta.Name = "UploadChoiceIncorrecta";
            this.UploadChoiceIncorrecta.Size = new System.Drawing.Size(75, 23);
            this.UploadChoiceIncorrecta.TabIndex = 26;
            this.UploadChoiceIncorrecta.Text = "Subir";
            this.UploadChoiceIncorrecta.UseVisualStyleBackColor = true;
            this.UploadChoiceIncorrecta.Click += new System.EventHandler(this.UploadChoiceIncorrecta_Click);
            // 
            // ConcretaRespuesta
            // 
            this.ConcretaRespuesta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ConcretaRespuesta.Location = new System.Drawing.Point(263, 326);
            this.ConcretaRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.ConcretaRespuesta.Name = "ConcretaRespuesta";
            this.ConcretaRespuesta.Size = new System.Drawing.Size(212, 23);
            this.ConcretaRespuesta.TabIndex = 27;
            this.ConcretaRespuesta.Text = "Escriba aqui la respuesta";
            // 
            // Time
            // 
            this.Time.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Time.Location = new System.Drawing.Point(120, 575);
            this.Time.Margin = new System.Windows.Forms.Padding(4);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(212, 23);
            this.Time.TabIndex = 28;
            this.Time.Text = "Escriba aqui el tiempo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 571);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tiempo:";
            // 
            // CursosComboBox
            // 
            this.CursosComboBox.FormattingEnabled = true;
            this.CursosComboBox.Location = new System.Drawing.Point(882, 96);
            this.CursosComboBox.Name = "CursosComboBox";
            this.CursosComboBox.Size = new System.Drawing.Size(121, 24);
            this.CursosComboBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Seleccione un curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Seleccione unidad tematica";
            // 
            // unidadesComboBox
            // 
            this.unidadesComboBox.FormattingEnabled = true;
            this.unidadesComboBox.Location = new System.Drawing.Point(882, 138);
            this.unidadesComboBox.Name = "unidadesComboBox";
            this.unidadesComboBox.Size = new System.Drawing.Size(121, 24);
            this.unidadesComboBox.TabIndex = 33;
            // 
            // gestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.unidadesComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CursosComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.ConcretaRespuesta);
            this.Controls.Add(this.UploadChoiceIncorrecta);
            this.Controls.Add(this.UploadChoiceCorrecta);
            this.Controls.Add(this.UploadIncorrecta);
            this.Controls.Add(this.AlternativaCorrecta);
            this.Controls.Add(this.ChoiceCorrecta);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ViewBanco);
            this.Controls.Add(this.GUARDARbancoPregunta);
            this.Controls.Add(this.ChoiceIncorrecta);
            this.Controls.Add(this.UploadCorrecta);
            this.Controls.Add(this.AlternativaIncorrecta);
            this.Controls.Add(this.Reglones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChoiceCheck);
            this.Controls.Add(this.AlternativaCheck);
            this.Controls.Add(this.ConcretaCheck);
            this.Controls.Add(this.DesarrolloCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preguntaPlanteamiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionPreguntas";
            this.Text = "gestionPreguntas";
            this.Load += new System.EventHandler(this.gestionPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reglones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preguntaPlanteamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton DesarrolloCheck;
        private System.Windows.Forms.RadioButton ConcretaCheck;
        private System.Windows.Forms.RadioButton AlternativaCheck;
        private System.Windows.Forms.RadioButton ChoiceCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Reglones;
        private System.Windows.Forms.TextBox AlternativaIncorrecta;
        private System.Windows.Forms.Button UploadCorrecta;
        private System.Windows.Forms.TextBox ChoiceIncorrecta;
        private System.Windows.Forms.Button GUARDARbancoPregunta;
        private System.Windows.Forms.Button ViewBanco;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ChoiceCorrecta;
        private System.Windows.Forms.TextBox AlternativaCorrecta;
        private System.Windows.Forms.Button UploadIncorrecta;
        private System.Windows.Forms.Button UploadChoiceCorrecta;
        private System.Windows.Forms.Button UploadChoiceIncorrecta;
        private System.Windows.Forms.TextBox ConcretaRespuesta;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unidadesComboBox;
    }
}
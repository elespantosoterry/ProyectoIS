namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class bancoPreguntas
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
            this.button15 = new System.Windows.Forms.Button();
            this.verBANCO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco de Preguntas";
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(654, 47);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(119, 48);
            this.button15.TabIndex = 6;
            this.button15.Text = "Retroceder";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // verBANCO
            // 
            this.verBANCO.Location = new System.Drawing.Point(66, 113);
            this.verBANCO.Multiline = true;
            this.verBANCO.Name = "verBANCO";
            this.verBANCO.ReadOnly = true;
            this.verBANCO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.verBANCO.Size = new System.Drawing.Size(1117, 413);
            this.verBANCO.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(524, 589);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Escriba el ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eliminar Pregunta:";
            // 
            // eliminarButton
            // 
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(706, 583);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(99, 39);
            this.eliminarButton.TabIndex = 10;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // bancoPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.verBANCO);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label1);
            this.Name = "bancoPreguntas";
            this.Text = "bancoPreguntas";
            this.Load += new System.EventHandler(this.bancoPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox verBANCO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eliminarButton;
    }
}
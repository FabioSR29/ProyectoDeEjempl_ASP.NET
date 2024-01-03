namespace GestorDeEstudiantes.UI
{
    partial class AgregarEstudiante
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtIdentificacion = new TextBox();
            btnGuardarEstudiante = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(138, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(138, 100);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(100, 23);
            txtIdentificacion.TabIndex = 2;
            // 
            // btnGuardarEstudiante
            // 
            btnGuardarEstudiante.Location = new Point(42, 168);
            btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            btnGuardarEstudiante.Size = new Size(75, 23);
            btnGuardarEstudiante.TabIndex = 3;
            btnGuardarEstudiante.Text = "Guardar";
            btnGuardarEstudiante.UseVisualStyleBackColor = true;
            btnGuardarEstudiante.Click += btnGuardarEstudiante_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(138, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 108);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "identificacion";
            // 
            // AgregarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 248);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarEstudiante);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "AgregarEstudiante";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtIdentificacion;
        private Button btnGuardarEstudiante;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
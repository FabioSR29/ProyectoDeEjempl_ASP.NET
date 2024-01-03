namespace GestorDeEstudiantes.UI
{
    partial class AgregarNotas
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
            btnAgregarUnaNota = new Button();
            txtNotas = new TextBox();
            btnSalir = new Button();
            label1 = new Label();
            txtResultados = new TextBox();
            SuspendLayout();
            // 
            // btnAgregarUnaNota
            // 
            btnAgregarUnaNota.Location = new Point(167, 36);
            btnAgregarUnaNota.Name = "btnAgregarUnaNota";
            btnAgregarUnaNota.Size = new Size(75, 23);
            btnAgregarUnaNota.TabIndex = 0;
            btnAgregarUnaNota.Text = "Agregar";
            btnAgregarUnaNota.UseVisualStyleBackColor = true;
            btnAgregarUnaNota.Click += btnAgregarUnaNota_Click;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(30, 36);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(100, 23);
            txtNotas.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(263, 208);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 76);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de Notas";
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(27, 113);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(201, 105);
            txtResultados.TabIndex = 4;
            // 
            // AgregarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 256);
            Controls.Add(txtResultados);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(txtNotas);
            Controls.Add(btnAgregarUnaNota);
            Name = "AgregarNotas";
            Text = "AgregarNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarUnaNota;
        private TextBox txtNotas;
        private Button btnSalir;
        private Label label1;
        private TextBox txtResultados;
    }
}
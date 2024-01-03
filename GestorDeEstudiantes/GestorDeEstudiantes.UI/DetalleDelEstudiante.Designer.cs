namespace GestorDeEstudiantes.UI
{
    partial class DetalleDelEstudiante
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOk = new Button();
            txtIdentificacion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 85);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 15;
            label3.Text = "identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 13;
            label1.Text = "nombre:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(93, 144);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 12;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnCancelar_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(126, 77);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(100, 23);
            txtIdentificacion.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(126, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // DetalleDelEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 222);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "DetalleDelEstudiante";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOk;
        private TextBox txtIdentificacion;
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}
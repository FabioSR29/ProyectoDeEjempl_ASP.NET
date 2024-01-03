namespace GestorDeEstudiantes.UI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnDetalle = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            DGV = new DataGridView();
            btnNotas = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(82, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.Location = new Point(182, 24);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(75, 23);
            btnDetalle.TabIndex = 1;
            btnDetalle.Text = "Detalles";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(318, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(450, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(82, 102);
            DGV.Name = "DGV";
            DGV.Size = new Size(443, 150);
            DGV.TabIndex = 4;
            // 
            // btnNotas
            // 
            btnNotas.Location = new Point(82, 63);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(75, 23);
            btnNotas.TabIndex = 5;
            btnNotas.Text = "Notas";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(601, 336);
            Controls.Add(btnNotas);
            Controls.Add(DGV);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnDetalle);
            Controls.Add(btnAgregar);
            Name = "Home";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnDetalle;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView DGV;
        private Button btnNotas;
    }
}

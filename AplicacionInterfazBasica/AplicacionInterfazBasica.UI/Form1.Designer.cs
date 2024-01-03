namespace AplicacionInterfazBasica.UI
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            elMonto = new TextBox();
            elDescuento = new TextBox();
            elSubtotal = new TextBox();
            elImpuesto = new TextBox();
            elTotal = new TextBox();
            elTipoDeCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el descuento:";
            // 
            // elMonto
            // 
            elMonto.Location = new Point(171, 21);
            elMonto.Name = "elMonto";
            elMonto.Size = new Size(100, 23);
            elMonto.TabIndex = 2;
            // 
            // elDescuento
            // 
            elDescuento.Location = new Point(171, 59);
            elDescuento.Name = "elDescuento";
            elDescuento.Size = new Size(100, 23);
            elDescuento.TabIndex = 3;
            // 
            // elSubtotal
            // 
            elSubtotal.Location = new Point(114, 168);
            elSubtotal.Name = "elSubtotal";
            elSubtotal.Size = new Size(100, 23);
            elSubtotal.TabIndex = 4;
            // 
            // elImpuesto
            // 
            elImpuesto.Location = new Point(114, 208);
            elImpuesto.Name = "elImpuesto";
            elImpuesto.Size = new Size(100, 23);
            elImpuesto.TabIndex = 5;
            // 
            // elTotal
            // 
            elTotal.Location = new Point(114, 249);
            elTotal.Name = "elTotal";
            elTotal.Size = new Size(100, 23);
            elTotal.TabIndex = 6;
            // 
            // elTipoDeCliente
            // 
            elTipoDeCliente.Location = new Point(114, 278);
            elTipoDeCliente.Name = "elTipoDeCliente";
            elTipoDeCliente.Size = new Size(100, 23);
            elTipoDeCliente.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 8;
            label3.Text = "El subtotal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Impuestos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 249);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 11;
            label6.Text = "Tipo de cliente:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(121, 96);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 404);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(elTipoDeCliente);
            Controls.Add(elTotal);
            Controls.Add(elImpuesto);
            Controls.Add(elSubtotal);
            Controls.Add(elDescuento);
            Controls.Add(elMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox elMonto;
        private TextBox elDescuento;
        private TextBox elSubtotal;
        private TextBox elImpuesto;
        private TextBox elTotal;
        private TextBox elTipoDeCliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcular;
    }
}

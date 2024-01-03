using System.Globalization;

namespace AplicacionInterfazBasica.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            double elMontoOriginal = Convert.ToDouble(elMonto.Text, CultureInfo.InvariantCulture);

            double elMontoDeDescuento = CalclarElMontoDeDescuento();
            double elSubTotal = elMontoOriginal - elMontoDeDescuento;
            double impuestos  = CalcularImpuestos(elSubTotal);
            double total= elSubTotal + impuestos;
            elSubtotal.Text = elSubTotal.ToString();
            elImpuesto.Text = impuestos.ToString();
            elTotal.Text = total.ToString();
            elTipoDeCliente.Text = ElTipoDeCliente(total);

        }

        private double CalclarElMontoDeDescuento() {
            double elPorcentajeDeDescuento = Convert.ToDouble(elDescuento.Text, CultureInfo.InvariantCulture);
            double elMontoOriginal = Convert.ToDouble(elMonto.Text, CultureInfo.InvariantCulture);


            double elMontoDeDescuento = elMontoOriginal * (elPorcentajeDeDescuento/100);

            return elMontoDeDescuento;
        }

        private double CalcularImpuestos(double subtotal) {

            double Impuestos = subtotal * 0.13;

            return Impuestos;

        }

        private string ElTipoDeCliente(double total) {
            string elTipoCliente ="fuera de rango";

            if (total < 1000) { elTipoCliente = "cliente d"; }
            if (total >= 1000 && total<2000) { elTipoCliente = "cliente c"; }
            if (total >= 2000 && total<3000) { elTipoCliente = "cliente b"; }
            if (total >= 3000) { elTipoCliente = "cliente a"; }

            return elTipoCliente;
        }

    }
}

namespace dcasagalloExamen.Views;

public partial class resumen : ContentPage
{
	public resumen()
	{
		InitializeComponent();
	}

    public resumen(string usuario, string nombre_registro, string apellido_registro, string edad_registro, string fecha_registro, string ciudad_registro, string pais_registro, decimal monto_inicial, decimal pago_mensual, decimal pago_total)
    {
        InitializeComponent();

        lblTitulo.Text = "Usuario Conectado: " + usuario;

        lblNombre.Text = "Nombre: " + nombre_registro;
        lblApellido.Text = "Apellido: " + apellido_registro;
        lblEdad.Text = "Edad: " + edad_registro;
        lblFecha.Text = "Fecha: " + fecha_registro;
        lblCiudad.Text = "Ciudad: " + ciudad_registro;
        lblPais.Text = "Pais: " + pais_registro;
        lblMontoInicial.Text = "Monto Inicial: " + monto_inicial;
        lblPagoMensual.Text = "Pago Mensual: " + pago_mensual;
        lblPagoTotal.Text = "Pago Total: " + pago_total;
    }
}
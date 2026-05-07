namespace dcasagalloExamen.Views;

public partial class registro : ContentPage
{
    // Usuario Loggueado
	string usuario;

    // Campos del registro
    string nombre_registro;
    string apellido_registro;
    string edad_registro;
    string fecha_registro;
    string ciudad_registro;
    string pais_registro;
    decimal costo_inicial = 1500;
    decimal pago_total;
    decimal cuota_final;

    public registro(string usuario_logueado)
	{
		InitializeComponent();

		usuario = usuario_logueado;

		lblSaludoUsuario.Text = "Usuario conectado: " + usuario;
	}

    private void btnCalcularPago_Clicked(object sender, EventArgs e)
    {

        // Validar campos numericos
        if (!decimal.TryParse(txtMontoInicial.Text, out decimal valor_inicial))
        {
            DisplayAlertAsync("Error", "Todos los valores deben ser numéricos.", "Cerrar");
            return;
        }

        // Campos del registro
        nombre_registro = txtNombre.Text;
        apellido_registro = txtApellido.Text;
        edad_registro = txtEdad.Text;
        fecha_registro = dpFecha.Date.ToString();
        ciudad_registro = pCiudades.Items[pCiudades.SelectedIndex];
        pais_registro = pPaises.Items[pPaises.SelectedIndex];


        decimal diferencia = costo_inicial - valor_inicial;
        decimal cuota = diferencia / 4m;
        cuota_final = cuota + (costo_inicial * 0.04m);
        lblValorAPagar.Text = cuota_final.ToString();

        pago_total = cuota_final * 4;

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre_registro = txtNombre.Text ?? "";
        string apellido_registro = txtApellido.Text ?? "";
        string edad_registro = txtEdad.Text ?? "";
        string fecha_registro = dpFecha.Date.ToString();
        string ciudad_registro = pCiudades.Items[pCiudades.SelectedIndex];
        string pais_registro = pPaises.Items[pPaises.SelectedIndex];


        Navigation.PushAsync(new Views.resumen(usuario, nombre_registro, apellido_registro, edad_registro, fecha_registro, ciudad_registro, pais_registro, costo_inicial, cuota_final, pago_total));

    }
}
namespace dcasagalloExamen.Views;

public partial class registro : ContentPage
{
	string usuario;
	public registro(string usuario_logueado)
	{
		InitializeComponent();

		usuario = usuario_logueado;

		lblSaludoUsuario.Text = "Usuario conectado: " + usuario;
	}
}
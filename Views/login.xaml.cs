namespace dcasagalloExamen.Views;

public partial class login : ContentPage
{
    string usuario;

    public login()
	{
		InitializeComponent();
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        // Validador de usuarios vectores
        bool encontrado = false;

        // Vectores
        string[] users = { "estudiante", "uisrael"};
        string[] pass = { "moviles", "2025" };

        //Validar campos vacios
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
        {
            DisplayAlertAsync("Error", "Ingrese un usuario y una clave", "Cerrar");
        }
        else
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == txtUsuario.Text && pass[i] == txtClave.Text)
                {
                    encontrado = true;
                    usuario = txtUsuario.Text;
                    break;
                }
            }

            if (encontrado)
            {
                Navigation.PushAsync(new Views.registro(usuario));
            }
            else
            {
                DisplayAlertAsync("Error", "Usuario o clave incorrectos", "Cerrar");
            }

        }

    }
}
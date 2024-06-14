namespace Tp3PepsiApp.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}
    private void BtnIngresar_Clicked(object sender, EventArgs e)
    {

        if (editTextNombre.Text == "alumno" && editTextPassword.Text == "1234")
        {
            editTextPassword.Text = string.Empty;
            editTextNombre.Text = string.Empty;
            Navigation.PushAsync(new InicioView());
        }
        else
        {
            editTextPassword.Text = string.Empty;
            editTextNombre.Text = string.Empty;
            DisplayAlert("Atención", "las credenciales ingresadas no son válidas", "OK");
        }
        
    }
}
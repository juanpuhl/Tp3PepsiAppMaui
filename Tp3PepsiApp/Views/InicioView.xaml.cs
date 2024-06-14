namespace Tp3PepsiApp.Views;

public partial class InicioView : ContentPage
{
	public InicioView()
	{
		InitializeComponent();
	}

    private  void BtnVolverClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginView()); // Regresar a la vista anterior (LoginView)
    }

    
        private void BtnProgramadorClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProgramadorView());
    }

}
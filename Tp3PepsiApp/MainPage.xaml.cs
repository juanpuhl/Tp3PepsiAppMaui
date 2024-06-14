namespace Tp3PepsiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnBtnCerrarClicked(object sender, EventArgs e)
        {
            // Maneja el evento del botón 'Volver'
        }

        private void OnBtnProgramadorClicked(object sender, EventArgs e)
        {
            // Maneja el evento del botón 'Programador'
        }
        private void OnBtnIngresarClicked(object sender, EventArgs e)
        {
            // Maneja el evento del botón 'Ingresar'
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

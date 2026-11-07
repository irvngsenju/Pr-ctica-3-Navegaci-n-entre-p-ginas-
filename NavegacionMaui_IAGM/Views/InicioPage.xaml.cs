namespace NavegacionMaui_IAGM.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		InitializeComponent();
	}

    private async void OnverInformacionClicked(object sender, EventArgs e)
    {
        // Abre la página asociada a esta ruta.
        await Shell.Current.GoToAsync("informacion");
    }
}
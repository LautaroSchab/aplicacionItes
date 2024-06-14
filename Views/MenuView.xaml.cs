namespace aplicacion.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
	}

    private async void acercadebutton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercadeView());
    }

    private async void SalirButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
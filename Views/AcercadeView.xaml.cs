namespace aplicacion.Views;

public partial class AcercadeView : ContentPage
{
	public AcercadeView()
	{
		InitializeComponent();
	}

    private async void SalirButton1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuView());
    }

    private void contacobutton_Clicked(object sender, EventArgs e)
    {

    }

    private void EnviarCorreobutton_Clicked(object sender, EventArgs e)
    {

    }
}
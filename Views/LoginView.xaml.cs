using aplicacion.Views;

namespace aplicacion.Views;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
    }
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (username == "Alumno" && password == "1234")
        {
            // Redirigir a la HomePage (aseg�rate de tener creada esta p�gina)
            await Navigation.PushAsync(new MenuView());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }

    }

    public void ClearInputs()
    {
        usernameEntry.Text = string.Empty;
        passwordEntry.Text = string.Empty;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ClearInputs();
    }

}
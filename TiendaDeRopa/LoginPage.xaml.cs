namespace TiendaDeRopa;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

        // Crear usuario admin si no existe
        if (!App.Database.Table<Usuario>().Any())
        {
            App.Database.Insert(new Usuario { Nombre = "admin", Password = "1234" });
        }
    }

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        var user = App.Database.Table<Usuario>()
            .FirstOrDefault(u => u.Nombre == txtUsuario.Text && u.Password == txtPassword.Text);

        if (user != null)
        {
            App.UserLogged = user.Nombre;
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}
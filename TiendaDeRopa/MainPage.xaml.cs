namespace TiendaDeRopa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblSaludo.Text = $"Bienvenido, {App.UserLogged}";
        }

        private async void BtnProductos_Clicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new ProductosPage());

        private async void BtnUsuarios_Clicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new UsuariosPage());

        private async void BtnVentas_Clicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new VentasPage());

        private async void BtnReportes_Clicked(object sender, EventArgs e)
            => await Navigation.PushAsync(new ReportesPage());
    }
}

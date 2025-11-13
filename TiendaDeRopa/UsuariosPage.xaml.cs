namespace TiendaDeRopa;

public partial class UsuariosPage : ContentPage
{
    public UsuariosPage()
    {
        InitializeComponent();
        CargarUsuarios();
    }

    void CargarUsuarios()
    {
        listaUsuarios.ItemsSource = App.Database.Table<Usuario>().ToList();
    }

    private void BtnAgregar_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtPassword.Text))
        {
            App.Database.Insert(new Usuario { Nombre = txtNombre.Text, Password = txtPassword.Text });
            txtNombre.Text = txtPassword.Text = string.Empty;
            CargarUsuarios();
        }
    }

    private void BtnEliminar_Clicked(object sender, EventArgs e)
    {
        var id = (int)((Button)sender).CommandParameter;
        var usuario = App.Database.Find<Usuario>(id);
        if (usuario != null)
        {
            App.Database.Delete(usuario);
            CargarUsuarios();
        }
    }
}
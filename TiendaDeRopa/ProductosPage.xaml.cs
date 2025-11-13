namespace TiendaDeRopa;

public partial class ProductosPage : ContentPage
{
    public ProductosPage()
    {
        InitializeComponent();
        CargarProductos();
    }

    void CargarProductos()
    {
        listaProductos.ItemsSource = App.Database.Table<Producto>().ToList();
    }

    private void BtnAgregar_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtNombre.Text) && double.TryParse(txtPrecio.Text, out double precio))
        {
            App.Database.Insert(new Producto { Nombre = txtNombre.Text, Precio = precio });
            txtNombre.Text = txtPrecio.Text = string.Empty;
            CargarProductos();
        }
    }

    private void BtnEliminar_Clicked(object sender, EventArgs e)
    {
        var id = (int)((Button)sender).CommandParameter;
        var prod = App.Database.Find<Producto>(id);
        if (prod != null)
        {
            App.Database.Delete(prod);
            CargarProductos();
        }
    }
}
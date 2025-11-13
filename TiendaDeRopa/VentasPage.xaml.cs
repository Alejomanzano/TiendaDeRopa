namespace TiendaDeRopa;

public partial class VentasPage : ContentPage
{
    public VentasPage()
    {
        InitializeComponent();
        CargarProductos();
        CargarVentas();
    }

    void CargarProductos()
    {
        var productos = App.Database.Table<Producto>().ToList();
        pickerProducto.ItemsSource = productos;
        pickerProducto.ItemDisplayBinding = new Binding("Nombre");
    }

    void CargarVentas()
    {
        listaVentas.ItemsSource = App.Database.Table<Venta>().ToList();
    }

    private void BtnAgregar_Clicked(object sender, EventArgs e)
    {
        if (pickerProducto.SelectedItem == null || !int.TryParse(txtCantidad.Text, out int cantidad))
            return;

        var prod = (Producto)pickerProducto.SelectedItem;
        double total = cantidad * prod.Precio;

        App.Database.Insert(new Venta
        {
            Producto = prod.Nombre,
            Cantidad = cantidad,
            Total = total
        });

        txtCantidad.Text = string.Empty;
        CargarVentas();
    }

    private void BtnEliminar_Clicked(object sender, EventArgs e)
    {
        var id = (int)((Button)sender).CommandParameter;
        var venta = App.Database.Find<Venta>(id);
        if (venta != null)
        {
            App.Database.Delete(venta);
            CargarVentas();
        }
    }
}
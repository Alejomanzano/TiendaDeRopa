namespace TiendaDeRopa;

public partial class ReportesPage : ContentPage
{
    public ReportesPage()
    {
        InitializeComponent();
        CargarReporte();
    }

    void CargarReporte()
    {
        var ventas = App.Database.Table<Venta>().ToList();
        listaReporte.ItemsSource = ventas;

        double totalGeneral = ventas.Sum(v => v.Total);
        lblTotalGeneral.Text = $"Total general: ${totalGeneral}";
    }

    private void BtnActualizar_Clicked(object sender, EventArgs e)
    {
        CargarReporte();
    }
}
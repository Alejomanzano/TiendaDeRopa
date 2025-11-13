using SQLite;

namespace TiendaDeRopa
{
    public partial class App : Application
    {
        public static SQLiteConnection Database;
        public static string UserLogged;

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "tienda.db3");
            Database = new SQLiteConnection(dbPath);
            CrearTablas();

            MainPage = new NavigationPage(new LoginPage());
        }

        void CrearTablas()
        {
            Database.CreateTable<Usuario>();
            Database.CreateTable<Producto>();
            Database.CreateTable<Venta>();
        }
    }
}
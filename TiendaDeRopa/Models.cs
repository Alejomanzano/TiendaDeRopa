using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }

    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
    }

    public class Venta
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
    }
}

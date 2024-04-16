using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecera
{
    public class Ventas
    {
        public int Id { get; set; }
        public int Id_ventas { get; set; }
        public int Usuario { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }       
        public decimal Precio { get; set; }    
        public decimal Tasa { get; set; }  
        public decimal Total { get; set; }

        public DateTime Fechaventa { get; set; }



    }

    public class Inventario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Cod_Barra { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; }
     

    }

    public class UpdateInv
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }

    }























}

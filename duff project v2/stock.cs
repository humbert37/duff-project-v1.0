using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace duff_project_v2
{
    public class stock
    {
       public int idBebida { get; set; }
       public string Cantidad { get; set; }
       public string fechaReg { get; set; }
       public int Precioventa { get; set; }

       public stock() { }

       public stock(int bidBebida, string bCantidad, string bfechaReg, int bPrecioventa)
       {
           this.idBebida = bidBebida;
           this.Cantidad = bCantidad;
           this.fechaReg = bfechaReg;
           this.Precioventa = bPrecioventa;

       }
    }
}

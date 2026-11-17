using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Pagos
    //BONUS
{
    public class Transferencia : IPagoStrategy
    {
        public const decimal Descuento = 0.3m;

        public string Nombre => "Transferencia";
        public bool PermiteCuotas => false;
        public bool RequiereCuit => false;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            return -subtotal * Descuento;
        }
    }
}
    
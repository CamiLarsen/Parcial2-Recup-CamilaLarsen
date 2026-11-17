using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Pagos
{
    public class PagoTarjeta : IPagoStrategy
    {
        public string Nombre => "Tarjeta";
        public bool PermiteCuotas => true;
        public bool RequiereCuit => false;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            switch(cuotas)
            {
                case 1: return 0m; //sin recargo 
                case 2: return subtotal * 0.5m; //+ 5%
                case 3: return subtotal * 0.10m; // +10%
                default: throw new ArgumentException("Con tarjeta se paga en 1, 2 y 3 cuotas");
            }
        }
    }
}

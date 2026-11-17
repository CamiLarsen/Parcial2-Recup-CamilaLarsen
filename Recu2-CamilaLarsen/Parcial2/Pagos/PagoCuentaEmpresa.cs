using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Pagos
{
    public class PagoCuentaEmpresa : IPagoStrategy
    {
        public const decimal Descuento = 0.5m;
        

        public string Nombre => "Cuenta empresa";
        public bool PermiteCuotas => false;
        public bool RequiereCuit => true;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            if(subtotal < 20000 )
                throw new ArgumentException("La cuenta corriente admite pedidos desde 20000");
            if (subtotal > 100000)
                return -subtotal * 0.8m;

            return -subtotal * Descuento;
        }
    }
}
    


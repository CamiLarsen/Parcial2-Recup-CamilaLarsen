using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parcial2.Observer
{
    public class HistorialObserver : IPedidoObserver
    {
            public void Actualizar(EventoPedido evento)
            {
                //Bitacora.Instancia.Regustrar(evento.Descripcion());
            }
        
    }
}

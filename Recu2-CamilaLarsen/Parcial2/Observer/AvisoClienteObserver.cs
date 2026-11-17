using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Observer
{
    public class AvisoClienteObserver : IPedidoObserver
    {

        private readonly string _rutaAvisos;

        public AvisoClienteObserver(string rutaAvisos)
        {
            _rutaAvisos = rutaAvisos;
        }

        public void Actualizar(EventoPedido evento)
        {
            /*OrdenPedido orden = evento.Pedido;
            string texto;

            if (evento.Tipo == TipoEvento.Alta)
                texto = $"Whatsapp a {orden.Cliente}, recibimos tu pedido #{orden.Id}. Total: {orden.Total:0C}";
            else if (evento.Tipo == TipoEvento.CambioEstado)
                texto = $"Tu vehículo {orden.Pedido} está listo para retirar. Total: {orden.Total:C0}.";
            else if (evento.Tipo == TipoEvento.Cancelacion)
                texto = $"Tu pedido #{orden.Id} fue cancelado.";
            else
                return;   // 

            File.AppendAllText(_rutaAvisos,
                $"[{evento.Fecha:dd/MM HH:mm}] WhatsApp a {orden.Cliente} ({orden.Telefono}): {texto}{Environment.NewLine}");
        }*/
        }
    }
}




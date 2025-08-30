using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludVital.Service.Interface
{
    public interface INotificacionService
    {
        void Enviar(string destinatario, string mensaje);

    }
}

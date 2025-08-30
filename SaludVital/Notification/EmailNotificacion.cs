using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Service.Interface;

namespace SaludVital.Notification
{
    class EmailNotificacion : INotificacionService
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"Enviando email a {destinatario}: {mensaje}");
        }
    }
}

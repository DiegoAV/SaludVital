using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Service.Interface;

namespace SaludVital.Notification
{
    class SmsNotificacion : INotificacionService
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"Enviando SMS a {destinatario}: {mensaje}");
        }
    }
}

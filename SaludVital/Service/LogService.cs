using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Service.Interface;

namespace SaludVital.Service
{
    class LogService : ILogService
    {
        public void Registrar(string mensaje)
        {
            Console.WriteLine($"LOG: {mensaje}");
        }
    }
}

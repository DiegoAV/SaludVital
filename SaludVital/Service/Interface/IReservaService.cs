using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;

namespace SaludVital.Service.Interface
{
    interface IReservaService
    {
        void ReservarCita(Cita cita);
        void CancelarCita(int citaId);
        void ReprogramarCita(int citaId, DateTime nuevaFecha);
    }
}

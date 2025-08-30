using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;

namespace SaludVital.Service.Interface
{
    interface IAgendaService
    {
        IEnumerable<Cita> VerAgenda(Doctor doctor, DateTime fecha);
        void AprobarCita(int citaId);
        void RechazarCita(int citaId);
    }
}

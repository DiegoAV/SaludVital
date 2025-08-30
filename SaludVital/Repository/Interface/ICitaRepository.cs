using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;

namespace SaludVital.Repository.Interface
{
    interface ICitaRepository
    {
        void Guardar(Cita cita);
        void Eliminar(int citaId);
        Cita ObtenerPorId(int citaId);
        IEnumerable<Cita> ObtenerPorDoctor(int doctorId, DateTime fecha);
    }
}

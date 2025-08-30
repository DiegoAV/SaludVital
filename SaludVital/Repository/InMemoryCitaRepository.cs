using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;
using SaludVital.Repository.Interface;

namespace SaludVital.Repository
{
    class InMemoryCitaRepository : ICitaRepository
    {
        private readonly List<Cita> _citas = new();
        public void Guardar(Cita cita) => _citas.Add(cita);
        public void Eliminar(int citaId) => _citas.RemoveAll(c => c.Id == citaId);
        public Cita ObtenerPorId(int citaId) => _citas.FirstOrDefault(c => c.Id == citaId);
        public IEnumerable<Cita> ObtenerPorDoctor(int doctorId, DateTime fecha) =>
            _citas.Where(c => c.Doctor.Id == doctorId && c.Fecha.Date == fecha.Date);
    }
}

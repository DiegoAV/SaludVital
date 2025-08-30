using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;
using SaludVital.Repository.Interface;

namespace SaludVital.Repository
{
    class SqlCitaRepository : ICitaRepository
    {
        public void Guardar(Cita cita) { /* Lógica con BD SQL o Entity Framework Core y NHibernate*/ }
        public void Eliminar(int citaId) { /* Lógica con BD SQL o Entity Framework Core y NHibernate*/ }
        public Cita ObtenerPorId(int citaId) => new Cita();
        public IEnumerable<Cita> ObtenerPorDoctor(int doctorId, DateTime fecha) => new List<Cita>();
    }
}

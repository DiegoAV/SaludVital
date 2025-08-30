using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludVital.Model
{
    class Cita
    {

        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Fecha { get; set; }
        public bool Aprobada { get; set; }
        public string ResumenConsulta { get; set; }
        public EstadoCita Estado { get; set; } = EstadoCita.Pendiente;

    }
}

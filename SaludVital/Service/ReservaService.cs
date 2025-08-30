using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludVital.Model;
using SaludVital.Repository.Interface;
using SaludVital.Service.Interface;

namespace SaludVital.Service
{
    class ReservaService : IReservaService
    {
        private readonly ICitaRepository _citaRepository;
        private readonly INotificacionService _notificacionService;
        private readonly ILogService _logService;

        public ReservaService(ICitaRepository citaRepo, INotificacionService notificacion, ILogService log)
        {
            _citaRepository = citaRepo;
            _notificacionService = notificacion;
            _logService = log;
        }

        public void ReservarCita(Cita cita)
        {
            _citaRepository.Guardar(cita);
            _notificacionService.Enviar(cita.Paciente.Email, "Su cita ha sido reservada.");
            _logService.Registrar($"Cita {cita.Id} reservada.");
        }

        public void CancelarCita(int citaId)
        {
            _citaRepository.Eliminar(citaId);
            _logService.Registrar($"Cita {citaId} cancelada.");
        }

        public void ReprogramarCita(int citaId, DateTime nuevaFecha)
        {
            var cita = _citaRepository.ObtenerPorId(citaId);
            cita.Fecha = nuevaFecha;
            _logService.Registrar($"Cita {citaId} reprogramada.");
        }
    }
}

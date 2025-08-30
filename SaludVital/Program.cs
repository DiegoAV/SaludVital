// See https://aka.ms/new-console-template for more information
using SaludVital.Model;
using SaludVital.Notification;
using SaludVital.Repository;
using SaludVital.Service;

Console.WriteLine("Hello, World!");


var repo = new InMemoryCitaRepository();
var notificacion = new EmailNotificacion();
var log = new LogService();
var reservaService = new ReservaService(repo, notificacion, log);

var paciente = new Paciente { Id = 1, Nombre = "Juan Pérez", Email = "juan@mail.com" };
var doctor = new Doctor { Id = 1, Nombre = "Dra. Gómez", Especialidad = Especialidad.Pediatria };
var cita = new Cita { Id = 1, Paciente = paciente, Doctor = doctor, Fecha = DateTime.Now.AddDays(2) };

reservaService.ReservarCita(cita);
reservaService.ReprogramarCita(cita.Id, DateTime.Now.AddDays(5));
reservaService.CancelarCita(cita.Id);
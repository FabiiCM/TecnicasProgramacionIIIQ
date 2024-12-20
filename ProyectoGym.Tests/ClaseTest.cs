using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;
using src.Model.Personas;
using ProyectoGym.src.Controller;

namespace ProyectoGym.Tests
{
    public class ClaseTest
    {
        private readonly DbContextOptions<GymContext> _dbOptions;
        private readonly GymContext _context;

        public ClaseTest()
        {
            _dbOptions = new DbContextOptionsBuilder<GymContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var Entrenador = new Entrenador { 
                ID = 1, 
                NombreCompleto = "Entrenador prueba",
                FechaNacimiento = new DateTime(1990, 12, 15), 
                CorreoElectronico = "correo@prueba.com", 
                Contraseña = "prueba123", 
                Telefono = "223365", 
                NombreUsuario = "entrenador1",
                Rol = "Entrenador",
                Especialidad = "Funcionales",
                HorariosDisponibles = "L-V 5am a 6pm",
                AñosDeExperiencia = 2
            };
            var Clase1 = new Clase { ID = 1, Nombre = "Clase 1", EntrenadorID = 1, Horario = "L-V", CupoMaximo = 2, Registradas = 0};

            _context.Personas.Add(Entrenador);
            _context.Clases.AddRange(Clase1);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarClases()
        {

            var controller = new ClaseController(_context);
            var entrenador = _context.Personas.Where(p => p.Rol == "Entrenador" && p.ID == 1).SingleOrDefault();

            var Clases = await controller.ListarClases();

            Assert.NotNull(Clases);
            Assert.Equal(1, Clases.Count); 
            Assert.All(Clases, c => Assert.Equal(entrenador.ID, c.EntrenadorID));
        }

        [Fact]
        public async Task CrearClase()
        {

            var controller = new ClaseController(_context);
            var Clase = new Clase { ID = 3, Nombre = "Clase 4", EntrenadorID = 1, CupoMaximo = 1, Horario = "L-J", Registradas = 0 };


            await controller.Crear(Clase, 1);
            var Clases = await _context.Clases.ToListAsync();


            Assert.Equal(2, Clases.Count);  
            Assert.Contains(Clases, c => c.EntrenadorID == 1);
        }
    }
}
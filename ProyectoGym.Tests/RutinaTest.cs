using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;
using src.Model.Personas;
using ProyectoGym.src.Controller;

namespace ProyectoGym.Tests
{
    public class RutinaTest
    {
        private readonly DbContextOptions<GymContext> _dbOptions;
        private readonly GymContext _context;

        public RutinaTest()
        {
            _dbOptions = new DbContextOptionsBuilder<GymContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var cliente = new Cliente {
                ID = 4,
                NombreCompleto = "Cliente prueba 3",
                FechaNacimiento = new DateTime(1998, 12, 15),
                CorreoElectronico = "correo@prueba.com",
                Contraseña = "prueba123",
                Telefono = "223365",
                NombreUsuario = "cliente4",
                TipoUsuario = "CLiente",
                Rol = "Cliente"
            };
            var cliente2 = new Cliente
            {
                ID = 1,
                NombreCompleto = "Cliente prueba 3",
                FechaNacimiento = new DateTime(1998, 12, 15),
                CorreoElectronico = "correo@prueba.com",
                Contraseña = "prueba123",
                Telefono = "223365",
                NombreUsuario = "cliente2",
                TipoUsuario = "CLiente",
                Rol = "Cliente"
            };
            var Rutina1 = new Rutina { 
                ID = 1, 
                Nombre = "Rutina 1", 
                ClienteID = 4,
                Descripcion = "Para pecho y espalda",
                FechaAsignación = new DateTime(2024, 12, 17)
            };

            _context.Personas.Add(cliente);
            _context.Rutinas.AddRange(Rutina1);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarRutinas()
        {

            var controller = new RutinaController(_context);
            var cliente = _context.Personas
                .SingleOrDefault(p => p.Rol == "Cliente" && p.ID == 1);

            var rutinas = await controller.ListarRutinas(cliente);

            Assert.NotNull(rutinas);
            Assert.Equal(1, rutinas.Count); 
            Assert.All(rutinas, r => Assert.Equal(cliente.ID, r.ClienteID));
        }

        [Fact]
        public async Task ObtenerRutina()
        {
            var controller = new RutinaController(_context);

            var rutina = await controller.ObtenerRutina(1); 

            Assert.NotNull(rutina);
            Assert.Equal(1, rutina.ID);

        }

        [Fact]
        public async Task CrearRutina()
        {
            var cliente = _context.Personas.Where(p => p.Rol == "cliente" && p.ID == 4).SingleOrDefault();
            var controller = new RutinaController(_context);
           
            var rutina2 = new Rutina {
                ID = 2,
                Nombre = "Rutina 1",
                ClienteID = 4,
                Descripcion = "Para pecho y espalda",
                FechaAsignación = new DateTime(2024, 12, 17)
            };
            var rutina3 = new Rutina
            {
                ID = 2,
                Nombre = "Rutina 3",
                ClienteID = 1,
                Descripcion = "Para pecho y espalda",
                FechaAsignación = new DateTime(2024, 12, 17)
            };


            await controller.Crear(rutina2);
            var rutinas = await _context.Rutinas.ToListAsync();


            Assert.Equal(2, rutinas.Count);  
            Assert.Contains(rutinas, m => m.ClienteID == 4);
        }

    }
}
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
                .UseInMemoryDatabase(databaseName: "TestGymDB")
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var cliente = new Cliente { ID = 1, NombreCompleto = "Juan Pérez" };
            var Rutina1 = new Rutina { ID = 1, Nombre = "Pepe brenes", ClienteID = 1, Descripcion = "rutina 1"};

            _context.Personas.Add(cliente);
            _context.Rutinas.AddRange(Rutina1);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarRutinas()
        {

            var controller = new RutinaController(_context);
            var cliente = new Person { ID = 1 };

            var rutinas = await controller.ListarRutinas(cliente);

            Assert.NotNull(rutinas);
            Assert.Equal(2, rutinas.Count); 
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

            var controller = new RutinaController(_context);
            var rutina = new Rutina { ID = 3, Nombre = "Rutina 3", ClienteID = 1 };


            await controller.Crear(rutina);
            var rutinas = await _context.Rutinas.ToListAsync();


            Assert.Equal(3, rutinas.Count);  
            Assert.Contains(rutinas, m => m.ClienteID == 1);
        }

        [Fact]
        public async Task EliminarRutina()
        {

            var controller = new RutinaController(_context);


            await controller.Eliminar(1); 
            var rutina = await _context.Rutinas.FirstOrDefaultAsync(e => e.ID == 1);

            Assert.Null(rutina); 
        }
    }
}
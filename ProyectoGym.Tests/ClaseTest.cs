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
                .UseInMemoryDatabase(databaseName: "TestGymDB")
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var Entrenador = new Entrenador { ID = 1, NombreCompleto = "Juan Pérez" };
            var Clase1 = new Clase { ID = 1, Nombre = "Clase 1", EntrenadorID = 1, };

            _context.Personas.Add(Entrenador);
            _context.Clases.AddRange(Clase1);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarClases()
        {

            var controller = new ClaseController(_context);
            var entrenador = new Person { ID = 1 };

            var Clases = await controller.ListarClases();

            Assert.NotNull(Clases);
            Assert.Equal(2, Clases.Count); 
            Assert.All(Clases, c => Assert.Equal(entrenador.ID, c.EntrenadorID));
        }

        [Fact]
        public async Task CrearClase()
        {

            var controller = new ClaseController(_context);
            var Clase = new Clase { ID = 3, Nombre = "Clase 4", EntrenadorID = 1 };


            await controller.Crear(Clase, 1);
            var Clases = await _context.Clases.ToListAsync();


            Assert.Equal(3, Clases.Count);  
            Assert.Contains(Clases, c => c.EntrenadorID == 1);
        }

       /* [Fact]
        public async Task EliminarClase()
        {

            var controller = new ClaseController(_context);


            await controller.Eliminar(1); 
            var Clase = await _context.Clases.FirstOrDefaultAsync(e => e.ID == 1);

            Assert.Null(Clase); 
        }*/
    }
}
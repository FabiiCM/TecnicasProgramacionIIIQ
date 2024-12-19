using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;
using src.Model.Personas;
using ProyectoGym.src.Controller;

namespace ProyectoGym.Tests
{
    public class MetricaTest
    {
        private readonly DbContextOptions<GymContext> _dbOptions;
        private readonly GymContext _context;

        public MetricaTest()
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
            var cliente2 = new Cliente { ID = 2, NombreCompleto = "Juan Pérez" };
            var Metrica1 = new Metrica { ID = 1, IMC = 50, ClienteID = 1, Cliente = cliente };
            var Metrica2 = new Metrica { ID = 2, Peso = 60, ClienteID = 2, Cliente = cliente };

            _context.Personas.Add(cliente);
            _context.Metricas.AddRange(Metrica1, Metrica2);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarMetricas()
        {

            var controller = new MetricaController(_context);
            var cliente = new Person { ID = 1 };

            var metricas = await controller.ListarMetricas(cliente);

            Assert.NotNull(metricas);
            Assert.Equal(2, metricas.Count); 
            Assert.All(metricas, e => Assert.Equal(cliente.ID, e.ClienteID));
        }

        [Fact]
        public async Task ObtenerMetrica()
        {
            var controller = new MetricaController(_context);

            var metrica = await controller.ObtenerMetrica(1); 

            Assert.NotNull(metrica);
            Assert.Equal(1, metrica.ID);

        }

        [Fact]
        public async Task CrearMetrica()
        {

            var controller = new MetricaController(_context);
            var metrica = new Metrica { ID = 3, IMC = 50, ClienteID = 1 };


            await controller.Crear(metrica, 1);
            var metricas = await _context.Metricas.ToListAsync();


            Assert.Equal(3, metricas.Count);  
            Assert.Contains(metricas, m => m.ClienteID == 1);
        }

        [Fact]
        public async Task EliminarMetrica()
        {

            var controller = new MetricaController(_context);


            await controller.Eliminar(1); 
            var metrica = await _context.Metricas.FirstOrDefaultAsync(e => e.ID == 1);

            Assert.Null(metrica); 
        }
    }
}
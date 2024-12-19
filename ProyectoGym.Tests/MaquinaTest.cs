using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Inventario;
using src.Model.Personas;
using ProyectoGym.src.Controller;

namespace ProyectoGym.Tests
{
    public class MaquinaTest
    {
        private readonly DbContextOptions<GymContext> _dbOptions;
        private readonly GymContext _context;

        public MaquinaTest()
        {
            _dbOptions = new DbContextOptionsBuilder<GymContext>()
                .UseInMemoryDatabase(databaseName: "TestGymDB")
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var Maquina1 = new Maquina { ID = 1, Nombre = "Maquina 1", costo = 52 };

            _context.Maquinas.AddRange(Maquina1, Maquina1);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ListarMaquinas()
        {

            var controller = new MaquinaController(_context);

            var Maquinas = await controller.ListarMaquinas();

            Assert.NotNull(Maquinas);
            Assert.Equal(1, Maquinas.Count); 
            //Assert.All(Maquinas, e => Assert.Equal(cliente.ID, e.ClienteID));
        }

        [Fact]
        public async Task ObtenerMaquina()
        {
            var controller = new MaquinaController(_context);

            var Maquina = await controller.ObtenerMaquina(1); 

            Assert.NotNull(Maquina);
            Assert.Equal(1, Maquina.ID);

        }

        [Fact]
        public async Task CrearMaquina()
        {

            var controller = new MaquinaController(_context);
            var Maquina = new Maquina { ID = 3, Nombre = "Nombre", VidaUtilMeses = 1 };


            await controller.Crear(Maquina);
            var Maquinas = await _context.Maquinas.ToListAsync();


            Assert.Equal(3, Maquinas.Count);  
            Assert.Contains(Maquinas, m => m.ID == 1);
        }

        [Fact]
        public async Task EliminarMaquina()
        {

            var controller = new MaquinaController(_context);


            await controller.Eliminar(1); 
            var Maquina = await _context.Maquinas.FirstOrDefaultAsync(m => m.ID == 1);

            Assert.Null(Maquina); 
        }
    }
}
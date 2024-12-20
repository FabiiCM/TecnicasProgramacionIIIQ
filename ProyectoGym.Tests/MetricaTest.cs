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
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new GymContext(_dbOptions);

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var cliente = new Cliente
            {
                ID = 5,
                NombreCompleto = "Cliente prueba",
                FechaNacimiento = new DateTime(1995, 12, 15),
                CorreoElectronico = "correo@prueba.com",
                Contraseña = "prueba123",
                Telefono = "223365",
                NombreUsuario = "cliente1",
                TipoUsuario = "cliente",
                Rol = "Cliente"
            };
            var cliente2 = new Cliente
            {
                ID = 1,
                NombreCompleto = "Cliente prueba",
                FechaNacimiento = new DateTime(1995, 12, 15),
                CorreoElectronico = "correo@prueba.com",
                Contraseña = "prueba123",
                Telefono = "223365",
                NombreUsuario = "cliente1",
                TipoUsuario = "cliente",
                Rol = "Cliente"
            };

            var Metrica = new Metrica
            {
                ID = 1,
                Peso = 60,
                ClienteID = 5,
                Cliente = cliente,
                IMC = 60,
                Cintura = 30,
                Cadera = 45,
                Brazo = 20,
                Muslo = 25
            };

            _context.Personas.Add(cliente);
            _context.Metricas.Add(Metrica);
            _context.SaveChanges();

        }

        [Fact]
        public async Task ListarMetricas()
        {
            var controller = new MetricaController(_context);

            var cliente = _context.Personas
                .SingleOrDefault(p => p.Rol == "Cliente" && p.ID == 1);

            Assert.NotNull(cliente);

            var metricas = await controller.ListarMetricas(cliente);

            Assert.NotNull(metricas);
            Assert.Equal(1, metricas.Count);
            Assert.All(metricas, m => Assert.Equal(cliente.ID, m.ClienteID));
        }

        [Fact]
        public async Task CrearMetrica()
        {

            var controller = new MetricaController(_context);
            var metrica = new Metrica
            {
                ID = 6,
                Peso = 60,
                ClienteID = 5,
                IMC = 60,
                Cintura = 30,
                Cadera = 45,
                Brazo = 20,
                Muslo = 25
            };
            var metrica2 = new Metrica
            {
                ID = 1,
                Peso = 60,
                ClienteID = 1,
                IMC = 60,
                Cintura = 30,
                Cadera = 45,
                Brazo = 20,
                Muslo = 25
            };


            await controller.Crear(metrica, 1);
            var metricas = await _context.Metricas.ToListAsync();


            Assert.Equal(2, metricas.Count);
            Assert.Contains(metricas, m => m.ClienteID == 1);
        }

    }
}
using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;
using src.Model.Personas;


namespace ProyectoGym.src.Controller
{
    public class ClaseController
    {
        private readonly GymContext _context;

        public ClaseController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Clase>> ListarClases()
        {
            return await _context.Clases.Include(m => m.Entrenador).ToListAsync();
        }

        public async Task<int> Crear(Clase Clase, int EntrenadorId)
        {
            var entrenador = await _context.Entrenadores.FirstOrDefaultAsync(e => e.ID == EntrenadorId);
            if (entrenador == null)
            {
                throw new Exception("Entrenador no encontrado." + EntrenadorId);
            }

            Clase.EntrenadorID = EntrenadorId;

            _context.Clases.Add(Clase);

            return await _context.SaveChangesAsync();
        }

        public async Task<Clase?> Details(int? id)
        {
            if (id == null)
            {

            }

            var clase = await _context.Clases
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clase == null)
            {

            }

            return clase;
        }
    }
}



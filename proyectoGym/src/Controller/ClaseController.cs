using Microsoft.EntityFrameworkCore;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;


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
            return await _context.Clases.ToListAsync();
        }

        public async Task<int> Crear(Clase Clase)
        {

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



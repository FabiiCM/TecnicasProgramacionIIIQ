using Microsoft.EntityFrameworkCore;
using Model.Inventario;
using ProyectoGym.src.Model.Context;
using src.Model.Inventario;
using src.Model.Personas;

namespace ProyectoGym.src.Controller
{
    public class MaquinaController 
    {
        private readonly GymContext _context;

        public MaquinaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Maquina>> ListarMaquinas()
        {
            return await _context.Maquinas.ToListAsync();
        }

        public async Task<int> Crear(Maquina Maquina)
        {

            Maquina.FechaAdquisicion = DateTime.Now;
            _context.Maquinas.Add(Maquina);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<Maquina?> Details(int? id)
        {
            if (id == null)
            {

            }

            var maquina = await _context.Maquinas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maquina == null)
            {

            }

            return maquina;
        }
    }
}

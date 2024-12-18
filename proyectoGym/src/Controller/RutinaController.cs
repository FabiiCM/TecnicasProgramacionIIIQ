using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Inventario;
using src.Model.Gestion;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoGym.src.Controller
{
    public class RutinaController 
    {
        private readonly GymContext _context;

        public RutinaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Rutina>> ListarRutinas(Person cliente)
        {

            return await _context.Rutinas
            .Include(r => r.Cliente)
            .ToListAsync();
        }

        public async Task<Rutina> ObtenerRutina(int ClienteId){
            return await _context.Rutinas.FirstOrDefaultAsync(m => m.ID == ClienteId);
        }

        public async Task<int> Crear(Rutina Rutina)
        {

            _context.Rutinas.Add(Rutina);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Editar(Rutina Rutina)
        {
            _context.Rutinas.Update(Rutina);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Eliminar(int RutinaId)
        {
            var rutina = await _context.Rutinas.FindAsync(RutinaId);
            if (rutina != null)
            {
                _context.Rutinas.Remove(rutina);
            }

            
            return await _context.SaveChangesAsync();;
        }
    }
}

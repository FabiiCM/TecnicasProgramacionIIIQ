using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;
using src.Model.Inventario;

namespace ProyectoGym.src.Controller
{
    public class MetricaController 
    {
        private readonly GymContext _context;

        public MetricaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Metrica>> ListarMetricas(Person cliente)
        {

            return await _context.Metricas
            .Include(m => m.Cliente).Where(m => m.ClienteID == cliente.ID)
            .ToListAsync();
        }

        public async Task<Metrica> ObtenerMetrica(int ClienteId){
            return await _context.Metricas.FirstOrDefaultAsync(m => m.ID == ClienteId);
        }

        public async Task<int> Crear(Metrica Metrica, int ClienteId)
        {

            _context.Metricas.Add(Metrica);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Editar(Metrica Metrica)
        {
            _context.Metricas.Update(Metrica);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Eliminar(int MetricaId)
        {
            var metrica = await _context.Metricas.FindAsync(MetricaId);
            if (metrica != null)
            {
                _context.Metricas.Remove(metrica);
            }

            
            return await _context.SaveChangesAsync();;
        }
    }
}

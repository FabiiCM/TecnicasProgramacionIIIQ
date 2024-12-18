using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
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

        public async Task<Maquina> ObtenerMaquina(int MaquinaId){
            return await _context.Maquinas.FirstOrDefaultAsync(m => m.ID == MaquinaId);
        }

        public async Task<int> Crear(Maquina Maquina)
        {
            _context.Maquinas.Add(Maquina);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Editar(Maquina Maquina)
        {
            _context.Maquinas.Update(Maquina);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Eliminar(int MaquinaId)
        {
            var maquina = await _context.Maquinas.FindAsync(MaquinaId);
            if (maquina != null)
            {
                _context.Maquinas.Remove(maquina);
            }

            
            return await _context.SaveChangesAsync();;
        }

    }
}
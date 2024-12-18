using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;

namespace ProyectoGym.src.Controller
{
    public class CategoriaController 
    {
        private readonly GymContext _context;

        public CategoriaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> ListarCategorias()
        {

            return await _context.Categorias.ToListAsync();
        }

       /* public async Task<Categoria> ObtenerCategoria(int CategoriaId){
            return await _context.Categorias.Where(c => c.ID == CategoriaId).ToListAsync();
        }*/

        public async Task<int> Crear(Categoria Categoria)
        {

            _context.Categorias.Add(Categoria);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Editar(Categoria Categoria)
        {
            _context.Categorias.Update(Categoria);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Eliminar(int CategoriaId)
        {
            var categoria = await _context.Categorias.FindAsync(CategoriaId);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
            }

            return await _context.SaveChangesAsync();;
        }
    }
}
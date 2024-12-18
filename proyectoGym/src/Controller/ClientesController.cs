using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Inventario;

namespace ProyectoGym.src.Controller
{
    public class ClientesController
    {
        private readonly GymContext _context;

        public ClientesController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> ListarClientes()
        {
            return await _context.Personas.Where(p => p.Rol == "Cliente").ToListAsync();
        }

        public async Task<Cliente> ObtenerCliente(int ClienteId)
        {
            return await _context.Clientes.FirstOrDefaultAsync(p => p.ID == ClienteId);
        }

        public async Task<int> Crear(Cliente Cliente)
        {

            Cliente.Rol = "Cliente";
            _context.Clientes.Add(Cliente);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Editar(Cliente Cliente)
        {
            _context.Clientes.Update(Cliente);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Eliminar(int ClienteId)
        {
            var cliente = await _context.Clientes.FindAsync(ClienteId);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }


            return await _context.SaveChangesAsync(); ;
        }

    }
}

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
    public class MembresiaController 
    {
        private readonly GymContext _context;

        public MembresiaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Membresia>> ListarMembresias()
        {

            return await _context.Membresias
            .Include(m => m.Cliente)
            .ToListAsync();
        }

        public async Task<Membresia?> Details(int? id)
        {
            if (id == null)
            {

            }

            var membresia = await _context.Membresias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (membresia == null)
            {

            }

            return membresia;
        }

        public async Task<int> Afiliar(Membresia Membresia, int ClienteId)
        {
            var cliente = await _context.Personas.FirstOrDefaultAsync(p => p.ID == ClienteId);
            if (cliente == null)
            {
                throw new Exception("Cliente no encontrado."+ ClienteId);
            }

            Membresia.ClienteID = ClienteId;
            _context.Membresias.Add(Membresia);


            return await _context.SaveChangesAsync();
        }

        public async Task<Membresia?> obtenerMembresia(int clienteId)
        {
            return await _context.Membresias.FirstOrDefaultAsync(m => m.ClienteID == clienteId);
        }

        /*
        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TipoUsuario,FechaNacimiento,NombreCompleto,Contraseña,CorreoElectronico,NombreUsuario,Telefono,Rol")] Cliente cliente)
        {
            if (id != cliente.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.ID == id);
        }*/
    }
}

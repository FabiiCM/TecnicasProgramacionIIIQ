﻿using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;

namespace ProyectoGym.src.Controller
{
    public class EntrenadorController 
    {
        private readonly GymContext _context;

        public EntrenadorController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> ListarEntrenadores()
        {
            return await _context.Personas.Where(p => p.Rol == "Entrenador").ToListAsync();
        }

        public async Task<Entrenador?> Details(int? id)
        {
            if (id == null)
            {

            }

            var cliente = await _context.Entrenadores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cliente == null)
            {

            }

            return cliente;
        }

        public async Task<int> Crear(Entrenador Entrenador)
        {

            Entrenador.Rol= "Entrenador";
            _context.Entrenadores.Add(Entrenador);

            return await _context.SaveChangesAsync();
        }

        // GET: Clientes/Create
        /*public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TipoUsuario,FechaNacimiento,NombreCompleto,Contraseña,CorreoElectronico,NombreUsuario,Telefono,Rol")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

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

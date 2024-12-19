using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Gestion;

namespace ProyectoGym.src.Controller
{
    public class ReservaController 
    {
        private readonly GymContext _context;

        public ReservaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Reserva>> ListarReservaciones()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task<Reserva?> Details(int? id)
        {
            if (id == null)
            {

            }

            var reserva = await _context.Reservas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reserva == null)
            {

            }

            return reserva;
        }

        public async Task<int> Crear(Reserva Reserva, int ClaseId, int ClienteId)
        {
            var clase = await _context.Clases.FirstOrDefaultAsync(p => p.ID == ClaseId);
            if (clase == null)
            {
                throw new Exception("No se encontró la clase." + ClaseId);
            }

            if (clase.Registradas >= clase.CupoMaximo)
            {
                throw new Exception("Ya no hay cupo para la clase." + clase.Nombre);
            }

            clase.Registradas++;
            _context.Clases.Update(clase);

            Reserva.ClaseID = ClaseId;
            Reserva.ClienteID = ClienteId;
            _context.Reservas.Add(Reserva);

            return await _context.SaveChangesAsync();
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

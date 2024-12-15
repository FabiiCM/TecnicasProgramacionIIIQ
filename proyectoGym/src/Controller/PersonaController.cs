using src.Model.Personas;
using ProyectoGym.src.Model.Context;

namespace ProyectoGym.src.Controller
{
    public class PersonaController 
    {
        private readonly GymContext _context;
        private static bool _autenticada;
        private static Person _persona;

        public PersonaController(GymContext context)
        {
            _context = context;
        }

        public Person Autenticar(string nombreUsuario, string contraseña)
        {
            //var autenticada = false;

            var persona = _context.Personas.Where(p => p.NombreUsuario == nombreUsuario && p.Contraseña == contraseña).SingleOrDefault();

            if (persona == null) {
                throw new Exception("Credenciales inválidas.");
            }

            _autenticada = true;
            _persona = persona;

            return persona;
        }

        public bool EstaAutenticada ()
        {
            return _autenticada;
        }

        public Person PersonaAutenticada()
        {
            return _persona; 
        }

        public void CerrarSesion()
        {
            _autenticada = false;

        }
    }
}

using System;
using System.Collections.Generic;

namespace ProyectoGym
{
    public class Cliente
    {
        // Método estático para validar credenciales
        public static bool Validacion(string usuario, string contraseña, string tipousuario)
        {
            // Lista de usuarios en memoria (puedes reemplazar con una base de datos)
            var usuarios = new Dictionary<string, (string Contraseña, string tipousuario)>
            {
                { "cliente1", ("1234", "Cliente") },
                { "entrenador1", ("abcd", "Entrenador") }
            };

            // Validar si existe el usuario y si los datos coinciden
            return usuarios.ContainsKey(usuario) &&
                   usuarios[usuario].Contraseña == contraseña &&
                   usuarios[usuario].tipousuario == tipousuario;
        }
    }
}


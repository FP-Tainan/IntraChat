using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntraChat.Utilities
{
    public static class Global
    {
        public static string Usuario { get; private set; }
        public static string Nome { get; private set; }
        public static int Usuario_id { get; private set; }

     
        public static void DefinirUsuario(string usuario) { Usuario = usuario; }
        public static void DefinirNome(string nome) { Nome = nome; }
        public static void DefinirUsuario_id(int id) { Usuario_id = id; }
    }
}

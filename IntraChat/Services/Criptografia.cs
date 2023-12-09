using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IntraChat.Services
{
    internal class Criptografia
    {
        public Criptografia() { }

        public string Senha(string senha)
        {
            string senhaCriptografada = "";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                senhaCriptografada = builder.ToString();
            }
            return senhaCriptografada;
        }


    }
}

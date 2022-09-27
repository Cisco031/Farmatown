using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Usuario
    {
        public Usuario(int idUsuario, string nomUsuario, string apeUsuario, int tipoUsuario)
        {
            IdUsuario = idUsuario;
            NomUsuario = nomUsuario;
            ApeUsuario = apeUsuario;
            TipoUsuario = tipoUsuario;
        }

        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string ApeUsuario { get; set; }
        public int TipoUsuario { get; set; }

    }
}

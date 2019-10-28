using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralWebAPI.Models
{
    public class DTOUsuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
        public int idade { get; set; }
        public string imagemPerfil { get; set; }
        public string telefone { get; set; }
    }
}
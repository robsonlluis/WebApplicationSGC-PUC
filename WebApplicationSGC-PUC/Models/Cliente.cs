using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationSGC_PUC.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }

}
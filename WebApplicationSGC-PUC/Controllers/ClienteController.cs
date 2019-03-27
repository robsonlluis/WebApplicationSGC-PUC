using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationSGC_PUC.Models;
using System.Web.Mvc;

namespace WebApplicationSGC_PUC.Controllers
{
    public class ClienteController : ApiController
    {

        private readonly Cliente[] Clientes = new Cliente[]
        {
            new Cliente { ID = 1, Nome = "Eduardo Pires", Email = "falecom@eduardopires.net.br", Ativo = true },
            new Cliente { ID = 2, Nome = "Bill Gates", Email = "gates@microsoft.com", Ativo = true },
            new Cliente { ID = 3, Nome = "Aleister Crowley", Email = "aleister@therion.com", Ativo = false }
        };

        // GET: api/Cliente
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            var clientes = Clientes;
            return clientes.SingleOrDefault(x => x.ID == id).Nome;
            //return "value";
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}

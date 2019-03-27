using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SQLite;
using WebApplicationSGC_PUC.Models;

namespace WebApplicationSGC_PUC.Controllers
{
    public class ClienteAlunoController : ApiController
    {
        // GET: api/ClienteAluno
        //public IEnumerable<string> Get()
        //{
        //     return new string[] { "value1", "value2" };
        //}

        // GET: api/ClienteAluno/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ClienteAluno
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ClienteAluno/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClienteAluno/5
        public void Delete(int id)
        {
        }

        public List<ClienteAluno> getAllClienteAluno()
        {
            try
            {
                using (var db = new Entities1())
                {
                    ClienteAluno cA = new ClienteAluno();
                    return (cA.getAllClienteAluno(db).ToList());
                }

            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("api/ClienteAluno/{usuario}/{senha}")]
        public IEnumerable<string> getValidateCredencials(string usuario, string senha)
        {
            try
            {
                using (var db = new Entities1())
                {
                    ClienteAluno cA = new ClienteAluno();
                    return new string[] { "Resultado", (cA.getValidateCredencials(db, usuario, senha)).ToString() };
                }

            }
            catch (Exception e)
            {

                return new string[] { "Error", e.InnerException.ToString() };
            }
        }
    }
}

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
    public class cResultado
    {
        public string resultado;
    }

    public class ClienteAlunoController : ApiController
    {
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

        //Robson Souza.
        //Retorna a lista de todos os alunos cadastrados.
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

        //Robson Souza.
        //Valida se as credenciais fornecidas estão corretas.
        //Retorna um Json com a chave "resultado" igual a TRUE se as credenciais estão corretas ou FALSE se estão incorretas.
        [HttpGet]
        [Route("api/ClienteAluno/{usuario}/{senha}")]
        public cResultado getValidateCredencials(string usuario, string senha)
        {
            try
            {
                using (var db = new Entities1())
                {
                    ClienteAluno cA = new ClienteAluno();
                    cResultado resultado = new cResultado();
                    resultado.resultado = (cA.getValidateCredencials(db, usuario.ToLower(), senha)).ToString();
                    return resultado;
                }

            }
            catch (Exception e)
            {

                cResultado resultado = new cResultado();
                resultado.resultado = "Error";
                return resultado;
            }
        }
    }
}

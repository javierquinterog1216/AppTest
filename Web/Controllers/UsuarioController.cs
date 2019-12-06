using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Core;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        UsuarioCore usuarioCore = new UsuarioCore();
        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<UsuarioModel> Get()
        {
            try
            {
                return usuarioCore.GetAll();
            }
            catch (Exception)
            {

                throw;
            }

        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public UsuarioModel Get(int id)
        {
            try
            {
                return usuarioCore.Get(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody] UsuarioModel model)
        {
            try
            {
                if (model.IdUsuario > 0)
                {
                    usuarioCore.Modify(model);
                }
                else
                {
                    usuarioCore.Add(model);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

       
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                usuarioCore.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using LojaPc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaPc.Controllers
{
    [RoutePrefix("api/Web")]
    public class WebController : ApiController
    {
        private Context ct = new Context();


        [Route("Usuario/{Nome}/{Senha}")]
        public IHttpActionResult GetUsuario(string Nome, string Senha)
        {
           Usuario u = ct.Usuarios.FirstOrDefault(x => x.UsuarioNome.Equals(Nome) && x.UsuarioSenha.Equals(Senha));

            if(u != null){
                dynamic a = new
                {

                    Nome = u.UsuarioNome,
                    Senha = u.UsuarioSenha,
                    Email = u.UsuarioEmail

                };

                return Ok(a);
            }
            return BadRequest();

        }

        

    }
}

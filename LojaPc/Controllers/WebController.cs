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

            if (u != null)
            {
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

        [Route("UsuarioPorId/{id}")]
        public IHttpActionResult GetUsuarioPorId(int id)
        {

            Usuario u = ct.Usuarios.Find(id);

            if (u != null)
            {
                dynamic a = new
                {
                    Nome = u.UsuarioNome,
                    Email = u.UsuarioEmail

                };

                return Ok(a);
            }

            return BadRequest();

        }

        [Route("ListarUsuarios")]
        public dynamic GetListarUsuarios()
        {
            List<dynamic> usuarios = new List<dynamic>();
            foreach (Usuario item in ct.Usuarios.ToList())
            {
                usuarios.Add(
                    new
                    {
                        Id = item.UsuarioId,
                        Nome = item.UsuarioNome,
                        Email = item.UsuarioEmail
                    }
            );

            }

            return new { AlunosArray = usuarios };
        }

        [Route("CadastrarUsuario")]
        [HttpPost]
        public IHttpActionResult PostCadastrarUsuario(Usuario usuario)
        {
            try
            {
                ct.Usuarios.Add(usuario);
                ct.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        [Route("ListarEmpresas")]
        public dynamic GetListarEmpresas()
        {
            List<dynamic> empresas = new List<dynamic>();
            foreach (Empresa item in ct.Empresas.ToList())
            {
                empresas.Add(
                    new
                    {
                        Id = item.EmpresaId,
                        Nome = item.Nome,
                        Nomefantasia = item.NomeFantasia,
                        Cnpj = item.Cnpj,
                        Email = item.Cnpj,
                        Telefone = item.Telefone,
                        Celular = item.Celular,
                        Uf = item.Uf,
                        Cidade = item.Cidade,
                        Bairro = item.Bairro,
                        Endereco = item.Endereco,
                        Cep = item.Cep,
                        InscricaoEstadual = item.InscricaoEstadual,
                        IncricaoMunicipal = item.InscricaoMunicipal,
                        Status = item.Status,
                        Resposavel = item.Responsavel,
                        Url = item.Url


                    }
                    );
            }

            return new { EmpresasArray = empresas };

        }

        [Route("EmpresaPorId/{id}")]
        public IHttpActionResult GetEmpresaPorId(int id)
        {
            Empresa emp = ct.Empresas.Find(id);

            if (emp != null)
            {
                dynamic a = new
                {
                    Id = emp.EmpresaId,
                    Nome = emp.Nome,
                    Nomefantasia = emp.NomeFantasia,
                    Cnpj = emp.Cnpj,
                    Email = emp.Cnpj,
                    Telefone = emp.Telefone,
                    Celular = emp.Celular,
                    Uf = emp.Uf,
                    Cidade = emp.Cidade,
                    Bairro = emp.Bairro,
                    Endereco = emp.Endereco,
                    Cep = emp.Cep,
                    InscricaoEstadual = emp.InscricaoEstadual,
                    IncricaoMunicipal = emp.InscricaoMunicipal,
                    Status = emp.Status,
                    Resposavel = emp.Responsavel,
                    Url = emp.Url
                };
                return Ok(a);
            }

            return BadRequest();
        }

       



    }
}

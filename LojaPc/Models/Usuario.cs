using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaPc.Models
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Usuário")]
        [MaxLength(35, ErrorMessage = "Máximo 35 Caracteres!!!")]
        public string UsuarioNome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email Inválido!!!")]
        public string UsuarioEmail { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        public string UsuarioSenha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Compare("UsuarioSenha", ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Confirmação de Senha")]
        [NotMapped]
        public string UsuarioConfirmaSenha { get; set; }

        public string Role { get; set; }

        public Usuario()
        {

        }

        public Usuario(string UsuarioNome, string UsuarioEmail, string UsuarioSenha)
        {
            this.UsuarioNome = UsuarioNome;
            this.UsuarioEmail = UsuarioEmail;
            this.UsuarioSenha = UsuarioSenha;
        }

    }
}
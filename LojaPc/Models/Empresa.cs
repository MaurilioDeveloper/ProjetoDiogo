using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaPc.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Razão Social: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Nome Fantasia: ")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "CNPJ:")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [EmailAddress(ErrorMessage = "Email Inválido!!!")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Telefone:")]
        public string Telefone { get; set; }

        [Display(Name = "Celular: ")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "UF: ")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!!!")]
        [Display(Name = "CEP:")]
        public string Cep { get; set; }

        [Display(Name = "Inscrição Estadual: ")]
        public string InscricaoEstadual { get; set; }

        [Display(Name = "Inscrição Municipal: ")]
        public string InscricaoMunicipal { get; set; }

        [Display(Name = "Status: ")]
        public string Status { get; set; }

        [Display(Name = "Responsável: ")]
        public string Responsavel { get; set; }

        [Display(Name = "URL: ")]
        public string Url { get; set; }
    }
}
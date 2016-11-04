using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaPc.Models
{
    [Table("Roles")]
    public class Roles
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
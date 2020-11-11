using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioTO.Models
{
    public class Entidades
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Criacao { get; set; } = DateTime.Now;
    }
}

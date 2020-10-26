using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORMIntroductionAssignment.Model
{
    class Produto
    {
        [Key]
        [Column("IDProduto")]
        public int ID { get; set; }
        public string Descricao { get; set; }
        [Required]
        public decimal ValorUnitario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORMIntroductionAssignment
{
    class Vendedor
    {
        [Key]
        [Column("VendedorID")]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        public decimal MetaVenda { get; set; }
    }
}

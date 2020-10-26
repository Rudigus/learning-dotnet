using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORMIntroductionAssignment
{
    class Cliente
    {
        [Key]
        [Column("ClienteID")]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}

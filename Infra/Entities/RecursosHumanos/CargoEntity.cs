using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.RecursosHumanos
{

    [Table("cargos")]
    public class CargoEntity
    {

        [Key]
        [Column("pk_cargos")]
        public int Id { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("descricao")]
        [StringLength(45)]
        public string Descricao { get; set; }

        [Column("salario")]
        public double Salario { get; set; }

        [Column("funcao")]
        [StringLength(45)]
        public string Funcao { get; set; }
        
    }
}
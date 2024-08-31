using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.RecursosHumanos
{

     [Table("nivelAcesso")]
    public class NivelAcessoEntity
    {
        [Key]
        [Column("pk_nivel")]
        public int Id { get; set; }

        [Column("descricao")]
        [StringLength(45)]
        public string Descricao { get; set; }

        [Column("permissoes")]
        [StringLength(45)]
        public string Permissoes { get; set; }
        
    }
}
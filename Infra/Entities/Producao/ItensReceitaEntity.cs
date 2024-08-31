using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Producao
{
    [Table("itens_receita")]
    public class ItensReceitaEntity
    {
        [Key]
        [Column("pk_itens")]
        public int Id { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor")]
        public float Valor { get; set; }
    }
}
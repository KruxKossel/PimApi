using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Producao
{
    [Table("relatorio_producao")]
    public class RelatorioProducaoEntity
    {
        [Key]
        [Column("pk_relatorio")]
        public int Id { get; set; }

        [Column("data_relatorio")]
        public DateTime DataRelatorio { get; set; }

        [Column("conteudo")]
        [StringLength(245)]
        public string Conteudo { get; set; }

        [ForeignKey("ProducaoEntity")]
        [Column("producao_pk_producao")]
        public int ProducaoId { get; set; }
        public ProducaoEntity Producao { get; set; }
    }
}
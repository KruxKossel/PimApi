using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Producao
{
    [Table("producao")]
    public class ProducaoEntity
    {
        [Key]
        [Column("pk_producao")]
        public int Id { get; set; }

        [Column("lote")]
        [StringLength(45)]
        public string Lote { get; set; }

        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [Column("data_termino")]
        public DateTime? DataTermino { get; set; }

        [Column("data_previsao_colheita")]
        public DateTime? DataPrevisaoColheita { get; set; }

        [Column("fk_agricultor")]
        [StringLength(45)]
        public string AgricultorId { get; set; }

        [ForeignKey("ApiEntity")]
        [Column("api_pk_api")]
        public int ApiId { get; set; }
        public ApiEntity Api { get; set; }

        [ForeignKey("ItensReceitaEntity")]
        [Column("itens_receita_pk_itens")]
        public int ItensReceitaId { get; set; }
        public ItensReceitaEntity ItensReceita { get; set; }
    }
}
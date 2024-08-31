using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Producao
{

    [Table("api")]
    public class ApiEntity
    {
        [Key]
        [Column("pk_api")]
        public int Id { get; set; }

        [Column("temperatura")]
        public float? Temperatura { get; set; }

        [Column("desenvolvimento")]
        [StringLength(45)]
        public string Desenvolvimento { get; set; }

        [Column("data_informacao")]
        public DateTime? DataInformacao { get; set; }

        [Column("nivel_agua")]
        public float? NivelAgua { get; set; }

        [ForeignKey("ProducaoEntity")]
        [Column("fk_producao")]
        public int ProducaoId { get; set; }
        public ProducaoEntity Producao { get; set; }
    }
}
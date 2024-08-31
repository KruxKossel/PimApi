using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;

namespace Infra.Entities.Producao
{
    [Table("item_consumo")]
    public class ItemConsumoEntity
    {
        [Key]
        [Column("pk_item")]
        public int Id { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [ForeignKey("ItensReceitaEntity")]
        [Column("itens_receita_pk_itens")]
        public int ItensReceitaId { get; set; }
        public ItensReceitaEntity ItensReceita { get; set; }

        [ForeignKey("ProdutoEntity")]
        [Column("produtos_pk_produtos")]
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }
    }
}
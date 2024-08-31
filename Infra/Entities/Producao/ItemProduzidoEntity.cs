using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;

namespace Infra.Entities.Producao
{
    [Table("item_produzido")]
    public class ItemProduzidoEntity
    {
        [Key]
        [Column("pk_item")]
        public int Id { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("data_validade")]
        public DateTime? DataValidade { get; set; }

        [ForeignKey("ProducaoEntity")]
        [Column("producao_pk_producao")]
        public int ProducaoId { get; set; }
        public ProducaoEntity Producao { get; set; }

        [ForeignKey("ApiEntity")]
        [Column("producao_api_pk_api")]
        public int ApiId { get; set; }
        public ApiEntity Api { get; set; }

        [ForeignKey("ItensReceitaEntity")]
        [Column("producao_itens_receita_pk_itens")]
        public int ItensReceitaId { get; set; }
        public ItensReceitaEntity ItensReceita { get; set; }

        [ForeignKey("ProdutoEntity")]
        [Column("produtos_pk_produtos")]
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }
    }
}
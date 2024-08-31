using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Estoque
{
    [Table("produtos")]
    public class ProdutoEntity
    {
        [Key]
        [Column("pk_produtos")]
        public int Id { get; set; }

        [Column("nome")]
        [StringLength(45)]
        public string Nome { get; set; }

        [Column("descricao")]
        [StringLength(45)]
        public string Descricao { get; set; }

        [Column("preco_venda")]
        public float PrecoVenda { get; set; }

        [Column("quantidade_estoque")]
        public int QuantidadeEstoque { get; set; }

        [Column("insumo_consumo")]
        public int InsumoConsumo { get; set; }

        [Column("preco_compra")]
        public double PrecoCompra { get; set; }
    }
}
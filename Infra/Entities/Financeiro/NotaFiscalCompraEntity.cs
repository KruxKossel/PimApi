using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;

namespace Infra.Entities.Financeiro
{
    [Table("nota_fiscal_compra")]
    public class NotaFiscalCompraEntity
    {
        [Key]
        [Column("pk_compra")]
        public int Id { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor_unitario")]
        public double ValorUnitario { get; set; }

        [Column("valor_tot")]
        public double ValorTotal { get; set; }

        [ForeignKey("ProdutoEntity")]
        [Column("produtos_pk_produtos")]
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }
    }
}
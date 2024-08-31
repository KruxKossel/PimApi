using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;
using Infra.Entities.Financeiro;

namespace Infra.Entities.Vendas
{
    [Table("itens_venda")]
    public class ItensVendaEntity
    {
        [Key]
        [Column("pk_item")]
        public int Id { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor_unitario")]
        public double ValorUnitario { get; set; }

        [ForeignKey("ProdutoEntity")]
        [Column("produtos_pk_produtos")]
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }
    }
}
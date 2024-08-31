using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Financeiro
{
    [Table("nota_fiscal_venda")]
    public class NotaFiscalVendaEntity
    {
        [Key]
        [Column("pk_pedido")]
        public int Id { get; set; }

        [Column("data_pedido")]
        public DateTime DataPedido { get; set; }

        [Column("valor_total")]
        public double ValorTotal { get; set; }

        [Column("status")]
        [StringLength(45)]
        public string Status { get; set; }
    }
}
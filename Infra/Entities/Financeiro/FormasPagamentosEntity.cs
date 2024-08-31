using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.RecursosHumanos;
using Infra.Entities.Vendas;

namespace Infra.Entities.Financeiro
{
    [Table("formas_pagamentos")]
    public class FormasPagamentosEntity
    {
        [Key]
        [Column("pk_formaPamento")]
        [StringLength(45)]
        public string Id { get; set; }

        [Column("status")]
        [StringLength(45)]
        public string Status { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [ForeignKey("OrdemCompraEntity")]
        [Column("ordem_compra_pk_compra")]
        public int OrdemCompraId { get; set; }
        public OrdemCompraEntity OrdemCompra { get; set; }

        [ForeignKey("FuncionarioEntity")]
        [Column("ordem_compra_funcionarios_pk_funcionario")]
        [StringLength(45)]
        public string FuncionarioId { get; set; }
        public FuncionarioEntity Funcionario { get; set; }

        [ForeignKey("CargoEntity")]
        [Column("ordem_compra_funcionarios_cargos_pk_cargos1")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }
    }
}
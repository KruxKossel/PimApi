using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;
using Infra.Entities.Financeiro;
using Infra.Entities.RecursosHumanos;

namespace Infra.Entities.Vendas
{
     [Table("ordem_compra")]
    public class OrdemCompraEntity
    {
        [Key]
        [Column("pk_compra")]
        public int Id { get; set; }

        [Column("status")]
        [StringLength(45)]
        public string Status { get; set; }

        [ForeignKey("FuncionarioEntity")]
        [Column("funcionarios_pk_funcionario")]
        [StringLength(45)]
        public string FuncionarioId { get; set; }
        public FuncionarioEntity Funcionario { get; set; }

        [ForeignKey("CargoEntity")]
        [Column("funcionarios_cargos_pk_cargos")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }

        [ForeignKey("FornecedorEntity")]
        [Column("fornecedor_pk_fornecedor")]
        [StringLength(45)]
        public string FornecedorId { get; set; }
        public FornecedorEntity Fornecedor { get; set; }

        [ForeignKey("PagamentosContasEntity")]
        [Column("pagemetos_contas_pk_pagamento")]
        [StringLength(45)]
        public string PagamentoId { get; set; }
        public PagamentosContasEntity Pagamento { get; set; }

        [ForeignKey("NotaFiscalCompraEntity")]
        [Column("nota_fiscal_compra_pk_compra")]
        public int NotaFiscalCompraId { get; set; }
        public NotaFiscalCompraEntity NotaFiscalCompra { get; set; }

        [ForeignKey("ProdutoEntity")]
        [Column("nota_fiscal_compra_produtos_pk_produtos")]
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Financeiro;
using Infra.Entities.RecursosHumanos;

namespace Infra.Entities.Producao
{
     [Table("relatorio_venda")]
    public class RelatorioVendaEntity
    {
        [Key]
        [Column("pk_relatorio")]
        public int Id { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

        [Column("total_vendas")]
        public int TotalVendas { get; set; }

        [Column("produtos_lista")]
        [StringLength(45)]
        public string ProdutosLista { get; set; }

        [Column("quantidade_produtos")]
        [StringLength(45)]
        public string QuantidadeProdutos { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }

        [ForeignKey("FuncionarioEntity")]
        [Column("funcionarios_pk_funcionario")]
        [StringLength(45)]
        public string FuncionarioId { get; set; }
        public FuncionarioEntity Funcionario { get; set; }

        [ForeignKey("CargoEntity")]
        [Column("funcionarios_cargos_pk_cargos")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }

        [ForeignKey("ProducaoEntity")]
        [Column("funcionarios_producao_pk_producao")]
        public int ProducaoId { get; set; }
        public ProducaoEntity Producao { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("funcionarios_nota_fiscal_venda_pk_pedido")]
        public int FuncionarioNotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity FuncionarioNotaFiscalVenda { get; set; }
    }
}
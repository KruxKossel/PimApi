using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Producao;
using Infra.Entities.RecursosHumanos;
using Infra.Entities.Vendas;

namespace Infra.Entities.Financeiro
{
    [Table("recebe_contas")]
    public class RecebeContasEntity
    {
        [Key]
        [Column("pk_conta")]
        public int Id { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("data_vencimento")]
        public DateTime DataVencimento { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }

        [ForeignKey("ClienteEntity")]
        [Column("cliente_pk_cliente")]
        public int ClienteId { get; set; }
        public ClienteEntity Cliente { get; set; }

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
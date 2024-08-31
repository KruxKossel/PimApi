using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Financeiro;
using Infra.Entities.Producao;
using Infra.Entities.RecursosHumanos;

namespace Infra.Entities.Vendas
{
    [Table("cliente")]
    public class ClienteEntity
    {
        [Key]
        [Column("pk_cliente")]
        public int Id { get; set; }

        [Column("razao_social")]
        [StringLength(45)]
        public string RazaoSocial { get; set; }

        [Column("endereco")]
        [StringLength(45)]
        public string Endereco { get; set; }

        [Column("contato")]
        [StringLength(15)]
        public string Contato { get; set; }

        [Column("email")]
        [StringLength(45)]
        public string Email { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }

        [Column("status")]
        public int Status { get; set; }

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
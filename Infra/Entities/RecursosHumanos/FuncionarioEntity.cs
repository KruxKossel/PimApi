using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Financeiro;
using Infra.Entities.Producao;

namespace Infra.Entities.RecursosHumanos
{
    [Table("funcionarios")]
    public class FuncionarioEntity
    {
        [Key]
        [Column("pk_funcionario")]
        [StringLength(45)]
        public string Id { get; set; }

        [Column("nome")]
        [StringLength(45)]
        public string Nome { get; set; }

        [ForeignKey("CargoEntity")]
        [Column("fk_cargo")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }

        [Column("data_adm")]
        public DateTime DataAdmissao { get; set; }

        [Column("data_dem")]
        public DateTime DataDemissao { get; set; }

        [ForeignKey("ProducaoEntity")]
        [Column("producao_pk_producao")]
        public int ProducaoId { get; set; }
        public ProducaoEntity Producao { get; set; }

        [ForeignKey("NotaFiscalVendaEntity")]
        [Column("nota_fiscal_venda_pk_pedido")]
        public int NotaFiscalVendaId { get; set; }
        public NotaFiscalVendaEntity NotaFiscalVenda { get; set; }
    }
}
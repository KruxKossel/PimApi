using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.RecursosHumanos;

namespace Infra.Entities.Financeiro
{
    [Table("pagametos_contas")]
    public class PagamentosContasEntity
    {
        [Key]
        [Column("pk_pagamento")]
        [StringLength(45)]
        public string Id { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("data_vencimento")]
        public DateTime DataVencimento { get; set; }

        [ForeignKey("FuncionarioEntity")]
        [Column("funcionarios_pk_funcionario")]
        [StringLength(45)]
        public string FuncionarioId { get; set; }
        public FuncionarioEntity Funcionario { get; set; }

        [ForeignKey("CargoEntity")]
        [Column("funcionarios_cargos_pk_cargos")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }
    }
}
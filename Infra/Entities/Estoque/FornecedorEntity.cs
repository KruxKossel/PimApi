using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Estoque
{
    [Table("fornecedor")]
    public class FornecedorEntity
    {
        [Key]
        [Column("pk_fornecedor")]
        [StringLength(45)]
        public string Id { get; set; }

        [Column("razao_social")]
        [StringLength(45)]
        public string RazaoSocial { get; set; }

        [Column("cidade")]
        [StringLength(45)]
        public string Cidade { get; set; }

        [Column("endereco")]
        [StringLength(45)]
        public string Endereco { get; set; }

        [Column("email")]
        [StringLength(45)]
        public string Email { get; set; }

        [Column("status")]
        public int Status { get; set; }
    }
}
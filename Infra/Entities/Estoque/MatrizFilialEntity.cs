using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.Estoque
{
    [Table("matriz_filial")]
    public class MatrizFilialEntity
    {
        [Key]
        [Column("pk_empresa")]
        [StringLength(45)]
        public string Id { get; set; }

        [Column("razao_social")]
        [StringLength(45)]
        public string RazaoSocial { get; set; }

        [Column("cidade")]
        [StringLength(45)]
        public string Cidade { get; set; }

        [Column("estado")]
        [StringLength(45)]
        public string Estado { get; set; }

        [Column("endereco")]
        [StringLength(45)]
        public string Endereco { get; set; }

        [Column("numero")]
        public int? Numero { get; set; }

        [Column("data_ini")]
        public DateTime DataInicio { get; set; }
    }
}
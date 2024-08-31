using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Entities.RecursosHumanos
{

    [Table("usuarios")]
    public class UsuarioEntity
    {
        [Key]
        [Column("pk_usuario")]
        public int Id { get; set; }

        [Column("nome")]
        [StringLength(45)]
        public string Nome { get; set; }

        [Column("email")]
        [StringLength(45)]
        public string Email { get; set; }

        [Column("senha")]
        [StringLength(100)]
        public string Senha { get; set; }

        [ForeignKey("NivelAcesso")]
        [Column("nivelAcesso_pk_nivel")]
        public int NivelAcessoId { get; set; }
        public NivelAcessoEntity NivelAcesso { get; set; }

        [ForeignKey("Cargo")]
        [Column("cargos_pk_cargos")]
        public int CargoId { get; set; }
        public CargoEntity Cargo { get; set; }
        
    }
}
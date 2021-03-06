// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Modelos
{
    public partial class TiposEntidades
    {
        public TiposEntidades()
        {
            Entidades = new HashSet<Entidades>();
        }

        [Key]
        [Column("idTipoEntidad")]
        public int IdTipoEntidad { get; set; }
        [Required]
        [StringLength(120)]
        public string Descripcion { get; set; }
        public int? IdGrupoEntidad { get; set; }
        [StringLength(1)]
        public string Comentario { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        public bool? NoEliminable { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey(nameof(IdGrupoEntidad))]
        [InverseProperty(nameof(GruposEntidades.TiposEntidades))]
        public virtual GruposEntidades IdGrupoEntidadNavigation { get; set; }
        [InverseProperty("IdTipoEntidadNavigation")]
        public virtual ICollection<Entidades> Entidades { get; set; }
    }
}
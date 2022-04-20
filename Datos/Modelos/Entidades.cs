using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Datos.Modelos
{
    public partial class Entidades
    {
        [Key]
        [Column("id_Entidad")]
        public int IdEntidad { get; set; }
        [Required]
        [StringLength(120)]
       
        public string Descripcion { get; set; }
        [Required]
        [StringLength(50)]
    
        public string Direccion { get; set; }
        [Required]
        [StringLength(40)]
        
        public string Localidad { get; set; }
        [StringLength(8)]
      
        public string TipoEntidad { get; set; }
        [StringLength(9)]
       
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        [Required]
        [StringLength(60)]
       
        public string Telefonos { get; set; }
        [Required]
        [Column("URLPaginaWeb")]
        [StringLength(120)]
     
        public string UrlpaginaWeb { get; set; }
        [Required]
        [Column("URLFacebook")]
        [StringLength(120)]
       
        public string Urlfacebook { get; set; }
        [Column("URLInstagram")]
        [StringLength(120)]
       
        public string Urlinstagram { get; set; }
        [Column("URLTwitter")]
        [StringLength(120)]
      
        public string Urltwitter { get; set; }
        [Column("URLTikTok")]
        [StringLength(120)]
       
        public string UrltikTok { get; set; }
        public int? IdGrupoEntidad { get; set; }
        public int? IdTipoEntidad { get; set; }
        public int? LimiteCredito { get; set; }
        [Required]
        [StringLength(60)]
        
        public string UserNameEntidad { get; set; }
        [Required]
        [StringLength(30)]
        
        public string PasswordEntidad { get; set; }
        [StringLength(10)]
       
        public string RolUserEntidad { get; set; }
        [StringLength(1)]
        public string Comentario { get; set; }
        [StringLength(10)]
       
        public string Status { get; set; }
        public string NoEliminable { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey(nameof(IdGrupoEntidad))]
        [InverseProperty(nameof(GruposEntidades.Entidades))]
        public virtual GruposEntidades IdGrupoEntidadNavigation { get; set; }
        [ForeignKey(nameof(IdTipoEntidad))]
        [InverseProperty(nameof(TiposEntidades.Entidades))]
        public virtual TiposEntidades IdTipoEntidadNavigation { get; set; }
    }
}
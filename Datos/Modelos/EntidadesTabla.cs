using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class EntidadesTabla
    {
        [Required]
        [StringLength(120)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(40)]
        public string Localidad { get; set; }

        [Required]
        [StringLength(40)]
        public int NumeroDocumento { get; set; }

        [Required]
        [StringLength(60)]
        public string Telefonos { get; set; }
        [Required]
        [StringLength(60)]
        public string UserNameEntidad { get; set; }
    }
}

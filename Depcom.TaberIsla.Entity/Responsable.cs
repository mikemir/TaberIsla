using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Domain
{
    [Table("Responsables")]
    public class Responsable : Entity
    {
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Dui { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono1 { get; set; }
        [Required]
        public string Telefono2 { get; set; }

        //Propiedades de navegación
        public ICollection<Naufrago> Naufragos { get; set; }
    }
}

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
    public class Responsable
    {
        [Key]
        public int Id { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dui { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        //Propiedades de navegación
        public ICollection<Naufrago> Naufragos { get; set; }
    }
}

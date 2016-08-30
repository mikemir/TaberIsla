using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Entity
{
    [Table("Naufragos")]
    public class Naufrago
    {
        [Key]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //Propiedades de navegación
        public ICollection<Medicamento> Medicamentos { get; set; }
        public int ResponsableId { get; set; }
        [ForeignKey("ResponsableId")]
        public Responsable Responsable { get; set; }
    }
}

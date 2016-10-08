using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Domain
{
    [Table("Naufragos")]
    public class Naufrago : Entity
    {
        [Required]
        public int Correlativo { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime FechaNacimiento { get; set; }

        public string Observacion { get; set; }

        //Propiedades de navegación
        public ICollection<Medicamento> Medicamentos { get; set; }
        public int ResponsableId { get; set; }
        [ForeignKey("ResponsableId")]
        public Responsable Responsable { get; set; }
    }
}

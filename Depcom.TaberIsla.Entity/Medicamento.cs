using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Domain
{
    [Table("Medicamentos")]
    public class Medicamento
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Hora { get; set; }

        //Propiedades de navegación
        public int NaufragoId { get; set; }
        [ForeignKey("NaufragoId")]
        public Naufrago Naufrago { get; set; }
    }
}

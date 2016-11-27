using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Domain
{
    public class Baja : Entity
    {
        public int IdNaufrago { get; set; }
        public DateTime? FechaHoraIngreso { get; set; }

        [ForeignKey(nameof(IdNaufrago))]
        public Naufrago Naufrago { get; set; }
    }
}

using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Context
{
    public class DbTaberIslaDataInitializer : DropCreateDatabaseIfModelChanges<DbTaberIslaContext>
    {
        public override void InitializeDatabase(DbTaberIslaContext context)
        {
            base.InitializeDatabase(context);
        }
        protected override void Seed(DbTaberIslaContext context)
        {
            context.Responsables.Add(new Responsable
            {
                Nombres = "Michael Emir",
                Apellidos = "Reynosa Beltrán",
                Direccion = "Col Sta. Ana, Calle Sta. Gabriela",
                Dui = "04663474-0",
                Telefono1 = "2222-2222",
                Telefono2 = "7777-7777",
                Naufragos = new List<Naufrago> {
                    new Naufrago {
                        Nombres = "Lucas Emir",
                        Apellidos = "Reynosa Molina",
                        FechaNacimiento = new DateTime(2020, 08, 11),
                        Medicamentos = new List<Medicamento>{
                            new Medicamento{
                                Nombre = "Modafinil",
                                Dosis = "20mg",
                                Hora = "3:00pm"
                            }
                        }
                    },
                    new Naufrago {
                        Nombres = "Sara Naomi",
                        Apellidos = "Reynosa Molina",
                        FechaNacimiento = new DateTime(2022, 01, 12)
                    }
                }
            });
        }
    }
}

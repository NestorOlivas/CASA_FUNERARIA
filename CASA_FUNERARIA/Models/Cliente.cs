using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA_FUNERARIA.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string EstadoCivil { get; set; }
        public string Hijos { get; set; }
        public double IngresosMensuales { get; set; }
        public double IngresosAcumulables { get; set; }
        public string Plan {  get; set; }
    }
}

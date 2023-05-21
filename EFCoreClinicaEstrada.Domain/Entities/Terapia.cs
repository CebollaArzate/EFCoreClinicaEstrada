using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Domain.Entities
{
    public class Terapia
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Consulta> Consultas { get; set; }

    }
}

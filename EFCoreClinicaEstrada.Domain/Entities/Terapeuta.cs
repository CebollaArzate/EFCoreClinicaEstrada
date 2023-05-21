using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Domain.Entities
{
    public class Terapeuta
    {
        public Guid Id { get; set; }
        public string CedulaProfesional { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string RFC { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Domain.Entities
{
    public class NotaSoap
    {
        public Guid Id { get; set; }
        public string Subjetivo { get; set; } = string.Empty;
        public string Objetivo { get; set; } = string.Empty;
        public string Evaluacion { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty;

    }
}

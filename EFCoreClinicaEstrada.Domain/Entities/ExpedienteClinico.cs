using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Domain.Entities
{
   
    public class ExpedienteClinico
    {
        public ExpedienteClinico()
        {
            this.Consultas = new List<Consulta>();
        }

        public Guid Id { get; set; }
        public Paciente Paciente { get; set; }
        public Guid PacienteId { get; set; }
        public IList<Consulta> Consultas { get; set; }

    }
}

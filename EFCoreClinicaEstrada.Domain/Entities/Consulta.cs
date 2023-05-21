using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Domain.Entities
{
    public class Consulta
    {
        public Guid Id { get; set; }
        public Terapeuta FisioTerapeuta { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime FechaHora { get; set; }
        public string MotivoConsulta { get; set; } = string.Empty;
        public NotaSoap Soap { get; set; }
        public decimal Precio { get; set; }
        public bool ConDescuento { get; set; }
        public bool Realizada { get; set; }
        public float PorcentajeDescuento { get; set; } = 0.285f;
        public List<Terapia> Terapias { get; set; }

    }
}

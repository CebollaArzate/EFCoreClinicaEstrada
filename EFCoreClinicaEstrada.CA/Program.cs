// See https://aka.ms/new-console-template for more information
using EFCoreClinicaEstrada.Data;
using EFCoreClinicaEstrada.Domain.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//AddPaciente2();
AddConsultaToPaciente();



void MostrarConsultaPaciente() 
{


}


void AddPaciente() 
{
    using var db = new FisioEstradaDbContext();

    var p = new Paciente
    {
        Nombre = "Socorro Benavides Martinez",
        Celular = "7331894302",
        FechaAlta = DateTime.Now.AddDays(-2),
        FechaNacimiento = new DateTime(1956, 07, 07),
        Expediente = new ExpedienteClinico()
        
    };

    db.Pacientes.Add(p);
    db.SaveChanges();
    Console.WriteLine("done!!");

}


void AddPaciente2()
{
    using var db = new FisioEstradaDbContext();

    var p = new Paciente
    {
        Nombre = "Diana Hernández Orozco",
        Celular = "7331146152",
        FechaAlta = DateTime.Now,
        FechaNacimiento = new DateTime(1977, 12, 11),
        Expediente = new ExpedienteClinico()

    };

    db.Pacientes.Add(p);
    db.SaveChanges();
    Console.WriteLine("done!!");

}

void AddConsultaToPaciente() 
{
    using var db = new FisioEstradaDbContext();

    var paciente = db.Pacientes.Include(p => p.Expediente).FirstOrDefault(p => p.Celular.Equals("7331146152"));
    var fisio = db.Terapeutas.FirstOrDefault(f => f.Id.Equals(Guid.Parse("4E4DB7DE-5981-48F0-8637-9F0C1E14465B")));

    if (paciente != null && fisio != null)
    {
        paciente.Expediente.Consultas.Add(new Consulta 
        {
            Paciente = paciente,
            FechaHora = DateTime.Now,
            FisioTerapeuta = fisio,
            MotivoConsulta = "Dolor Ligamento Interno de la Rodilla Derecha",
            ConDescuento = true,
            Realizada = true,
            Precio = 350,
            Soap = new NotaSoap
            {

                Subjetivo = "Acude al doctor por dolor en la cara lateral interna de la rodilla lo que imposibilita de realizar sus actividades",
                Objetivo = "1 año de Evolucion",
                Evaluacion = "Irritacion entesis de la pata de ganso por tensión muscular en isquios y aductores de la pierna",
                Plan = "Eva 9 al caminar"
            },
            Terapias = new List<Terapia>
            {
                db.Terapias.FirstOrDefault(t=> t.Nombre.Equals("Bicicleta")),
                db.Terapias.FirstOrDefault(t=> t.Nombre.Equals("Electro Introacticula")),
                db.Terapias.FirstOrDefault(t=> t.Nombre.Equals("Recuperacion Activa"))
            }

        });

        db.SaveChanges();

        Console.WriteLine("done!!");
    }

}
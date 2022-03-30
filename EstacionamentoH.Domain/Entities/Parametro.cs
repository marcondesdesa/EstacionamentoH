using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Parametros")]
    public partial class Parametro
    {
        public int Id { get; set; }
        public bool Dia0 { get; set; }
        public bool Dia1 { get; set; }
        public bool Dia2 { get; set; }
        public bool Dia3 { get; set; }
        public bool Dia4 { get; set; }
        public bool Dia5 { get; set; }
        public bool Dia6 { get; set; }
        public TimeSpan HoraInicial { get; set; }
        public TimeSpan HoraFinal { get; set; }
      
    }
}

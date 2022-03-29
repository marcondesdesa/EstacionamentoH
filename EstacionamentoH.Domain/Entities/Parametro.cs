using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Parametros")]
    public partial class Parametro
    {
        public int Id { get; set; }
        public string DiaLivre { get; set; }
        public TimeSpan HoraInicial { get; set; }
        public TimeSpan HoraFinal { get; set; }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Condutores")]
    public partial class Condutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal SaldoMinuto { get; set; }
        public DateTime DataUltimoLancamento { get; set; }
        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }

        public Condutor()
        {
            Estacionamentos = new HashSet<Estacionamento>();
        }
    }
}

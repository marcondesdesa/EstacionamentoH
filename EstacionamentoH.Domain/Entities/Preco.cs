using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Precos")]
    public partial class Preco
    {
        public int Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal ValorHoraInicial { get; set; }
        public decimal ValorHoraAdicional { get; set; }
        public int Tolerancia { get; set; }
        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }

        public Preco()
        {
            Estacionamentos = new HashSet<Estacionamento>();
        }

    }
}

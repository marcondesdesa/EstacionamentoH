using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Estacionamentos")]
    public partial class Estacionamento
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Condutor Condutor { get; set; }
        public int CondutorId { get; set; }
        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }
        public Preco Preco { get; set; }
        public int PrecoId { get; set; }    

    }
}

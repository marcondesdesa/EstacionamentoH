using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.Domain.Entities
{
    [Table("Veiculos")]
    public partial class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }

        public Veiculo()
        {
            Estacionamentos = new HashSet<Estacionamento>();
        }
    }
}

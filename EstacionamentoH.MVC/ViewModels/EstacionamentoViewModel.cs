using System;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.MVC.ViewModels
{
    public class EstacionamentoViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [DisplayName("Data/Hora de Saída")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataEntrada { get; set; }

        [DisplayName("Data/Hora de Entrada")]
        public DateTime DataSaida { get; set; }

        public Condutor Condutor { get; set; }
        public int CondutorId { get; set; }
        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }
        public Preco Preco { get; set; }
        public int PrecoId { get; set; }
    }
}

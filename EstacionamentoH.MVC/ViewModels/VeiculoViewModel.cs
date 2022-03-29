using System;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstacionamentoH.MVC.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a placa do Veículo")]
        [MaxLength(10, ErrorMessage = "Máximo é {0} caracteres")]
        [MinLength(7, ErrorMessage = "Mínimo é {0} caracteres")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe o modelo do Veículo")]
        [MaxLength(50, ErrorMessage = "Máximo é {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo é {0} caracteres")]
        public string Modelo { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
    }
}

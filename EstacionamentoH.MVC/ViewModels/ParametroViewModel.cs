using System;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EstacionamentoH.MVC.ViewModels
{
    public class ParametroViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Dias da semana livres")]
        [Required(ErrorMessage = "Informe os dias livres")]
        [MaxLength(100, ErrorMessage = "Máximo é {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo é {0} caracteres")]
        public string DiaLivre { get; set; }
        
        [DisplayName("Hora inicial livre")]
        public TimeSpan HoraInicial { get; set; }

        [DisplayName("Hora final livre")]
        public TimeSpan HoraFinal { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
    }
}

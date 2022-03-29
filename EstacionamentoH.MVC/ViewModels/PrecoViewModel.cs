using System;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EstacionamentoH.MVC.ViewModels
{
    public class PrecoViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Vigência Inicial")]
        [Required(ErrorMessage = "Informe a Data Inicial")]
        public DateTime DataInicial { get; set; }

        [DisplayName("Vigência Final")]
        [Required(ErrorMessage = "Informe a Data Final")]        
        public DateTime DataFinal { get; set; }


        [DisplayName("Valor por Hora Inicial")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Informe o Valor Inicial")]
        public decimal ValorHoraInicial { get; set; }

        [DisplayName("Valor por Hora Final")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Informe o Valor Adicional")]
        public decimal ValorHoraAdicional { get; set; }

        [DisplayName("Tolerância (minutos)")]
        [Required(ErrorMessage = "Informe o valor da tolerância (minutos)")]
        public int Tolerancia { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
    }
}

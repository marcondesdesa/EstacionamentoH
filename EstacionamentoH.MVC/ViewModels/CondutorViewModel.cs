using System;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamentoH.MVC.ViewModels
{
    public class CondutorViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [MaxLength(100, ErrorMessage = "Máximo é {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo é {0} caracteres")]
        public string Nome { get; set; }

        [DisplayName("Saldo disponível")]
        public decimal SaldoMinuto { get; set; }

        [DisplayName("Último Lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataUltimoLancamento { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
    }
}

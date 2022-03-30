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

        [DisplayName("Segunda-Feira")]
        public bool Dia1 { get; set; }

        [DisplayName("Terça-Feira")]
        public bool Dia2 { get; set; }

        [DisplayName("Quarta-Feira")]
        public bool Dia3 { get; set; }

        [DisplayName("Quinta-Feira")]
        public bool Dia4 { get; set; }

        [DisplayName("Sexta-Feira")]
        public bool Dia5 { get; set; }

        [DisplayName("Sábado")]
        public bool Dia6 { get; set; }

        [DisplayName("Domingo")]
        public bool Dia0 { get; set; }

        [DisplayName("Hora Livre Inicial")]
        [DataType(DataType.Time)]
        public TimeSpan HoraInicial { get; set; }

        [DisplayName("Hora Livre Final")]
        [DataType(DataType.Time)]
        public TimeSpan HoraFinal { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
    }
}

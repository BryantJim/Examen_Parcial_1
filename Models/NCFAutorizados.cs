using System;
using System.ComponentModel.DataAnnotations;

namespace Examen_Parcial_1.Models
{
    public class NCFAutorizados
    {
        [Key]
        public int NcfId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de NCF")]
        [Range(minimum:1,maximum:int.MaxValue,ErrorMessage="Tipo de NCF debe ser mayor que 0")]
        public int TipoNcfId { get; set; }

        [Required(ErrorMessage = "La Secuencia es obligatoria")]
        [Range(minimum:1,maximum:int.MaxValue,ErrorMessage="La secuencia debe ser mayor que 0")]
        public int Secuencia { get; set; }

        [Required(ErrorMessage = "El Limite es obligatorio")]
        [Range(minimum:1,maximum:int.MaxValue,ErrorMessage="El limite debe ser mayor que 0")]
        public int Limite { get; set; }

        [Required(ErrorMessage = "El Reorden es obligatorio")]
        [Range(minimum:1,maximum:int.MaxValue,ErrorMessage="El Reorden debe ser mayor que 0")]
        public int Reorden { get; set; }

        [Required(ErrorMessage = "La Fecha de vencimiento es obligatoria")]
        public DateTime Vence { get; set; } = DateTime.Now;
    }
}
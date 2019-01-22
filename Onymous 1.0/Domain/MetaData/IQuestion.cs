using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface IQuestion
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(150, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        string Description { get; set; }

        DateTime Date { get; set; }

        bool Answered { get; set; }

        bool Anonymous { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.MetaData
{
    public interface IPerson
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        string FullName { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        [Index("Index_Person_Email", IsUnique = true)]
        string Email { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(15, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        [Index("Index_Person_Mobile", IsUnique = true)]
        string Mobile { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        byte[] Photo { get; set; }
    }
}

using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.MetaData
{
    public interface IUser
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(15, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        [Index("Index_User_UserName", IsUnique = true)]
        string UserName { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        [StringLength(15, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres.")]
        string Password { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El campo {0} debe ser obligatorio.")]
        bool Locked { get; set; }
    }
}

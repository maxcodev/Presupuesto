using System.ComponentModel.DataAnnotations;
using ManejoPresupuesto.Validaciones;

namespace ManejoPresupuesto.Models;

public class TipoCuenta //: IValidatableObject
{
    public int id_tipo_cuenta { get; set; }
    
    [Display(Name = "Nombre de tipo cuenta")]
    [PrimeraLetraMayuscula]
    //[Required(ErrorMessage = "El campo {0} es requerido")]
    //[StringLength(maximumLength:50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
    public string nombre { get; set; }
    
    public int usuario_id { get; set; }
    public int orden { get; set; }
    
    /*[Required(ErrorMessage = "El {0} es requerido")]
    [EmailAddress(ErrorMessage = "Debes introducir un correo electrónico válido")]
    public string Email { get; set; }
    
    [Range(minimum:18, maximum:130, ErrorMessage = "La edad debe estar entre {1} y {2}")]
    public int Edad { get; set; }
    
    [Url(ErrorMessage = "El campo debe tener una URL válida")]
    public string URL { get; set; }
    
    [Display(Name = "Tarjeta de Crédito")]
    [CreditCard(ErrorMessage = "La tarjeta de cŕedito no es válida")]
    public string tarjetaDeCredito { get; set; }*/
    /*public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (nombre != null && nombre.Length > 0)
        {
            yield return new ValidationResult("La primera letra debe ser mayúscula",
                new[] {nameof(nombre)});
        }
    }*/
}


using System.ComponentModel.DataAnnotations;

namespace MgPostal.Models
{
    public class Envio
    {
        public long EnvioId { get; set; }
        
        [Required(ErrorMessage ="Ingrese Remito")]
        public string Remito { get; set; }
        [Required(ErrorMessage ="Ingrese una fecha")]
        public string Fecha { get; set; }


        [Required(ErrorMessage ="Ingrese un Destinatario")]
        public string Destinatario { get; set; }
        [Required(ErrorMessage ="Ingrese una calle")]
        public string Calle { get; set; }
        [Required(ErrorMessage ="Ingrese el número de la calle")]
        public string NumeroCalle { get; set; }
        public string Piso { get; set; }
        [Required(ErrorMessage ="Ingrese Localidad Destino")]
        public string Localidad_Destino { get; set; }


        [Required(ErrorMessage ="Ingrese Remitente")]
        public string Remitente { get; set; }
        [Required(ErrorMessage ="Ingrese dirección del remitente")]
        public string Direccion_Remitente { get; set; }

        [Required(ErrorMessage ="Ingrese una forma de pago")]
        public string Forma_Pago { get; set; }
        [Required(ErrorMessage ="Ingrese la cantidad de Bultos")]
        public int Bultos { get; set; }
        public decimal Valor_Declarado { get; set; }

        public string Observaciones { get; set; }
    }
}

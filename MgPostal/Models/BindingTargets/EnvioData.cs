using System.ComponentModel.DataAnnotations;


namespace MgPostal.Models.BindingTargets
{
    public class EnvioData
    {

        public Envio Envio { get; set; } = new Envio();
       

        [Required(ErrorMessage = "Ingrese Remito")]
        public string Remito { get => Envio.Remito ; set=> Envio.Remito = value; }
        [Required(ErrorMessage = "Ingrese una fecha")]
        public string Fecha { get=> Envio.Fecha; set=> Envio.Fecha = value; }


        [Required(ErrorMessage = "Ingrese un Destinatario")]
        public string Destinatario { get => Envio.Destinatario; set => Envio.Destinatario = value; }
        [Required(ErrorMessage = "Ingrese una calle")]
        public string Calle { get => Envio.Calle; set=> Envio.Calle = value; }
        [Required(ErrorMessage = "Ingrese el número de la calle")]
        public string NumeroCalle { get=> Envio.NumeroCalle; set=> Envio.NumeroCalle = value; }
        public string Piso { get => Envio.Piso; set=> Envio.Piso= value; }
        [Required(ErrorMessage = "Ingrese Localidad Destino")]
        public string Localidad_Destino { get=> Envio.Localidad_Destino; set=> Envio.Localidad_Destino=value; }


        [Required(ErrorMessage = "Ingrese Remitente")]
        public string Remitente { get=> Envio.Remitente; set=> Envio.Remitente =value; }
        [Required(ErrorMessage = "Ingrese dirección del remitente")]
        public string Direccion_Remitente { get => Envio.Direccion_Remitente; set => Envio.Direccion_Remitente = value; }

        [Required(ErrorMessage = "Ingrese una forma de pago")]
        public string Forma_Pago { get => Envio.Forma_Pago; set=> Envio.Forma_Pago =value; }
        [Required(ErrorMessage = "Ingrese la cantidad de Bultos")]
        public int Bultos { get=> Envio.Bultos; set=> Envio.Bultos = value; }
        public decimal Valor_Declarado { get=> Envio.Valor_Declarado; set=> Envio.Valor_Declarado= value; }

        public string Observaciones { get=> Envio.Observaciones; set=> Envio.Observaciones = value; }
    }
}

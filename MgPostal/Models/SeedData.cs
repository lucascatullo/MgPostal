using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MgPostal.Models
{
    public class SeedData
    {
        public static void SeedDataBase (DataContext context)
        {
            context.Database.Migrate();
            if(context.Envios.Count() == 0)
            {
                context.Envios.AddRange(
                  new Envio {
                      Remito ="4184",
                      Fecha ="19/04/19",
                      Destinatario ="Lucas Catullo",
                      Calle="Lamadrid",
                      NumeroCalle ="2340",
                      Piso ="5n",
                      Localidad_Destino ="Mar del plata",
                      Remitente ="Cris",
                      Direccion_Remitente="58 y por ahí",
                      Forma_Pago ="bonos YEAH!",
                      Bultos =5,
                      Valor_Declarado = 5.25m,
                      Observaciones="Espero que sea algo lindo =("},  
                  new Envio {
                      Remito ="5183",
                      Fecha ="26/04/19",
                      Destinatario ="Cris",
                      Calle="Lamadrid",
                      NumeroCalle ="2340",
                      Piso ="5n",
                      Localidad_Destino ="Neco",
                      Remitente ="Cris",
                      Direccion_Remitente="Mar dle plata por ahí",
                      Forma_Pago ="Pesos Efectivo =(",
                      Bultos =3
                      ,Valor_Declarado= 0.75m,
                      Observaciones="Cucas"}
                    
                );
                context.SaveChanges();
            }
        }
    }
}

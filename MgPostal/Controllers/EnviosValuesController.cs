using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MgPostal.Models;
using MgPostal.Models.BindingTargets;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Cors;

namespace MgPostal.Controllers
{
    [Route("/api/envios")]
    public class EnviosValuesController : Controller
    {

        DataContext context;

        public EnviosValuesController(DataContext ctx)
        {
            this.context = ctx;
        }


        [HttpGet]
        public IQueryable<Envio> GetEnvios()
        {
            return context.Envios.OrderBy(e => e.Fecha);
        }

        [HttpPatch("{id}")]
        public IActionResult ActualizarEnvio(long id,[FromBody]
        JsonPatchDocument<EnvioData> edata)
        {
            Envio envio = this.context.Envios.First(e => e.EnvioId == id);
            EnvioData enviodata = new EnvioData { Envio = envio };
            edata.ApplyTo(enviodata, ModelState);
            if(ModelState.IsValid && TryValidateModel(enviodata))
            {
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        

        


        [HttpDelete("{id}")]
        public void DeleteEnvio(long id)
        {
            context.Envios.Remove(new Envio { EnvioId = id });
            context.SaveChanges();
        }

        [HttpPost]
        public IActionResult CrearEnvio([FromBody] EnvioData env)
        {
            if (ModelState.IsValid)
            {
                Envio envio = env.Envio;
                context.Add(envio);
                context.SaveChanges();
                return Ok(envio.EnvioId);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public Envio GetEnvio(long id)
        {
            return context.Envios.First(e => e.EnvioId == id);
        }
    }
}

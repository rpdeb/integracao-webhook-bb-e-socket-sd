using ApiPixBB.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPixBB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        
        [HttpGet("recebimento")]
        public string Get(
            ReceberPix receberPix)
        {
            return "Pix Recebido";
        }

        [HttpPost("envio")]
        public string Post(
           ReceberPix receberPix)
        {
            return "Pix Enviado";
        }
    }
}

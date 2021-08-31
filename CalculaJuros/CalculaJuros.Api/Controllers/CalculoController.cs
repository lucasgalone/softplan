using CalculaJuros.Application.Model;
using CalculaJuros.Application.Service;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly CalculoService service;
        public CalculoController(CalculoService service)
        {
            this.service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, "Calculo efetuada com sucesso", typeof(double))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Algum erro ocorreu relacionado aos dados da requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Erro inesperado", typeof(string))]
        [HttpPost("calculajuros")]
        public async Task<IActionResult> Calcular([FromBody] CalculoModel model, CancellationToken ct)
        {
            var res = await service.Calcular(model, ct);
            return Ok(res);
        }
    }
}

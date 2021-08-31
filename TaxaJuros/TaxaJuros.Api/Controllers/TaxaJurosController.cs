using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using TaxaJuros.Application.Service;
using TaxaJuros.Domain.Entities;

namespace TaxaJuros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly TaxaJurosService service;

        public TaxaJurosController(TaxaJurosService service)
        {
            this.service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, "Busca efetuada com sucesso", typeof(double))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Algum erro ocorreu relacionado aos dados da requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Erro inesperado", typeof(string))]
        [HttpGet]
        public async Task<IActionResult> ObterTaxaJuros(CancellationToken ct)
        {
            var res = await service.ObterTaxaJuros(ct);
            return Ok(res);
        }
    }
}

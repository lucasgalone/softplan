using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowCodeController : ControllerBase
    {

        [HttpGet("showmethecode")]
        public async Task<IActionResult> Showmethecode()
        {
            return Ok("https://github.com/lucasgalone/softplan");
        }
    }
}

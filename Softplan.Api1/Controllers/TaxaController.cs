using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.Service.Dtos;
using Softplan.Service.Interfaces;

namespace Softplan.Api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaController : ControllerBase
    {
        private readonly ILogger<TaxaController> _logger;

        private readonly ISoftplanService _service;

        public TaxaController(ILogger<TaxaController> logger, ISoftplanService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public TaxaJurosDto Get()
        {
            TaxaJurosDto dto = new TaxaJurosDto();
            dto.Valor = 100;
            var service = _service.TaxaJuros(dto);
            return service;
        }
    }
}

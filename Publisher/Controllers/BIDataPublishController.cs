using Infrastructure;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Publisher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BIDataPublishController : ControllerBase
    {

        private readonly ILogger<BIDataPublishController> _logger;
        private readonly IBus _bus;

        public BIDataPublishController(ILogger<BIDataPublishController> logger, IBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> SendData(BIDataModel biDataModel)
        {
            if (biDataModel is not null)
            {
                //Uri uri = new Uri(Constants.RabbitMqUri);
                //var endPoint = await _bus.GetSendEndpoint(uri);
                //await endPoint.Send(biDataModel);
                Uri uri = new Uri(Constants.RabbitMqUri);
                var endPoint = await _bus.GetPublishSendEndpoint<BIDataModel>();
                await endPoint.Send(biDataModel);
                return Ok();
            }
            return BadRequest();
        }
    }
}

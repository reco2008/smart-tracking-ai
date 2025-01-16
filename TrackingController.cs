using Microsoft.AspNetCore.Mvc;
using SmartTrackingAI.Services;

namespace SmartTrackingAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private readonly ProtocolProcessor _protocolProcessor;
        private readonly ProtocolDataService _protocolDataService;

        public TrackingController(ProtocolProcessor protocolProcessor, ProtocolDataService protocolDataService)
        {
            _protocolProcessor = protocolProcessor;
            _protocolDataService = protocolDataService;
        }

        [HttpPost]
        public async Task<IActionResult> ReceiveData([FromQuery] string protocol, [FromBody] byte[] message)
        {
            _protocolProcessor.ProcessMessage(protocol, message);
            var data = _protocolProcessor.GetParsedData();
            await _protocolDataService.SaveDataAsync(data);
            return Ok();
        }
    }
}

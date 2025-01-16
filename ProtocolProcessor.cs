namespace SmartTrackingAI.Services
{
    public class ProtocolProcessor
    {
        private readonly Dictionary<string, IProtocolHandler> _protocolHandlers;

        public ProtocolProcessor()
        {
            _protocolHandlers = new Dictionary<string, IProtocolHandler>
            {
                { "Teltonika", new TeltonikaProtocolHandler() },
                { "Iconcox", new IconcoxProtocolHandler() }
            };
        }

        public void ProcessMessage(string protocol, byte[] message)
        {
            if (_protocolHandlers.ContainsKey(protocol))
            {
                var handler = _protocolHandlers[protocol];
                handler.ParseMessage(message);
                var data = handler.GetParsedData();
                // إرسال البيانات المحللة إلى قاعدة البيانات أو لإجراء مزيد من المعالجة
            }
        }
    }
}

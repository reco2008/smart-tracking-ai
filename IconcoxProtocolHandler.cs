namespace SmartTrackingAI.ProtocolHandlers
{
    public class IconcoxProtocolHandler : IProtocolHandler
    {
        private Dictionary<string, object> parsedData;

        public IconcoxProtocolHandler()
        {
            parsedData = new Dictionary<string, object>();
        }

        public void ParseMessage(byte[] message)
        {
            // هنا نقوم بتحليل الرسالة بناءً على البروتوكول الخاص بجهاز Iconcox
        }

        public Dictionary<string, object> GetParsedData()
        {
            return parsedData;
        }

        public void HandleEvent(string eventName, object data)
        {
            // التعامل مع الأحداث مثل تجاوز السرعة أو حالات أخرى
        }
    }
}

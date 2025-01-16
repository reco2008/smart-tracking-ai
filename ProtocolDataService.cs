namespace SmartTrackingAI.Services
{
    public class ProtocolDataService
    {
        private readonly TrackingDbContext _context;

        public ProtocolDataService(TrackingDbContext context)
        {
            _context = context;
        }

        public async Task SaveDataAsync(Dictionary<string, object> data)
        {
            var protocolData = data.Select(entry => new ProtocolData
            {
                FieldName = entry.Key,
                FieldValue = entry.Value.ToString()
            }).ToList();

            _context.ProtocolData.AddRange(protocolData);
            await _context.SaveChangesAsync();
        }
    }
}

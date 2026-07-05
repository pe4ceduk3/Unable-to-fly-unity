using Interfaces.Data;

namespace Components.Data
{
    public class BallisticsData : IBallisticsData
    {
        public float Peak { get; set; }
        public float Duration { get; set; }
    }
}
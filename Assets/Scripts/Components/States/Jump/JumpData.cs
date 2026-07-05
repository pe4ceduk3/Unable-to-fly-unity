using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class JumpStateData : MonoBehaviour,
        ISpeedData,
        IBallisticsData
    {
        public float Speed { get; set; } = 100.0f;
        
        // ballistics
        public float Peak { get; set; } = 1000.0f;
        public float Duration { get; set; } = 0.3f;
    }
}

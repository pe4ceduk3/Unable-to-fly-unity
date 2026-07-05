using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class BallisticsData : MonoBehaviour, IBallisticsData
    {
        [field: SerializeField] public float Peak { get; set; }
        [field: SerializeField] public float Duration { get; set; } 
    }
}
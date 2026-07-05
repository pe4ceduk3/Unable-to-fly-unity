using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class SpeedData : MonoBehaviour, ISpeedData
    {
        [field: SerializeField] public float Speed { get; set; } = 0.0f;
    }
}
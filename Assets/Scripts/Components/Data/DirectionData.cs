using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class DirectionData : MonoBehaviour, IDirectionData
    {
        [field: SerializeField] public float Direction { get; set; } = 0.0f;
    }
}
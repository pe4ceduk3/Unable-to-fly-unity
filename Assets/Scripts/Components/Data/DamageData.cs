using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class DamageData : MonoBehaviour, IDamageData
    {
        [field: SerializeField] public float Damage { get; set; } = 0.0f;
    }
}
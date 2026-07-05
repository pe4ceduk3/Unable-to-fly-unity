using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class SurfaceData : MonoBehaviour, ISurfaceData
    {
        [field: SerializeField] public Transform Checker { get; set; }
        [field: SerializeField] public float Radius { get; set; }
        [field: SerializeField] public LayerMask WhatIsSurface { get; set; }
    }
}
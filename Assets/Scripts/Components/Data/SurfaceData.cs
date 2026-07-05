using Interfaces.Data;
using UnityEngine;

namespace Components.Data
{
    public class SurfaceData : ISurfaceData
    {
        public Transform Checker { get; set; }
        public float Radius { get; set; }
        public LayerMask WhatIsSurface { get; set; }
    }
}
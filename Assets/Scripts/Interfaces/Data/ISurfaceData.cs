using UnityEngine;

namespace Interfaces.Data
{
    public interface ISurfaceData
    {
        public Transform Checker { get; set; }
        public float Radius { get; set; }
        public LayerMask WhatIsSurface { get; set; }
    }
}
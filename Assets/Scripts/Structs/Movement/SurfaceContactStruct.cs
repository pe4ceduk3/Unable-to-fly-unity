using System;
using UnityEngine;
namespace Structs.Movement
{
    [Serializable]
    public struct SurfaceContactStruct
    {
        public Transform surfaceChecker;
        public LayerMask whatIsSurface;
        public float surfaceCheckRadius;
    } 
}
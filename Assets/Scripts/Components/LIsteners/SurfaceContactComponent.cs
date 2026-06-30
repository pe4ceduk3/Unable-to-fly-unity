using UnityEngine;
using Interfaces.Listeners;
using Interfaces.Data;
namespace Components.Listeners
{
    public class SurfaceContactComponent : MonoBehaviour, ISurfaceContact
    {
        public bool HasSurface(ISurfaceData data)
        {
            return Physics2D.OverlapCircle(data.Checker.position, data.Radius, data.WhatIsSurface);
        }
        public void DrawDebug(ISurfaceData data, Color color)
        {
            Gizmos.color = color;
            Gizmos.DrawWireSphere(data.Checker.position, data.Radius);
        }
    }
}
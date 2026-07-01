using System;
using UnityEngine;
using Interfaces.Listeners;
using Interfaces.Data;

namespace Components.Listeners
{
    [Serializable]
    public class SurfaceCheckerComponent : MonoBehaviour, ISurfaceChecker
    { 
        public void HasSurface(ISurfaceData data, ref ISurfaceContactData contactData)
        {
            contactData.IsContact = Physics2D.OverlapCircle(data.Checker.position, data.Radius, data.WhatIsSurface);
        }
        public void DrawDebug(ISurfaceData data, Color color)
        {
            Gizmos.color = color;
            Gizmos.DrawWireSphere(data.Checker.position, data.Radius);
        }
    }
}
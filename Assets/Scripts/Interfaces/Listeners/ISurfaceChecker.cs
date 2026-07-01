using UnityEngine;
using Interfaces.Data;
namespace Interfaces.Listeners
{
    public interface ISurfaceChecker
    {
       void HasSurface(ISurfaceData data, ref ISurfaceContactData contactData);
       void DrawDebug(ISurfaceData data, Color color);
    }
}
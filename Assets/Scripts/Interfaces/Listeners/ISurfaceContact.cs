using UnityEngine;
using Interfaces.Data;
namespace Interfaces.Listeners
{
    public interface ISurfaceContact
    {
       bool HasSurface(ISurfaceData data);
       void DrawDebug(ISurfaceData data, Color color);
    }
}
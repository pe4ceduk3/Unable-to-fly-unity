using UnityEngine;
using Interfaces.Data;
namespace Interfaces.Listeners
{
    public interface ISurfaceContact
    {
       bool CheckContact(ISurfaceData data);
       void DrawDebug(ISurfaceData data, Color color);
    }
}
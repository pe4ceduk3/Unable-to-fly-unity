using Structs.Movement;
using UnityEngine;
namespace Interfaces.Listeners
{
    public interface ISurfaceContact
    {
       bool CheckContact(SurfaceContactStruct data);
       void DrawDebug(SurfaceContactStruct data, Color color);
    }
}
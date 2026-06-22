using Structs.Movement;
using UnityEngine;
namespace Interfaces.Movement
{
    public interface ISurfaceContact
    {
        bool CheckContact(SurfaceContactStruct data);
        void DrawGizmos(SurfaceContactStruct data, Color color);
    }
}
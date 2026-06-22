using UnityEngine;
using Interfaces.Movement;
using Structs.Movement;
namespace Components.Listeners
{
    public class SurfaceContactComponent : MonoBehaviour, ISurfaceContact
    {
        public bool CheckContact(SurfaceContactStruct data)
        {
            return Physics2D.OverlapCircle(data.surfaceChecker.position, data.surfaceCheckRadius, data.whatIsSurface);
        }
        public void DrawGizmos(SurfaceContactStruct data, Color color)
        {
            Gizmos.color = color;
            Gizmos.DrawWireSphere(data.surfaceChecker.position, data.surfaceCheckRadius);
        }
    }
}
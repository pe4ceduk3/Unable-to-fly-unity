using Structs.Movement;
using UnityEngine;

namespace Interfaces.Movement
{
   public interface IGravityAffected
    {
        void ApplyGravity(GravityStruct data, Rigidbody2D body);
        void StopGravity(GravityStruct data, Rigidbody2D body);
    }
}

using UnityEngine;
using Interfaces.Data;

namespace Interfaces.Movement
{
   public interface IGravityAffected
    {
        void ApplyGravity(IGravityData data, Rigidbody2D body);
        void StopGravity(IGravityData data, Rigidbody2D body);
    }
}

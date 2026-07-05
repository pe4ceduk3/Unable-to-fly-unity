using UnityEngine;
using Interfaces.Data;

namespace Interfaces.Movement 
{
    public interface IBallisticsProcessor
    {
        void SetStartVelocity(IBallisticsData data, Rigidbody2D body);
        void ApplyGravity(IBallisticsData ballisticsData, Rigidbody2D body);
    }
}

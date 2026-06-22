using Structs.Movement;
using UnityEngine;

namespace Interfaces.Movement 
{
    public interface IBallisticsProcessor
    {
        void SetStartVelocity(BallisticsProcessorStruct data, Rigidbody2D body);
        void ApplyGravity(BallisticsProcessorStruct data, Rigidbody2D body);
    }
}

using UnityEngine;
using Structs.Movement;
namespace Interfaces.Movement
{
    public interface IAccelerationProfiler
    {
        void Accelerate(ref MotionProfilerStruct data, Rigidbody2D body);
    }
}
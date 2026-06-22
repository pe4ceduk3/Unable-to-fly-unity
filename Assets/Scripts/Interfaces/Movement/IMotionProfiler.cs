using UnityEngine;
using Structs.Movement;
namespace Interfaces.Movement
{
    public interface IMotionProfiler
    {
        void Accelerate(ref MotionProfilerStruct data, Rigidbody2D body);
        //void Decelerate(ref MotionProfilerStruct data, Rigidbody2D body);
        void LinearMove(ref MotionProfilerStruct data, Rigidbody2D body);
    }
}
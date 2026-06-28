using UnityEngine;
using Interfaces.Data;
namespace Interfaces.Movement
{
    public interface IAccelerationProfiler
    {
        void Accelerate(IAccelerationData accel, ISpeedData spd, IDirectionData dir, Rigidbody2D body);
    }
}
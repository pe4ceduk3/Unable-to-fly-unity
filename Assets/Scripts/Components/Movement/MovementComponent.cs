using Interfaces.Data;
using UnityEngine;
using Interfaces.Movement;
using Structs.Movement;

namespace Components.Movement
{
    public class MovementComponent : MonoBehaviour, IAccelerationProfiler, ILinearMovement
    {
        public void Accelerate(ref MotionProfilerStruct data, Rigidbody2D body)
        {
            float time = data.currentTime / data.accelerationDuration;
            float easyInTime = time * time;
            data.currentSpeed = data.targetSpeed * easyInTime * data.direction;
            body.linearVelocity = new Vector2(data.currentSpeed, body.linearVelocity.y);
        }
        public void ApplyLinearSpeed(ISpeedData spd, IDirectionData dir, Rigidbody2D body)
        {
            float velocityX = spd.Speed * dir.Direction * Time.fixedDeltaTime;
            body.linearVelocity = new Vector2(velocityX, body.linearVelocity.y);
        }
    }
}
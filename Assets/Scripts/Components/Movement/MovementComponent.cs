using Interfaces.Data;
using UnityEngine;
using Interfaces.Movement;
using Interfaces.Data;

namespace Components.Movement
{
    public class MovementComponent : MonoBehaviour, IAccelerationProfiler, ILinearMovement
    {
        public void Accelerate(IAccelerationData accel, ISpeedData spd, IDirectionData dir, Rigidbody2D body)
        {
            float time = accel.CurrentTime / accel.AccelerationDuration;
            float easyInTime = time * time;
            accel.CurrentSpeed = spd.Speed * easyInTime * dir.Direction;
            body.linearVelocity = new Vector2(accel.CurrentSpeed, body.linearVelocity.y);
        }
        public void ApplyLinearSpeed(ISpeedData spd, IDirectionData dir, Rigidbody2D body)
        {
            float velocityX = spd.Speed * dir.Direction * Time.fixedDeltaTime;
            body.linearVelocity = new Vector2(velocityX, body.linearVelocity.y);
        }
    }
}
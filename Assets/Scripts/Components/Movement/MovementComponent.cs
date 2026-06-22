using UnityEngine;
using Interfaces.Movement;
using Structs.Movement;

namespace Components.Movement
{
    public class MovementComponent : MonoBehaviour, IMotionProfiler
    {
        public void Accelerate(ref MotionProfilerStruct data, Rigidbody2D body)
        {
            float time = data.currentTime / data.accelerationDuration;
            float easyInTime = time * time;
            data.currentSpeed = data.targetSpeed * easyInTime * data.direction;
            body.linearVelocity = new Vector2(data.currentSpeed, body.linearVelocity.y);
        }
        public void LinearMove(ref MotionProfilerStruct data, Rigidbody2D body)
        {
            float velocityX = data.targetSpeed * data.direction * Time.fixedDeltaTime;
            body.linearVelocity = new Vector2(velocityX, body.linearVelocity.y);
        }
    }
}
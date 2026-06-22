using UnityEngine;
using Interfaces.Movement;
using Structs.Movement;
namespace Components.Movement
{
    public class BallisticsProcessorComponent : MonoBehaviour, IBallisticsProcessor
    {
        public void SetStartVelocity(BallisticsProcessorStruct data, Rigidbody2D body)
        {
            float velocityY = (2.0f * data.peak) / data.duration;
            body.linearVelocity = new Vector2(body.linearVelocity.x, velocityY);
        }
        public void ApplyGravity(BallisticsProcessorStruct data, Rigidbody2D body)
        {
            float gravityAcceleration = (-2.0f * data.peak) / (data.duration * data.duration);
            float velocityY = gravityAcceleration * Time.fixedDeltaTime;
            if (data.maxGravity < velocityY) velocityY = data.maxGravity;
            body.linearVelocity += new Vector2(body.linearVelocity.x, velocityY);
        }
    }
}
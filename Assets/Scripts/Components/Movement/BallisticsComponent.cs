using UnityEngine;
using Interfaces.Movement;
using Interfaces.Data;

namespace Components.Movement
{
    public class BallisticsComponent : MonoBehaviour, IBallisticsProcessor
    {
        public void SetStartVelocity(IBallisticsData data, Rigidbody2D body)
        {
            float velocityY = (2.0f * data.Peak) / data.Duration;
            body.linearVelocity = new Vector2(body.linearVelocity.x, velocityY);
        }
        public void ApplyGravity(IBallisticsData data, IGravityData gravityData, Rigidbody2D body)
        {
            float gravity = (-2.0f * data.Peak) / (data.Duration * data.Duration);
            float velocityY = gravity * Time.fixedDeltaTime;
            if (gravity > gravityData.MaxGravity) gravity = gravityData.MaxGravity;
            body.linearVelocity += new Vector2(body.linearVelocity.x, velocityY);
        }
    }
}
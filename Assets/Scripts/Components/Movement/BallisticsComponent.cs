using UnityEngine;
using Interfaces.Movement;
using Interfaces.Data;

namespace Components.Movement
{
    public class BallisticsComponent : MonoBehaviour, IBallisticsProcessor
    {
        public void SetStartVelocity(IBallisticsData data, Rigidbody2D body)
        {
            float velocityY = (2.0f * data.Peak) / data.Duration * Time.fixedDeltaTime;
            body.linearVelocity = new Vector2(body.linearVelocity.x, velocityY);
        }
        public void ApplyGravity(IBallisticsData data, Rigidbody2D body)
        {
            float gravity = (-2.0f * data.Peak) / (data.Duration * data.Duration) * Time.fixedDeltaTime;
            body.linearVelocity += new Vector2(body.linearVelocity.x, gravity);
        }
    }
}
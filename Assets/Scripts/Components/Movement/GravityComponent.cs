using Interfaces.Movement;
using UnityEngine;
using Interfaces.Data;

namespace Components.Movement
{
    public class GravityComponent : MonoBehaviour, IGravityAffected
    { 
        public void ApplyGravity(IGravityData data, Rigidbody2D body)
        {
            float gravity = body.linearVelocity.y - (data.Gravity * Time.fixedDeltaTime);
            body.linearVelocity = new Vector2(body.linearVelocity.x, gravity);

            if (body.linearVelocity.y < data.MaxGravity) return;
            body.linearVelocity = new Vector2(body.linearVelocity.x, data.MaxGravity);
        }
        public void StopGravity(IGravityData data, Rigidbody2D body)
        {
            if (body.linearVelocity.y > 0.0f) return;
            body.linearVelocity = new Vector2(body.linearVelocity.x, 0);
        }
    }
}

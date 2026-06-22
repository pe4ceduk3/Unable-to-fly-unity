using Interfaces.Movement;
using Structs.Movement;
using UnityEngine;

namespace Components.Movement
{
    public class GravityComponent : MonoBehaviour, IGravityAffected
    { 
        public void ApplyGravity(GravityStruct data, Rigidbody2D body)
        {
            float gravity = body.linearVelocity.y - (data.gravity * Time.fixedDeltaTime);
            body.linearVelocity = new Vector2(body.linearVelocity.x, gravity);
        }
        public void StopGravity(GravityStruct data, Rigidbody2D body)
        {
            if (body.linearVelocity.y > 0.0f) return;
            body.linearVelocity = new Vector2(body.linearVelocity.x, 0);
            if (body.linearVelocity.y < data.maxGravity) return;
            body.linearVelocity = new Vector2(body.linearVelocity.x, data.maxGravity);
        }
    }
}

using Interfaces.Data;
using UnityEngine;

namespace Interfaces.Movement
{
    public interface ILinearMovement
    {
        void ApplyLinearSpeed(ISpeedData speedData, IDirectionData directionData, Rigidbody2D rigidbody);
    }
}
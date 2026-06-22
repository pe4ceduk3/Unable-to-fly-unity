using System;
namespace Structs.Movement
{
    [Serializable]
    public struct MotionProfilerStruct
    {
        public float targetSpeed;
        public float accelerationDuration;
        public float direction;
        public float currentSpeed;
        public float currentTime;
    }
}

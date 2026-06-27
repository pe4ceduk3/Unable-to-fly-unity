namespace Objects.Characters
{
    public struct SurfaceStates
    {
        public enum States
        {
            OnGround,
            OnWall,
            OnAir
        }
        public States CurrentState;
        public SurfaceStates(States currentState = States.OnAir)
        {
            CurrentState = currentState;
        }
    }
}
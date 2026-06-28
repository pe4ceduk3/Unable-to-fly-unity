namespace Interfaces.Data
{
    public interface IAccelerationData
    {
        float AccelerationDuration { get; set; }
        float CurrentSpeed { get; set; }
        float CurrentTime { get; set; }
    }
}
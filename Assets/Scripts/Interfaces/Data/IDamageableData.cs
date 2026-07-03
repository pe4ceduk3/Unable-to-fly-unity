namespace Interfaces.Data
{
    public interface IDamageable
    {
        float Damage { get; set; }
        float Health { get; set; }
        float MaxHealth { get; set; }
    }
}
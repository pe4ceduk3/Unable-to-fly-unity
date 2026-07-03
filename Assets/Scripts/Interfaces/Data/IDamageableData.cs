namespace Interfaces.Data
{
    public interface IDamageable
    {
        bool CanTakeDamage { get; set; }
        float Damage { get; set; }
        float Health { get; set; }
        float MaxHealth { get; set; }
    }
}
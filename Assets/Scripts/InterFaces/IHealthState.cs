namespace InterFaces
{
    public interface IHealthState
    {
        void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType);
    }
}

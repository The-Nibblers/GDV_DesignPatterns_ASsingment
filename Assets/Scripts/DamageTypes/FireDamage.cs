using InterFaces;
using UnityEngine;

public class FireDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy, int damage)
    {
        enemy.TakeDamage(damage, DamageTypes.Fire);
    }
}

using InterFaces;
using UnityEngine;

public class CorrosionDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy, int damage)
    {
        enemy.TakeDamage(damage, DamageTypes.Corrosion);
        Debug.Log("Corrosion Damage Applied");
    }
}

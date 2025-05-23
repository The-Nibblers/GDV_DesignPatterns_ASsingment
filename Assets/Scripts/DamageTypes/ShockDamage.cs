using InterFaces;
using UnityEngine;

public class ShockDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy, int damage)
    {
        enemy.TakeDamage(damage, DamageTypes.Shock);
        Debug.Log("Shock Damage Applied");
        //Apply Corrosion Status effect, different animations, particles etc
    }
}

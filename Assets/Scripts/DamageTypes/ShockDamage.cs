using InterFaces;
using UnityEngine;

public class ShockDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        enemy.TakeDamage(30, DamageTypes.Shock);
        Debug.Log("Deal Shock Damage");
    }
}

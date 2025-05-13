using InterFaces;
using UnityEngine;

public class FireDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        enemy.TakeDamage(30, DamageTypes.Fire);
        Debug.Log("Deal Fire Damage");
    }
}

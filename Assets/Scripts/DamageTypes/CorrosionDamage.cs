using InterFaces;
using UnityEngine;

public class CorrosionDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        enemy.TakeDamage(30, DamageTypes.Corrosion);
        Debug.Log("Deal Corrosion Damage");
    }
}

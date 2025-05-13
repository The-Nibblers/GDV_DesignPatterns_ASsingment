using InterFaces;
using UnityEngine;

public class ShockDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        enemy.TakeDamage(30);
        Debug.Log("Deal Shock Damage");
    }
}

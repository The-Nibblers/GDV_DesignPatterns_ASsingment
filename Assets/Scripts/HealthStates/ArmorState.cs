using System;
using InterFaces;
using UnityEditor.Timeline;
using UnityEngine;

public class ArmorState : IHealthState
{
    private float CorrosionDamageModifier = 1.2f;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        if (damageType == DamageTypes.Corrosion)
        {
            float floatAmount = amount;
            floatAmount *= CorrosionDamageModifier;
            amount = (int)floatAmount;
        }
        enemyHealth.armor -= amount;
        Debug.Log("armor damage, " + amount);
        if (enemyHealth.armor <= 0)
        {
            enemyHealth.setState(new HealthState());
        }
    }
}

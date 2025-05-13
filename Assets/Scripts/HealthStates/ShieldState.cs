using InterFaces;
using UnityEngine;

public class ShieldState : IHealthState
{
    private float shieldDamageModifier = 1.2f;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        if (damageType == DamageTypes.Shock)
        {
            float floatAmount = amount;
            floatAmount *= shieldDamageModifier;
            amount = (int)floatAmount;
        }
        enemyHealth.shield -= amount;
        Debug.Log("shield damage, " + amount);
        if (enemyHealth.shield <= 0)
        {
            enemyHealth.setState(new ArmorState());
        }
    }
}

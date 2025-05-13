using InterFaces;
using UnityEngine;

public class HealthState : IHealthState
{
    private float fireDamageModifier = 1.2f;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        if (damageType == DamageTypes.Fire)
        {
            float floatAmount = amount;
            floatAmount *= fireDamageModifier;
            amount = (int)floatAmount;
        }
        enemyHealth.health -= amount;
        Debug.Log("health damage, " + amount);
        if (enemyHealth.health <= 0)
        {
            enemyHealth.setState(new DeadState());
        }
    }
}

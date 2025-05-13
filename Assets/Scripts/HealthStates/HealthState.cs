using InterFaces;
using UnityEngine;

public class HealthState : IHealthState
{
    private float DamageModifier;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        switch (damageType)
        {
            case DamageTypes.Fire:
                DamageModifier = 1.2f;
                break;
            case DamageTypes.Shock:
                DamageModifier = 0.9f;
                break;
            case DamageTypes.Corrosion:
                DamageModifier = 0.8f;
                break;
        }
        
        float floatAmount = amount;
        floatAmount *= DamageModifier;
        amount = (int)floatAmount;
        
        enemyHealth.health -= amount;
        Debug.Log("health damage, " + amount);
        if (enemyHealth.health <= 0)
        {
            enemyHealth.setState(new DeadState());
        }
    }
}

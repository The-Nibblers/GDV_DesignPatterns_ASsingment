using InterFaces;
using UnityEngine;

public class ShieldState : IHealthState
{
    private float DamageModifier;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        switch (damageType)
        {
            case DamageTypes.Fire:
                DamageModifier = 0.5f;
                break;
            case DamageTypes.Shock:
                DamageModifier = 1.5f;
                break;
            case DamageTypes.Corrosion:
                DamageModifier = 0.8f;
                break;
        }
        
        float floatAmount = amount;
        floatAmount *= DamageModifier;
        amount = (int)floatAmount;
        
        enemyHealth.shield -= amount;
        Debug.Log("shield damage, " + amount);
        if (enemyHealth.shield <= 0)
        {
            enemyHealth.setState(new ArmorState());
        }
    }
}

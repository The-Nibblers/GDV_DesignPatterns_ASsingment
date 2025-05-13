using System;
using InterFaces;
using UnityEditor.Timeline;
using UnityEngine;

public class ArmorState : IHealthState
{
    private float DamageModifier;
    private float DamageReductionModifier = 0.8f;
    private bool DamageReduction = true;
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {       
        switch (damageType)
        {
            case DamageTypes.Fire:
                DamageModifier = 0.8f;
                break;
            case DamageTypes.Shock:
                DamageModifier = 0.9f;
                break;
            case DamageTypes.Corrosion:
                DamageModifier = 2.0f;
                break;
        }
        
        float floatAmount = amount;
        floatAmount *= DamageModifier;
        amount = (int)floatAmount;

        if (DamageReduction)
        {
            float floatReductionAmount = amount;
            floatAmount *= DamageReductionModifier;
            amount = (int)floatReductionAmount;
        }
        
        enemyHealth.armor -= amount;
        Debug.Log("armor damage, " + amount);
        if (enemyHealth.armor <= 0)
        {
            enemyHealth.setState(new HealthState());
        }
    }
}

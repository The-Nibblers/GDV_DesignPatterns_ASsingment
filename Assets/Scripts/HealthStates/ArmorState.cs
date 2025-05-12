using System;
using InterFaces;
using UnityEditor.Timeline;
using UnityEngine;

public class ArmorState : IHealthState
{
    public void TakeDamage(HealthSystem enemyHealth, int amount)
    {
        enemyHealth.armor -= amount;
        Debug.Log("armor damage");
        if (enemyHealth.armor <= 0)
        {
            enemyHealth.setState(new HealthState());
        }
    }
}

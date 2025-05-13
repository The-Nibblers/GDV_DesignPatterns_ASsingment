using InterFaces;
using UnityEngine;

public class DeadState : IHealthState
{
    public void TakeDamage(HealthSystem enemyHealth, int amount, DamageTypes damageType)
    {
        Debug.Log("enemy is dead, no damage taken");
    }
}

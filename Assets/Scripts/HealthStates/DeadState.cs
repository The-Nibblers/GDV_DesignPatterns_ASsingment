using InterFaces;
using UnityEngine;

public class DeadState : IHealthState
{
    public void TakeDamage(HealthSystem enemyHealth, int amount)
    {
        Debug.Log("enemy is dead, no damage taken");
    }
}

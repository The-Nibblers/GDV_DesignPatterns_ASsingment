using InterFaces;
using UnityEngine;

public class HealthState : IHealthState
{
    public void TakeDamage(HealthSystem enemyHealth, int amount)
    {
        enemyHealth.health -= amount;
        Debug.Log("health damage");
        if (enemyHealth.health <= 0)
        {
            enemyHealth.setState(new DeadState());
        }
    }
}

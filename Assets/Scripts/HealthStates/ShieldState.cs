using InterFaces;
using UnityEngine;

public class ShieldState : IHealthState
{
    public void TakeDamage(HealthSystem enemyHealth, int amount)
    {
        enemyHealth.shield -= amount;
        Debug.Log("shield damage");
        if (enemyHealth.shield <= 0)
        {
            enemyHealth.setState(new ArmorState());
        }
    }
}

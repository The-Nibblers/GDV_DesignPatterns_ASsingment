using UnityEngine;

public class Enemy
{
    public HealthSystem enemyHealth;

    public Enemy()
    {
        enemyHealth = new HealthSystem(100,100,100);
    }
}

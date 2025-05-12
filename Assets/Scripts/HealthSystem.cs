using InterFaces;
using UnityEngine;

public class HealthSystem
{
    public int shield = 30;
    public int health = 100;
    public int armor = 100;
    private IHealthState currentState;

    public HealthSystem()
    {
        currentState = new ShieldState();
    }

    public void setState(IHealthState newState)
    {
        currentState = newState;
    }

    public void TakeDamage(int damage)
    {
        currentState.TakeDamage(this, damage);
    }
}

using InterFaces;
using UnityEngine;

public class HealthSystem
{
    public int shield;
    public int health;
    public int armor;
    private IHealthState currentState;

    public HealthSystem(int _shield, int _health, int _armor)
    {
        currentState = new ShieldState();
        shield = _shield;
        health = _health;
        armor = _armor;
    }

    public void setState(IHealthState newState)
    {
        currentState = newState;
    }

    public void TakeDamage(int damage, DamageTypes damageType)
    {
        currentState.TakeDamage(this, damage, damageType);
    }
}

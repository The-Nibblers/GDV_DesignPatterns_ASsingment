using UnityEngine;

public class Test : MonoBehaviour
{
    private IGun weapon;
    private HealthSystem EnemyHealth;
    
    void Start()
    {
        weapon = new ShockGun();
        EnemyHealth = new HealthSystem();
        weapon.Shoot(EnemyHealth);
        weapon.Shoot(EnemyHealth);
        weapon.Shoot(EnemyHealth);
    }
}

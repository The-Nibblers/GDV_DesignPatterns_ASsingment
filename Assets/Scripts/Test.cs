using UnityEngine;

public class Test : MonoBehaviour
{
    private IGun weapon;
    private HealthSystem EnemyHealth;
    
    void Start()
    {
        weapon = new ShockGun();
        EnemyHealth = new HealthSystem(30,50,100);
        weapon.Shoot(EnemyHealth);
        weapon.Shoot(EnemyHealth);
        weapon.Shoot(EnemyHealth);
    }
}
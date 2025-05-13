using InterFaces;
using UnityEngine;

public class FireGun : IGun
{
    private DamageTypes weaponElement = DamageTypes.Fire;

    private IDamageType damageTypes;

    public FireGun()
    {
        damageTypes = DamageFactory.CreateDamageType(weaponElement);
    }
    
    public void Shoot(HealthSystem enemy, int damage)
    {
        damageTypes.ApplyDamage(enemy, damage);
    }
}

using InterFaces;
using UnityEngine;

public class ShockGun : IGun
{
    private DamageTypes damageType = DamageTypes.Shock;

    private IDamageType damageTypes;

    public ShockGun()
    {
        damageTypes = DamageFactory.CreateDamageType(damageType);
    }
    public void Shoot(HealthSystem enemy)
    {
        damageTypes.ApplyDamage(enemy);
    }
}

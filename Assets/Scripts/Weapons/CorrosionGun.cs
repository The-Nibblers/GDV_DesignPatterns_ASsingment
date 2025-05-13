using InterFaces;
using UnityEngine;

public class CorrosionGun : IGun
{
    private DamageTypes weaponElement = DamageTypes.Corrosion;

    private IDamageType damageTypes;

    public CorrosionGun()
    {
        damageTypes = DamageFactory.CreateDamageType(weaponElement);
    }
    
    public void Shoot(HealthSystem enemy)
    {
        damageTypes.ApplyDamage(enemy);
    }
}

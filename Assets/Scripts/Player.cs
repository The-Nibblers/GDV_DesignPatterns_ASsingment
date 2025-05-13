using UnityEngine;

public class Player
{
    private IGun ShockGun;
    private IGun FireGun;
    private IGun CorrosionGun;
    public IGun currentGun;
    
    public Player()
    {
        ShockGun = new ShockGun();
        FireGun = new FireGun();
        CorrosionGun = new CorrosionGun();
        currentGun = ShockGun;
    }

    public void SwitchGun(DamageTypes damageType)
    {
        switch (damageType)
        {
            case DamageTypes.Corrosion:
                currentGun = CorrosionGun;
                break;
            case DamageTypes.Fire:
                currentGun = FireGun;
                break;
            case DamageTypes.Shock:
                currentGun = ShockGun;
                break;
        }
    }

    public void Shoot(HealthSystem healthSystem)
    {
        currentGun.Shoot(healthSystem);
    }
}

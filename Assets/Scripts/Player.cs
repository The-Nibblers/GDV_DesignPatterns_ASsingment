using UnityEngine;

public class Player
{
    private IGun ShockGun;
    private IGun FireGun;
    private IGun CorrosionGun;
    private int gunDamage = 30;
    
    public IGun currentGun;
    
    public Player()
    {
        ShockGun = new ShockGun();
        FireGun = new FireGun();
        CorrosionGun = new CorrosionGun();
        Debug.Log("Shock gun equipped");
        currentGun = ShockGun;
    }

    public void SwitchGun(DamageTypes damageType)
    {
        switch (damageType)
        {
            case DamageTypes.Corrosion:
                Debug.Log("Corrosion gun equipped");
                currentGun = CorrosionGun;
                break;
            case DamageTypes.Fire:
                Debug.Log("Fire gun equipped");
                currentGun = FireGun;
                break;
            case DamageTypes.Shock:
                Debug.Log("Shock gun equipped");
                currentGun = ShockGun;
                break;
        }
    }

    public void Shoot(HealthSystem healthSystem)
    {
        currentGun.Shoot(healthSystem, gunDamage);
    }
}

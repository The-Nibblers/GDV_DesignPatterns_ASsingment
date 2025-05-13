using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;

    private Enemy Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = new Player();
        Enemy = new Enemy();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.Shoot(Enemy.enemyHealth);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.SwitchGun(DamageTypes.Shock);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.SwitchGun(DamageTypes.Fire);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.SwitchGun(DamageTypes.Corrosion);
        }
    }
}

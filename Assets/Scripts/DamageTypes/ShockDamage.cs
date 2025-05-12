using InterFaces;
using UnityEngine;

public class ShockDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        Debug.Log("Deal Shock Damage");
    }
}

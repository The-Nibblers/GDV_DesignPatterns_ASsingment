using InterFaces;
using UnityEngine;

public class FireDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        Debug.Log("Deal Fire Damage");
    }
}

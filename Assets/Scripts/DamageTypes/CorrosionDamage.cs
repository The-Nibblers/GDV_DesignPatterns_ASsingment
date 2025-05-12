using InterFaces;
using UnityEngine;

public class CorrosionDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy)
    {
        Debug.Log("Deal Corrosion Damage");
    }
}

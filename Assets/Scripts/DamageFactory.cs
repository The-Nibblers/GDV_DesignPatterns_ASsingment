using System;
using InterFaces;
using UnityEngine;

public enum DamageTypes
{
    Fire,
    Shock,
    Corrosion,
}


public class DamageFactory
{
    public static IDamageType CreateDamageType(DamageTypes damageType)
    {
        switch (damageType)
        {
            case DamageTypes.Fire:
                return new FireDamage();
                break;
            case DamageTypes.Corrosion:
                return new CorrosionDamage();
                break;
            case DamageTypes.Shock:
                return new ShockDamage();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(damageType), $"No damage type for {damageType}");
        }
    }
}
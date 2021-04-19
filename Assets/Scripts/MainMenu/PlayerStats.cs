using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Power
{
    strength1, strength2, strength3
}

public enum Trait
{
    strongWilled, weakWilled, insane
}


public class PlayerStats : MonoBehaviour
{
    public static Power[] powers;
    public static Trait[] traits;
    public int points;

    public void AddPowers(Power power)
    {
        Power[] tempPowerArray = new Power[powers.Length + 1];
        powers.CopyTo(tempPowerArray, 0);
        tempPowerArray[powers.Length] = power;
        powers = tempPowerArray;
    }

    public void RemovePowers(Power power)
    {
        Power[] tempPowerArray = new Power[powers.Length - 1];
        int j = 0;
        for (int i = 0; i < powers.Length; i++)
        {
            if (power != powers[i])
            {
                tempPowerArray[j] = powers[i];
                j++;
            }
        }
        powers = tempPowerArray;
    }
    public void AddTraits(Trait trait)
    {
        Trait[] tempTraitArray = new Trait[traits.Length + 1];
        traits.CopyTo(tempTraitArray, 0);
        tempTraitArray[traits.Length] = trait;
        traits = tempTraitArray;
    }

    public void RemoveTraits(Trait trait)
    {
        Trait[] tempTraitArray = new Trait[traits.Length - 1];
        int j = 0;
        for (int i = 0; i < traits.Length; i++)
        {
            if (trait != traits[i])
            {
                tempTraitArray[j] = traits[i];
                j++;
            }
        }
        traits = tempTraitArray;
    }
}

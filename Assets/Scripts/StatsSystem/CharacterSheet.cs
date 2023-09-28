using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CharacterSheet", menuName ="ScriptableObject/CharacterSheet")]
public class CharacterSheet : ScriptableObject
{
    public CharacterClass characterClass;
    public Stats characterBaseStats;
    public int Strength;
    public int Damage;
    public int Speed;
    public int Vision;
    public int Range;
    public int Health;
}